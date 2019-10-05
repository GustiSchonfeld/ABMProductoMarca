using Deportivo.BusinessLayer;
using Deportivo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deportivo.GUILayer.Mantenimiento
{
    public partial class frmABMMarca : Form
    {
        //formmode es una enumeracion para saber si hacer insert delete o update
        //por defecto es un insert
        private FormMode formMode = FormMode.insert;

        private readonly MarcaService oMarcaService;
        private Marca oMarcaSelected;

        public frmABMMarca()
        {
            InitializeComponent();
            oMarcaService = new MarcaService();
        }
        // bandera para saber si vengo para agregar,editar o borrado logico
        public enum FormMode
        {
            insert,
            update,
            delete
        }
        public void InicializarDetalleMarca(int idMarca)
        {
            var marca = oMarcaService.ConsultarMarcasPorId(idMarca);

            if (marca != null)
            {
                txtID.Text = marca.IdMarca.ToString();
                txtMarca.Text = marca.Descripcion.ToString();
               
               }

            
        }


        private void frmABMMarca_Load(System.Object sender, System.EventArgs e)
        {
            
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Marca";
                        txtID.Enabled = false;
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Marca";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtID.Enabled = false;
                        txtMarca.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Deshabilitar Marca";
                        txtID.Enabled = false;
                        txtMarca.Enabled = false;
                        break;
                    }
            }
        }

        public void SeleccionarMarca(FormMode op, Marca marcaSelected)
        {
            formMode = op;
            oMarcaSelected = marcaSelected;
        }

        private void MostrarDatos()
        {
            if (oMarcaSelected != null)
            {
                txtID.Text = oMarcaSelected.IdMarca.ToString();
                txtMarca.Text = oMarcaSelected.Descripcion.ToString();
               
            }
        }

        private void btnAceptar_Click(System.Object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        
                            if (ValidarCampos())
                            {
                                var oMarca = new Marca();
                                oMarca.Descripcion = txtMarca.Text;

                                if (oMarcaService.CrearMarca(oMarca))
                                {
                                    MessageBox.Show("Marca creado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            break;
                        
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oMarcaSelected.Descripcion = txtMarca.Text;
                           

                            if (oMarcaService.ActualizarMarca(oMarcaSelected))
                            {
                                MessageBox.Show("Marca actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la marca!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el producto seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oMarcaService.ModificarBorradoMarca(oMarcaSelected))
                            {
                                MessageBox.Show("Marca Habilitada/Deshabilitada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar la marca!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }
        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtMarca.Text == string.Empty)
            {
                txtMarca.BackColor = Color.Red;
                txtMarca.Focus();
                return false;
            }
            else
                txtMarca.BackColor = Color.White;

            return true;
        }


        private void LlenarCombo(ComboBox cbo, Object source, string mostrar, String valor)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = mostrar;
            cbo.ValueMember = valor;
            cbo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
