using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadenas.Tablas
{
    public partial class RegistroCompra : Form
    {
        public RegistroCompra()
        {
            InitializeComponent();
        }

        GestorBD.GestorBD gestorBD;
        Comunes comunes = new Comunes();
        String cadSql;
        DataSet dsClientes = new DataSet(), dsProductos = new DataSet(), dsSucursales = new DataSet();
        DataTable dtCarrito = new DataTable("Carrito");

        private void btCarrito_Click(object sender, EventArgs e)
        {
            bool yaExiste = false;
            DataRow fila = dtCarrito.NewRow();
            foreach (DataRow f in dtCarrito.Rows)
            {
                if (f["Artículo"].Equals(cboProductos.Text))
                {
                    fila = f;
                    yaExiste = true;
                }
            }
            if (!yaExiste) {
                fila["Artículo"] = cboProductos.Text;
                fila["Cantidad"] = tbCantidad.Text;
                dtCarrito.Rows.Add(fila);
                dgCarrito.DataSource = dtCarrito;
            } else
            {
                fila["Cantidad"] = Convert.ToInt32(fila["Cantidad"]) + Convert.ToInt32(tbCantidad.Text);
            }
        }

        private void RegistroCompra_Load(object sender, EventArgs e)
        {
            //1. Acceso a la BD
            gestorBD = new GestorBD.GestorBD("MSDAORA", "bd06", "patsig", "oracle");

            // Llenamos el combo box de clientes
            cadSql = "select * from T4Cliente";
            gestorBD.consBD(cadSql, dsClientes, "Clientes");
            comunes.cargaCombo(cboClientes, dsClientes, "Clientes", "nom");

            // Llenamos el combo box de productos
            cadSql = "select * from T4Producto";
            gestorBD.consBD(cadSql, dsProductos, "Productos");
            comunes.cargaCombo(cboProductos, dsProductos, "Productos", "nom");

            // Llenamos el combo box de sucursal
            cadSql = "select * from T4Sucursal";
            gestorBD.consBD(cadSql, dsSucursales, "Sucursales");
            comunes.cargaCombo(cboSucursal, dsSucursales, "Sucursales", "nom");

            // Añadimos las columnas del carrito
            dtCarrito.Columns.Add(new DataColumn("Artículo"));
            dtCarrito.Columns.Add(new DataColumn("Cantidad"));
        }
    }
}
