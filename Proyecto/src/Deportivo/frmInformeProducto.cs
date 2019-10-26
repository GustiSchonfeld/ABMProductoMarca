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
    public partial class frmInformeProducto : Form
    {
        public frmInformeProducto()
        {
            InitializeComponent();
        }

        private void frmInformeProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSproducto.Productos' Puede moverla o quitarla según sea necesario.
            this.ProductosTableAdapter.Fill(this.DSproducto.Productos);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
