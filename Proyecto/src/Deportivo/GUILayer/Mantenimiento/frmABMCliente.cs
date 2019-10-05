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
    public partial class frmABMCliente : Form
    {
        //formmode es una enumeracion para saber si hacer insert delete o update
        //por defecto es un insert
        private FormMode formMode = FormMode.insert;

        private readonly ClienteService oClienteService;
        private Cliente oClienteSelected;

        public frmABMCliente()
        {
            // dibuja el formulario
            InitializeComponent();
            // instanciar un objeto service cliente que es el que llama al dao
            oClienteService = new ClienteService();
            
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }
        public void SeleccionarCliente(FormMode op, Cliente clienteSelected)
        {
            formMode = op;
            oClienteSelected = clienteSelected;
        }

        private void MostrarDatos()
        {
            if (oClienteSelected != null)
            {
                txtid.Text = oClienteSelected.Id.ToString();
                txtapellido.Text = oClienteSelected.Apellido.ToString();
                txtnombre.Text = oClienteSelected.Nombre.ToString();
                txtcuit.Text = oClienteSelected.Cuit.ToString();
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmABMCliente_Load(object sender, EventArgs e)
        {

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Cliente";
                        txtid.Enabled = false;
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Cliente";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtid.Enabled = false;
                        txtapellido.Enabled = true;
                        txtnombre.Enabled = true;
                        txtcuit.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Deshabilitar Cliente";
                        txtid.Enabled = false;
                        txtapellido.Enabled = false;
                        txtnombre.Enabled = false;
                        txtcuit.Enabled = false;
                        break;
                    }
            }
        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        
                            if (ValidarCampos())
                            {
                                var oCliente = new Cliente();
                                oCliente.Apellido = txtapellido.Text;

                                if (oClienteService.CrearCliente(oCliente))
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
                            oClienteSelected.Apellido = txtapellido.Text;
                            oClienteSelected.Nombre = txtnombre.Text;
                            oClienteSelected.Cuit = txtcuit.Text;
                           

                            if (oClienteService.ActualizarCliente(oClienteSelected))
                            {
                                MessageBox.Show("Cliente actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el producto seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oClienteService.ModificarBorradoCliente(oClienteSelected))
                            {
                                MessageBox.Show("Cliente Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }
            
        

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtapellido.Text == string.Empty)
            {
                txtapellido.BackColor = Color.Red;
                txtapellido.Focus();
                return false;
            }
            else
                txtapellido.BackColor = Color.White;


            if (txtnombre.Text == string.Empty)
            {
                txtnombre.BackColor = Color.Red;
                txtnombre.Focus();
                return false;
            }
            else
                txtnombre.BackColor = Color.White;

            if (txtcuit.Text == string.Empty)
            {
                txtcuit.BackColor = Color.Red;
                txtcuit.Focus();
                return false;
            }
            else
                txtcuit.BackColor = Color.White;

            return true;
        }


        
    }
}
