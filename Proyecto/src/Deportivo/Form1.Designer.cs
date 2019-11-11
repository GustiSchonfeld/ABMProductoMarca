namespace Deportivo
{
    partial class frmInformeProducto
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new Deportivo.DataSet1();
            this.DSProductoMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSProductoMarcaTableAdapter = new Deportivo.DataSet1TableAdapters.DSProductoMarcaTableAdapter();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSProductoMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DSProductoMarcaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Deportivo.ReportProductoMarca.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(720, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DSProductoMarcaBindingSource
            // 
            this.DSProductoMarcaBindingSource.DataMember = "DSProductoMarca";
            this.DSProductoMarcaBindingSource.DataSource = this.DataSet1;
            // 
            // DSProductoMarcaTableAdapter
            // 
            this.DSProductoMarcaTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.DataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // frmInformeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 527);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeProducto";
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.frmInformeProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSProductoMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DSProductoMarcaBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DSProductoMarcaTableAdapter DSProductoMarcaTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
    }
}