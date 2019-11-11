using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deportivo
{
    public partial class frmInformeMarca : Form
    {
        public frmInformeMarca()
        {
            InitializeComponent();
        }

        private void frmInformeMarca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DeportivoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.ClientesTableAdapter.Fill(this.DeportivoDataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.Marcas' Puede moverla o quitarla según sea necesario.
            this.MarcasTableAdapter.Fill(this.DataSet2.Marcas);

            this.reportViewer1.RefreshReport();
        }
    }
}
