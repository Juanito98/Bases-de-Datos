namespace Cadenas.Tablas
{
    partial class Producto
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
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btActualizar = new System.Windows.Forms.Button();
            this.dsProductos = new dsProductos();
            this.t4PRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t4PRODUCTOTableAdapter = new dsProductosTableAdapters.T4PRODUCTOTableAdapter();
            this.iDPRODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4PRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProductos
            // 
            this.dgProductos.AutoGenerateColumns = false;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.mARCADataGridViewTextBoxColumn});
            this.dgProductos.DataSource = this.t4PRODUCTOBindingSource;
            this.dgProductos.Location = new System.Drawing.Point(12, 12);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(349, 247);
            this.dgProductos.TabIndex = 0;
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(286, 265);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 1;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // dsProductos
            // 
            this.dsProductos.DataSetName = "dsProductos";
            this.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t4PRODUCTOBindingSource
            // 
            this.t4PRODUCTOBindingSource.DataMember = "T4PRODUCTO";
            this.t4PRODUCTOBindingSource.DataSource = this.dsProductos;
            // 
            // t4PRODUCTOTableAdapter
            // 
            this.t4PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // iDPRODDataGridViewTextBoxColumn
            // 
            this.iDPRODDataGridViewTextBoxColumn.DataPropertyName = "IDPROD";
            this.iDPRODDataGridViewTextBoxColumn.HeaderText = "IDPROD";
            this.iDPRODDataGridViewTextBoxColumn.Name = "iDPRODDataGridViewTextBoxColumn";
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            // 
            // mARCADataGridViewTextBoxColumn
            // 
            this.mARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA";
            this.mARCADataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.mARCADataGridViewTextBoxColumn.Name = "mARCADataGridViewTextBoxColumn";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 295);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.dgProductos);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4PRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Button btActualizar;
        private dsProductos dsProductos;
        private System.Windows.Forms.BindingSource t4PRODUCTOBindingSource;
        private dsProductosTableAdapters.T4PRODUCTOTableAdapter t4PRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCADataGridViewTextBoxColumn;
    }
}