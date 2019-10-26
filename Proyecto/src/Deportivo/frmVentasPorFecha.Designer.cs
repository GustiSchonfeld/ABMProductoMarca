namespace Deportivo
{
    partial class frmVentasPorFecha
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvVentasFecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSVentasFecha = new Deportivo.DSVentasFecha();
            this.FacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturasTableAdapter = new Deportivo.DSVentasFechaTableAdapters.FacturasTableAdapter();
            this.facturasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVentasFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSVentasFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentasFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvVentasFecha
            // 
            reportDataSource1.Name = "DSVentasFecha";
            reportDataSource1.Value = this.dataTable1BindingSource1;
            this.rpvVentasFecha.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvVentasFecha.LocalReport.ReportEmbeddedResource = "Deportivo.ReportVentasFecha.rdlc";
            this.rpvVentasFecha.Location = new System.Drawing.Point(12, 39);
            this.rpvVentasFecha.Name = "rpvVentasFecha";
            this.rpvVentasFecha.Size = new System.Drawing.Size(740, 210);
            this.rpvVentasFecha.TabIndex = 0;
            // 
            // DSVentasFecha
            // 
            this.DSVentasFecha.DataSetName = "DSVentasFecha";
            this.DSVentasFecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturasBindingSource
            // 
            this.FacturasBindingSource.DataMember = "Facturas";
            this.FacturasBindingSource.DataSource = this.DSVentasFecha;
            // 
            // FacturasTableAdapter
            // 
            this.FacturasTableAdapter.ClearBeforeFill = true;
            // 
            // facturasBindingSource1
            // 
            this.facturasBindingSource1.DataMember = "Facturas";
            this.facturasBindingSource1.DataSource = this.DSVentasFecha;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.DSVentasFecha;
            // 
            // dSVentasFechaBindingSource
            // 
            this.dSVentasFechaBindingSource.DataSource = this.DSVentasFecha;
            this.dSVentasFechaBindingSource.Position = 0;
            // 
            // facturasBindingSource2
            // 
            this.facturasBindingSource2.DataMember = "Facturas";
            this.facturasBindingSource2.DataSource = this.dSVentasFechaBindingSource;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.DSVentasFecha;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Hasta:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVentasPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rpvVentasFecha);
            this.Name = "frmVentasPorFecha";
            this.Text = "frmVentasPorFecha";
         //   this.Load += new System.EventHandler(this.frmVentasPorFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSVentasFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentasFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvVentasFecha;
        private System.Windows.Forms.BindingSource FacturasBindingSource;
        private DSVentasFecha DSVentasFecha;
        private DSVentasFechaTableAdapters.FacturasTableAdapter FacturasTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource facturasBindingSource1;
        private System.Windows.Forms.BindingSource dSVentasFechaBindingSource;
        private System.Windows.Forms.BindingSource facturasBindingSource2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}