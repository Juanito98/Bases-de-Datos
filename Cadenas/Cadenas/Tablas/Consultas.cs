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
    public partial class Consultas : Form
    {
        String pregunta;
        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMontoTotalSuc.MONTOTOTALSUC' Puede moverla o quitarla según sea necesario.
            this.mONTOTOTALSUCTableAdapter.Fill(this.dsMontoTotalSuc.MONTOTOTALSUC);
            // TODO: esta línea de código carga datos en la tabla 'dsMasSucursales.MASSUCURSALES' Puede moverla o quitarla según sea necesario.
            this.mASSUCURSALESTableAdapter.Fill(this.dsMasSucursales.MASSUCURSALES);
            // TODO: esta línea de código carga datos en la tabla 'dsSinCompras.SINCOMPRAS' Puede moverla o quitarla según sea necesario.
            this.sINCOMPRASTableAdapter.Fill(this.dsSinCompras.SINCOMPRAS);
            // TODO: esta línea de código carga datos en la tabla 'dsSaldoGlobal.SALDOGLOBAL10' Puede moverla o quitarla según sea necesario.
            this.sALDOGLOBAL10TableAdapter.Fill(this.dsSaldoGlobal.SALDOGLOBAL10);

        }
        private void menuConsultaA_Click(object sender, EventArgs e)
        {
            pregunta = "Consulta: dado el nombre de una cadena, \nobtener el nombre de los clientes cuyo saldo global es \nmenor al 10% del monto total de los artículos que compraron. ";
            lbPregunta.Text = pregunta;
            lbPregunta.Visible = true;
            dgConsultas.DataSource = this.sALDOGLOBAL10BindingSource;
        }

        private void menuConsultaB_Click(object sender, EventArgs e)
        {
            pregunta = "Consulta: listar el nombre de los clientes que no han hecho compras este mes. \nMostrar también el nombre de las cadenas donde tienen crédito";
            lbPregunta.Text = pregunta;
            lbPregunta.Visible = true;
            dgConsultas.DataSource = this.sINCOMPRASBindingSource;
        }

        private void menuConsultaC_Click(object sender, EventArgs e)
        {
            pregunta = "Consulta: escribir para cada cadena el nombre de sus sucursales y \nel monto total de ventas que realizaron el mes pasado (por sucursal, considerando todas las ventas que hicieron). \nMuestre sólo aquellas que vendieron menos de $50,000.";
            lbPregunta.Text = pregunta;
            lbPregunta.Visible = true;
            dgConsultas.DataSource = this.mONTOTOTALSUCBindingSource;
        }

        private void menuConsultaD_Click(object sender, EventArgs e)
        {
            pregunta = "Consulta: mostrar el nombre de la cadena que tiene más sucursales, \nindicando el nombre y domicilio de éstas.";
            lbPregunta.Text = pregunta;
            lbPregunta.Visible = true;
            dgConsultas.DataSource = this.mASSUCURSALESBindingSource;
        }
    }
}
