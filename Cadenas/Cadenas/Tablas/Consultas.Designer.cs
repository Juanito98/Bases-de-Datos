namespace Cadenas.Tablas
{
    partial class Consultas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuConsultaA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaD = new System.Windows.Forms.ToolStripMenuItem();
            this.lbPregunta = new System.Windows.Forms.Label();
            this.dgConsultas = new System.Windows.Forms.DataGridView();
            this.dsSaldoGlobal = new dsSaldoGlobal();
            this.sALDOGLOBAL10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALDOGLOBAL10TableAdapter = new dsSaldoGlobalTableAdapters.SALDOGLOBAL10TableAdapter();
            this.dsSinCompras = new dsSinCompras();
            this.sINCOMPRASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINCOMPRASTableAdapter = new dsSinComprasTableAdapters.SINCOMPRASTableAdapter();
            this.dsMasSucursales = new dsMasSucursales();
            this.mASSUCURSALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASSUCURSALESTableAdapter = new dsMasSucursalesTableAdapters.MASSUCURSALESTableAdapter();
            this.dsMontoTotalSuc = new dsMontoTotalSuc();
            this.mONTOTOTALSUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONTOTOTALSUCTableAdapter = new dsMontoTotalSucTableAdapters.MONTOTOTALSUCTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaldoGlobal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALDOGLOBAL10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSinCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINCOMPRASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASSUCURSALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMontoTotalSuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTOTOTALSUCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsultaA,
            this.menuConsultaB,
            this.menuConsultaC,
            this.menuConsultaD});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuConsultaA
            // 
            this.menuConsultaA.Name = "menuConsultaA";
            this.menuConsultaA.Size = new System.Drawing.Size(77, 20);
            this.menuConsultaA.Text = "Consulta A";
            this.menuConsultaA.Click += new System.EventHandler(this.menuConsultaA_Click);
            // 
            // menuConsultaB
            // 
            this.menuConsultaB.Name = "menuConsultaB";
            this.menuConsultaB.Size = new System.Drawing.Size(76, 20);
            this.menuConsultaB.Text = "Consulta B";
            this.menuConsultaB.Click += new System.EventHandler(this.menuConsultaB_Click);
            // 
            // menuConsultaC
            // 
            this.menuConsultaC.Name = "menuConsultaC";
            this.menuConsultaC.Size = new System.Drawing.Size(77, 20);
            this.menuConsultaC.Text = "Consulta C";
            this.menuConsultaC.Click += new System.EventHandler(this.menuConsultaC_Click);
            // 
            // menuConsultaD
            // 
            this.menuConsultaD.Name = "menuConsultaD";
            this.menuConsultaD.Size = new System.Drawing.Size(77, 20);
            this.menuConsultaD.Text = "Consulta D";
            this.menuConsultaD.Click += new System.EventHandler(this.menuConsultaD_Click);
            // 
            // lbPregunta
            // 
            this.lbPregunta.AutoSize = true;
            this.lbPregunta.Location = new System.Drawing.Point(12, 42);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(48, 13);
            this.lbPregunta.TabIndex = 1;
            this.lbPregunta.Text = "Consulta";
            this.lbPregunta.Visible = false;
            // 
            // dgConsultas
            // 
            this.dgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultas.Location = new System.Drawing.Point(15, 137);
            this.dgConsultas.Name = "dgConsultas";
            this.dgConsultas.Size = new System.Drawing.Size(390, 143);
            this.dgConsultas.TabIndex = 2;
            // 
            // dsSaldoGlobal
            // 
            this.dsSaldoGlobal.DataSetName = "dsSaldoGlobal";
            this.dsSaldoGlobal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALDOGLOBAL10BindingSource
            // 
            this.sALDOGLOBAL10BindingSource.DataMember = "SALDOGLOBAL10";
            this.sALDOGLOBAL10BindingSource.DataSource = this.dsSaldoGlobal;
            // 
            // sALDOGLOBAL10TableAdapter
            // 
            this.sALDOGLOBAL10TableAdapter.ClearBeforeFill = true;
            // 
            // dsSinCompras
            // 
            this.dsSinCompras.DataSetName = "dsSinCompras";
            this.dsSinCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINCOMPRASBindingSource
            // 
            this.sINCOMPRASBindingSource.DataMember = "SINCOMPRAS";
            this.sINCOMPRASBindingSource.DataSource = this.dsSinCompras;
            // 
            // sINCOMPRASTableAdapter
            // 
            this.sINCOMPRASTableAdapter.ClearBeforeFill = true;
            // 
            // dsMasSucursales
            // 
            this.dsMasSucursales.DataSetName = "dsMasSucursales";
            this.dsMasSucursales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mASSUCURSALESBindingSource
            // 
            this.mASSUCURSALESBindingSource.DataMember = "MASSUCURSALES";
            this.mASSUCURSALESBindingSource.DataSource = this.dsMasSucursales;
            // 
            // mASSUCURSALESTableAdapter
            // 
            this.mASSUCURSALESTableAdapter.ClearBeforeFill = true;
            // 
            // dsMontoTotalSuc
            // 
            this.dsMontoTotalSuc.DataSetName = "dsMontoTotalSuc";
            this.dsMontoTotalSuc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONTOTOTALSUCBindingSource
            // 
            this.mONTOTOTALSUCBindingSource.DataMember = "MONTOTOTALSUC";
            this.mONTOTOTALSUCBindingSource.DataSource = this.dsMontoTotalSuc;
            // 
            // mONTOTOTALSUCTableAdapter
            // 
            this.mONTOTOTALSUCTableAdapter.ClearBeforeFill = true;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 308);
            this.Controls.Add(this.dgConsultas);
            this.Controls.Add(this.lbPregunta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaldoGlobal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALDOGLOBAL10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSinCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINCOMPRASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMasSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASSUCURSALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMontoTotalSuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTOTOTALSUCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaA;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaB;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaC;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaD;
        private System.Windows.Forms.Label lbPregunta;
        private System.Windows.Forms.DataGridView dgConsultas;
        private System.Windows.Forms.BindingSource sALDOGLOBAL10BindingSource;
        private System.Windows.Forms.BindingSource sINCOMPRASBindingSource;
        private System.Windows.Forms.BindingSource mASSUCURSALESBindingSource;
        private System.Windows.Forms.BindingSource mONTOTOTALSUCBindingSource;
        private dsSaldoGlobal dsSaldoGlobal;
        private dsSaldoGlobalTableAdapters.SALDOGLOBAL10TableAdapter sALDOGLOBAL10TableAdapter;
        private dsSinCompras dsSinCompras;
        private dsSinComprasTableAdapters.SINCOMPRASTableAdapter sINCOMPRASTableAdapter;
        private dsMasSucursales dsMasSucursales;
        private dsMasSucursalesTableAdapters.MASSUCURSALESTableAdapter mASSUCURSALESTableAdapter;
        private dsMontoTotalSuc dsMontoTotalSuc;
        private dsMontoTotalSucTableAdapters.MONTOTOTALSUCTableAdapter mONTOTOTALSUCTableAdapter;
    }
}