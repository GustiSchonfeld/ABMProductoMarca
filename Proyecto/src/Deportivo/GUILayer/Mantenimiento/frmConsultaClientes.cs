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
    public partial class frmConsultaClientes : Form
    {
       private readonly ClienteService clienteService;
       public frmConsultaClientes()
        {
            InitializeComponent();
            // Inicializamos la grilla de clientes
            InitializeDataGridView();
            clienteService = new ClienteService();

        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            btnDetalleCli.Enabled = true;
            btnBorrado.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            // las condiciones de los filtros se puede pasar a traves de una coleccion de claves y valores (Dictionary)
            // o bien a través de una cadena de condiciones 
            String sqlcondiciones;
            sqlcondiciones = "";




            if (!string.IsNullOrEmpty(txtClientes.Text))
            {
                var cajanombre = txtClientes.Text;
                // SELECT * FROM Clientes c WHERE c.apellido LIKE '%DI%'
                sqlcondiciones += " AND ( c.apellido LIKE " + "'" + "%" + cajanombre + "%" + "'" + ") ";

            }



            //sin usar parametros (concatenando condiciones)
            IList<Cliente> listadoClientes = clienteService.ConsultarClientesConFiltrosCondiciones(sqlcondiciones);

            //Asigno a la grilla la lista de objetos bug
            dgvClientes.DataSource = listadoClientes;

            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvClientes.ColumnCount = 4;
            dgvClientes.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvClientes.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);
            dgvClientes.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            //Los nombre de DataPropertyName coinciden con los nombres en el select...

            //Name nombre que muestra en la columna
            //DataPropertyName nombre de la propiedad del objeto instanciado

            dgvClientes.Columns[0].Name = "ID";
            dgvClientes.Columns[0].DataPropertyName = "Id";
            // Definimos el ancho de la columna.
            dgvClientes.Columns[0].Width = 20;

            dgvClientes.Columns[1].Name = "APELLIDO";
            dgvClientes.Columns[1].DataPropertyName = "Apellido";

            dgvClientes.Columns[2].Name = "NOMBRE";
            dgvClientes.Columns[2].DataPropertyName = "Nombre";

            dgvClientes.Columns[3].Name = "Cuit";
            dgvClientes.Columns[3].DataPropertyName = "Cuit";


        }

        private void btnDetalleCli_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                frmABMCliente frmDetalle = new frmABMCliente();
                var selectedItem = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                int seleccionado = (selectedItem.Id);
                frmDetalle.SeleccionarCliente(frmABMCliente.FormMode.update, selectedItem);
                frmDetalle.ShowDialog();

            }
        }

       

        private void txtClientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cuando seleccionamos una fila de la grilla habilitamos el boton btnDetalleBug y el boton de borrado.
            btnDetalleCli.Enabled = true;
            btnBorrado.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMCliente frmDetalle = new frmABMCliente();
            frmDetalle.ShowDialog();
        }

        private void btnBorrado_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                frmABMCliente frmDetalle = new frmABMCliente();
                // DataBoundItem Obtiene el objeto enlazado a datos que llenó la fila.
                // (Cliente), castea a objeto cliente (le da la forma), entonces selected item es una instancia de cliente
                var selectedItem = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                int seleccionado = (selectedItem.Id);
                frmDetalle.SeleccionarCliente(frmABMCliente.FormMode.delete, selectedItem);
                frmDetalle.ShowDialog();

            }
        }

        
        
            

        
    }
}
