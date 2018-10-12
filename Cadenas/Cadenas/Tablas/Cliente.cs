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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsClientes.T4CLIENTE' Puede moverla o quitarla según sea necesario.
            this.t4CLIENTETableAdapter.Fill(this.dsClientes.T4CLIENTE);

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            this.t4CLIENTETableAdapter.Update(this.dsClientes);
        }
    }
}
