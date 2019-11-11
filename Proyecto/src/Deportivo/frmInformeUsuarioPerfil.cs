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
    public partial class frmInformeUsuarioPerfil : Form
    {
        public frmInformeUsuarioPerfil()
        {
            InitializeComponent();
        }

        private void frmUsuarioPerfil_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet3.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DataSet3.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
