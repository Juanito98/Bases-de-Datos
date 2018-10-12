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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsProductos.T4PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.t4PRODUCTOTableAdapter.Fill(this.dsProductos.T4PRODUCTO);

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            this.t4PRODUCTOTableAdapter.Update(dsProductos);
        }
    }
}
