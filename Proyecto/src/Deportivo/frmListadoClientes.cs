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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DeportivoDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.ClientesTableAdapter.Fill(this.DeportivoDataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
