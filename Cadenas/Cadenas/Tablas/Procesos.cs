using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadenas.Tablas
{
    public partial class Procesos : Form
    {
        GestorBD.GestorBD GestorBD;
        Comunes comunes = new Comunes();
        DataSet dsProductos = new DataSet();
        DataSet dsCadenas = new DataSet();
        DataSet dsSucursales = new DataSet();
        OleDbConnection miConexion;
        public Procesos()
        {
            InitializeComponent();
        }

        private void Procesos_Load(object sender, EventArgs e)
        {
            String query;

            //1. Acceso a la BD
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd06", "patsig", "oracle");

            //2. Obtiene los datos de los alumnos y se muestra en el grid.
            query = "select * from T4Producto";
            GestorBD.consBD(query, dsProductos, "Productos");
            comunes.cargaCombo(cbProductos, dsProductos, "Productos", "nom");

            query = "select * from T4Cadena";
            GestorBD.consBD(query, dsCadenas, "Cadenas");
            comunes.cargaCombo(cbCadenas, dsCadenas, "Cadenas", "nom");


        }

        private void btFuncion_Click(object sender, EventArgs e)
        {
            String sucursal;
            int numArticulos;
            OleDbCommand funcion;
            OleDbParameter parNumArticulos;
            OleDbParameter parSucursal;

            //1- Abrir la conexión a la BD.
            miConexion = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd06;Password=patsig");
            miConexion.Open();
            funcion = new OleDbCommand();
            funcion.Connection = miConexion;

            //2- Especificar el llamado a la función.
            funcion.CommandText = "numArticulos";
            funcion.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            // a) Nota: primero hay que definir el tipo de valor que regresará la función. Parámetros de salida.
            parNumArticulos = new OleDbParameter("RETURN_VALUE", OleDbType.Integer,
              4, ParameterDirection.ReturnValue, false, 4, 0, "numArticulos", DataRowVersion.Current, 0);
            funcion.Parameters.Add(parNumArticulos);

            // b) luego hay que definir los parámetros de entrada (uno en este caso).
            sucursal = cbSucursales.SelectedItem.ToString();
            parSucursal = new OleDbParameter("sucursal", sucursal);
            funcion.Parameters.Add(parSucursal);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try
            {
                funcion.ExecuteNonQuery();

                //5- Recuperar el valor regresado por la función.
                numArticulos = Convert.ToInt16(funcion.Parameters["RETURN_VALUE"].Value);
                MessageBox.Show("Cantidad de artículos que vende " + sucursal + ": " + numArticulos);
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            miConexion.Close();
        }

        private void btProcedimiento_Click(object sender, EventArgs e)
        {
            
            String cadena;
            double monto;
            int cantidad;
            OleDbCommand procedimiento;
            OleDbParameter parProd;
            OleDbParameter parMonto;
            OleDbParameter parCantidad;
            OleDbParameter parCadena;

            //1- Abrir la conexión a la BD.
            miConexion = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd06;Password=patsig");
            miConexion.Open();
            procedimiento = new OleDbCommand();
            procedimiento.Connection = miConexion;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            procedimiento.CommandText = "ProductoAPrecio";
            procedimiento.CommandType = CommandType.StoredProcedure;


            //3- Especificar los parámetros:
            //a) primero todos los de entrada:
            parProd = new OleDbParameter("producto", cbProductos.SelectedItem);
            procedimiento.Parameters.Add(parProd);

            monto = Int32.Parse(tbMonto.Text);
            parMonto = new OleDbParameter("monto", monto);
            procedimiento.Parameters.Add(parMonto);

            //b) luego todos los de salida (uno en este caso):
            parCantidad = new OleDbParameter("cant", OleDbType.Integer,
              4, ParameterDirection.Output, false, 4, 0, "parCantidad", DataRowVersion.Current, 0); //PREGUNTAR CARLITOS
            procedimiento.Parameters.Add(parCantidad);

            parCadena = new OleDbParameter("cad", OleDbType.VarChar,
              8, ParameterDirection.Output, false, 8, 0, "parCadena", DataRowVersion.Current, 0); //PREGUNTAR CARLITOS
            procedimiento.Parameters.Add(parCadena);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try
            {
                procedimiento.ExecuteNonQuery();

                //5- Recuperar el (los) valor(es) regresado(s) por medio del (de los)
                //   parámetro(s) de salida.
                cantidad = Convert.ToInt16(procedimiento.Parameters["cant"].Value);
                cadena = Convert.ToString(procedimiento.Parameters["cad"].Value);
                MessageBox.Show("Cant. de cadenas que ofrecen " + cbProductos.SelectedItem+ " a menos de " + monto + ": " + cantidad 
                    + "\nUn ejemplo de cadena es:" + cadena);
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            miConexion.Close();
        }

        private void cbCadenas_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query;
            string rfc = dsCadenas.Tables["Cadenas"].Select(String.Format("nom ='{0}'", cbCadenas.Text))[0]["RFC"].ToString();
            query = "select * from T4Sucursal where RFC = '" + rfc + "'";
            GestorBD.consBD(query, dsSucursales, "Sucursales");
            comunes.cargaCombo(cbSucursales, dsSucursales, "Sucursales", "nom");
        }
    }
}
