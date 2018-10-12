using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadenas.Tablas {
    public partial class Compras : Form {
        public Compras() {
            InitializeComponent();
        }

        GestorBD.GestorBD gestorBD;
        Comunes comunes = new Comunes();
        String cadSql;
        DataSet dsClientes = new DataSet(), dsCompras = new DataSet();

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            // Obtenemos el id del cliente seleccionado
            int idCliente = Convert.ToInt32(dsClientes.Tables["Clientes"].
                Select(String.Format("nom = '{0}'", cboClientes.Text))[0]["idCliente"].ToString());
            
            // Llenamos el combo de las compras por cada cliente
            cadSql = String.Format("select f.idFactura, fecha, cantArticulos, montoTot, noPagos, cantPagada, saldoAct from T4Factura f, (select idFactura, count(*) AS noPagos, sum(montoPagado) AS cantPagada from T4Pago group by idFactura) p, (select idFactura, sum(cantidad)AS cantArticulos from T4DE group by idFactura) d where f.idFactura = p.idFactura and d.idFactura = p.idFactura and idCliente = {0} and fecha > '{1}'", idCliente, fechaCompra.Text);
            gestorBD.consBD(cadSql, dsCompras, "Compras");

            dgCompras.DataSource = dsCompras.Tables["Compras"];
        }

        private void Compras_Load(object sender, EventArgs e) {
            //1. Acceso a la BD
            gestorBD = new GestorBD.GestorBD("MSDAORA", "bd06", "patsig", "oracle");

            // Llenamos el combo box de clientes
            cadSql = "select * from T4Cliente";
            gestorBD.consBD(cadSql, dsClientes, "Clientes");
            comunes.cargaCombo(cboClientes, dsClientes, "Clientes", "nom");
        }
    }
}
