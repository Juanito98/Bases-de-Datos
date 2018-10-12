using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadenas
{
    public partial class Cadenas : Form
    {
        public Cadenas()
        {
            InitializeComponent();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            Tablas.Cliente c = new Tablas.Cliente();
            c.Show();
        }

        private void menuProducto_Click(object sender, EventArgs e)
        {
            Tablas.Producto p = new Tablas.Producto();
            p.Show();
        }

        private void menuConsultas_Click(object sender, EventArgs e)
        {
            Tablas.Consultas c = new Tablas.Consultas();
            c.Show();
        }

        private void menuProcesos_Click(object sender, EventArgs e)
        {
            Tablas.Procesos p = new Tablas.Procesos();
            p.Show();
        }
    }
}
