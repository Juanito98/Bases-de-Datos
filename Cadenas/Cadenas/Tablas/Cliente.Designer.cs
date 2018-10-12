namespace Cadenas.Tablas
{
    partial class Cliente
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
            this.components = new System.ComponentModel.Container();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t4CLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsClientes = new dsClientes();
            this.btActualizar = new System.Windows.Forms.Button();
            this.t4CLIENTETableAdapter = new dsClientesTableAdapters.T4CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4CLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCliente
            // 
            this.dgCliente.AutoGenerateColumns = false;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIENTEDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.tELDataGridViewTextBoxColumn,
            this.dOMDataGridViewTextBoxColumn});
            this.dgCliente.DataSource = this.t4CLIENTEBindingSource;
            this.dgCliente.Location = new System.Drawing.Point(12, 12);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.Size = new System.Drawing.Size(460, 265);
            this.dgCliente.TabIndex = 0;
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "IDCLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "IDCLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            // 
            // tELDataGridViewTextBoxColumn
            // 
            this.tELDataGridViewTextBoxColumn.DataPropertyName = "TEL";
            this.tELDataGridViewTextBoxColumn.HeaderText = "TEL";
            this.tELDataGridViewTextBoxColumn.Name = "tELDataGridViewTextBoxColumn";
            // 
            // dOMDataGridViewTextBoxColumn
            // 
            this.dOMDataGridViewTextBoxColumn.DataPropertyName = "DOM";
            this.dOMDataGridViewTextBoxColumn.HeaderText = "DOM";
            this.dOMDataGridViewTextBoxColumn.Name = "dOMDataGridViewTextBoxColumn";
            // 
            // t4CLIENTEBindingSource
            // 
            this.t4CLIENTEBindingSource.DataMember = "T4CLIENTE";
            this.t4CLIENTEBindingSource.DataSource = this.dsClientes;
            // 
            // dsClientes
            // 
            this.dsClientes.DataSetName = "dsClientes";
            this.dsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(397, 283);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 1;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // t4CLIENTETableAdapter
            // 
            this.t4CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 316);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.dgCliente);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4CLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.Button btActualizar;
        private dsClientes dsClientes;
        private System.Windows.Forms.BindingSource t4CLIENTEBindingSource;
        private dsClientesTableAdapters.T4CLIENTETableAdapter t4CLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOMDataGridViewTextBoxColumn;
    }
}