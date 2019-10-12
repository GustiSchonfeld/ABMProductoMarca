using Deportivo.GUILayer.Login;
using Deportivo.GUILayer.Usuarios;
using Deportivo.GUILayer.Mantenimiento;
using Deportivo.GUILayer;

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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
         //   frmLogin login = new frmLogin();
         //   login.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

        private void consultarBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProductos frmConsultaProducto = new frmConsultaProductos();
            frmConsultaProducto.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmCUsuarios = new frmUsuarios();
            frmCUsuarios.ShowDialog();

        }

        private void consultarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMarca frmConsultaMarca = new frmConsultaMarca();
            frmConsultaMarca.ShowDialog();
        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientes frmConsultaCli = new frmConsultaClientes();
            frmConsultaCli.ShowDialog();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura frmFacturita = new frmFactura();
            frmFacturita.ShowDialog();
        }

        private void pruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercitacion Prueba = new Ejercitacion();
            Prueba.ShowDialog();
        }

      


    }
}
