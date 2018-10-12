namespace Cadenas.Tablas
{
    partial class RegistroCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCarrito = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCarrito = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(12, 27);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(121, 21);
            this.cboClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // dgCarrito
            // 
            this.dgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrito.Location = new System.Drawing.Point(15, 64);
            this.dgCarrito.Name = "dgCarrito";
            this.dgCarrito.Size = new System.Drawing.Size(267, 180);
            this.dgCarrito.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(172, 27);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(121, 21);
            this.cboProductos.TabIndex = 4;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(325, 27);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // btCarrito
            // 
            this.btCarrito.Location = new System.Drawing.Point(325, 129);
            this.btCarrito.Name = "btCarrito";
            this.btCarrito.Size = new System.Drawing.Size(75, 23);
            this.btCarrito.TabIndex = 7;
            this.btCarrito.Text = "Añadir";
            this.btCarrito.UseVisualStyleBackColor = true;
            this.btCarrito.Click += new System.EventHandler(this.btCarrito_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sucursal";
            // 
            // cboSucursal
            // 
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(312, 80);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(121, 21);
            this.cboSucursal.TabIndex = 9;
            // 
            // RegistroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 266);
            this.Controls.Add(this.cboSucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCarrito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgCarrito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClientes);
            this.Name = "RegistroCompra";
            this.Text = "RegistroCompra";
            this.Load += new System.EventHandler(this.RegistroCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCarrito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCarrito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSucursal;
    }
}