namespace Deportivo
{
    partial class frmInformeMarca
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
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Deportivo.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MarcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MarcasTableAdapter = new Deportivo.DataSet2TableAdapters.MarcasTableAdapter();
            this.DeportivoDataSet = new Deportivo.DeportivoDataSet();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientesTableAdapter = new Deportivo.DeportivoDataSetTableAdapters.ClientesTableAdapter();
            this.dataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marcasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeportivoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.DataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.marcasBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Deportivo.ReportMarcas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(709, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // MarcasBindingSource
            // 
            this.MarcasBindingSource.DataMember = "Marcas";
            this.MarcasBindingSource.DataSource = this.DataSet2;
            // 
            // MarcasTableAdapter
            // 
            this.MarcasTableAdapter.ClearBeforeFill = true;
            // 
            // DeportivoDataSet
            // 
            this.DeportivoDataSet.DataSetName = "DeportivoDataSet";
            this.DeportivoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            this.ClientesBindingSource.DataSource = this.DeportivoDataSet;
            // 
            // ClientesTableAdapter
            // 
            this.ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2BindingSource1
            // 
            this.dataSet2BindingSource1.DataSource = this.DataSet2;
            this.dataSet2BindingSource1.Position = 0;
            // 
            // marcasBindingSource1
            // 
            this.marcasBindingSource1.DataMember = "Marcas";
            this.marcasBindingSource1.DataSource = this.dataSet2BindingSource1;
            // 
            // frmInformeMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 541);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeMarca";
            this.Text = "Listado de Marcas";
            this.Load += new System.EventHandler(this.frmInformeMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeportivoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MarcasBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.MarcasTableAdapter MarcasTableAdapter;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private DeportivoDataSet DeportivoDataSet;
        private DeportivoDataSetTableAdapters.ClientesTableAdapter ClientesTableAdapter;
        private System.Windows.Forms.BindingSource marcasBindingSource1;
        private System.Windows.Forms.BindingSource dataSet2BindingSource1;
    }
}