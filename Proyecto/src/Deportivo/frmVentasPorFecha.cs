using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;
using Deportivo.DSVentasFechaTableAdapters;
using Deportivo.DataAccessLayer;



namespace Deportivo
{
    public partial class frmVentasPorFecha : Form
    {
        public frmVentasPorFecha()
        {
            InitializeComponent();
        }

        //private void frmVentasPorFecha_Load(object sender, EventArgs e)
        //{
        //    // TODO: esta línea de código carga datos en la tabla 'DSVentasFecha.Facturas' Puede moverla o quitarla según sea necesario.
        //    this.FacturasTableAdapter.Fill(this.DSVentasFecha.Facturas);

        //    this.rpvVentasFecha.RefreshReport();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
//            SELECT        nro_factura, fecha, cliente, tipoFactura, subtotal, descuento, borrado, id_factura
//FROM            Facturas AS f
//WHERE        (fecha BETWEEN @FecDesde AND @FecHasta)
            if (textBox1.Text != "" && textBox2.Text != "") 
            {
               // rpvVentasFecha.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("Fecha", textBox1.Text), new ReportParameter("Fecha", textBox2.Text) });                 
                //DATASOURCE      
                // Dictionary: Representa una colección de claves y valores.
                Dictionary<string, object> parametros = new Dictionary<string, object>();

                DateTime fechaDesde;
                DateTime fechaHasta;

                String sqlconsulta = "select c.apellido AS cliente, f.nro_factura,CONVERT(NVARCHAR(10), f.fecha,103) AS fecha,  f.tipoFactura, f.subtotal, f.descuento, f.borrado, f.id_factura FROM Facturas AS f INNER JOIN  Clientes AS c ON f.cliente = c.id";
                               
                                       sqlconsulta += " WHERE        (f.fecha BETWEEN @FecDesde AND @FecHasta)";



                if (DateTime.TryParse(textBox1.Text, out fechaDesde) &&
                    DateTime.TryParse(textBox2.Text, out fechaHasta))
                {
                    parametros.Add("FecDesde", textBox1.Text);
                    parametros.Add("FecHasta", textBox2.Text);
                
                rpvVentasFecha.LocalReport.DataSources.Clear();
                rpvVentasFecha.LocalReport.DataSources.Add(new ReportDataSource("DSVentasFecha", DBHelper.GetDBHelper().ConsultaSQLConParametros(sqlconsulta, parametros)));
                rpvVentasFecha.RefreshReport();
                }
            }
        }
    }
}
