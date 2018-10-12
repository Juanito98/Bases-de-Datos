namespace Cadenas.Tablas
{
    partial class Procesos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCadenas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSucursales = new System.Windows.Forms.ComboBox();
            this.btFuncion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.btProcedimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de artículos en la sucursal:";
            // 
            // cbCadenas
            // 
            this.cbCadenas.FormattingEnabled = true;
            this.cbCadenas.Location = new System.Drawing.Point(15, 77);
            this.cbCadenas.Name = "cbCadenas";
            this.cbCadenas.Size = new System.Drawing.Size(121, 21);
            this.cbCadenas.TabIndex = 1;
            this.cbCadenas.SelectedIndexChanged += new System.EventHandler(this.cbCadenas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sucursal";
            // 
            // cbSucursales
            // 
            this.cbSucursales.FormattingEnabled = true;
            this.cbSucursales.Location = new System.Drawing.Point(15, 127);
            this.cbSucursales.Name = "cbSucursales";
            this.cbSucursales.Size = new System.Drawing.Size(121, 21);
            this.cbSucursales.TabIndex = 4;
            // 
            // btFuncion
            // 
            this.btFuncion.Location = new System.Drawing.Point(15, 163);
            this.btFuncion.Name = "btFuncion";
            this.btFuncion.Size = new System.Drawing.Size(75, 23);
            this.btFuncion.TabIndex = 5;
            this.btFuncion.Text = "Consultar";
            this.btFuncion.UseVisualStyleBackColor = true;
            this.btFuncion.Click += new System.EventHandler(this.btFuncion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cadenas donde se puede conseguir el \r\nartículo a menor precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Producto";
            // 
            // cbProductos
            // 
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(238, 77);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(121, 21);
            this.cbProductos.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Monto";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(238, 127);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(100, 20);
            this.tbMonto.TabIndex = 10;
            // 
            // btProcedimiento
            // 
            this.btProcedimiento.Location = new System.Drawing.Point(238, 163);
            this.btProcedimiento.Name = "btProcedimiento";
            this.btProcedimiento.Size = new System.Drawing.Size(75, 23);
            this.btProcedimiento.TabIndex = 11;
            this.btProcedimiento.Text = "Buscar";
            this.btProcedimiento.UseVisualStyleBackColor = true;
            this.btProcedimiento.Click += new System.EventHandler(this.btProcedimiento_Click);
            // 
            // Procesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 212);
            this.Controls.Add(this.btProcedimiento);
            this.Controls.Add(this.tbMonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btFuncion);
            this.Controls.Add(this.cbSucursales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCadenas);
            this.Controls.Add(this.label1);
            this.Name = "Procesos";
            this.Text = "Procesos";
            this.Load += new System.EventHandler(this.Procesos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCadenas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSucursales;
        private System.Windows.Forms.Button btFuncion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Button btProcedimiento;
    }
}