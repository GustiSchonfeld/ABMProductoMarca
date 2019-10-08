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
    public partial class frmConsultaMarca : Form
    {
        private readonly MarcaService marcaService;
       
        public frmConsultaMarca()
        {
            InitializeComponent();
            // Inicializamos la grilla de marcas
            InitializeDataGridView();
            marcaService = new MarcaService();

        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            // las condiciones de los filtros se puede pasar a traves de una coleccion de claves y valores (Dictionary)
            // o bien a través de una cadena de condiciones 
            String sqlcondiciones;
            sqlcondiciones = "";

            
            

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                var cajanombre = txtNombre.Text;
                // SELECT * FROM Marcas m WHERE m.descripcion LIKE '%DI%'
                sqlcondiciones += " AND ( m.descripcion LIKE "+"'"+"%"+cajanombre+"%" +"'" +") ";
    
            }



            //sin usar parametros (concatenando condiciones)
            IList<Marca> listadoMarcas = marcaService.ConsultarMarcasConFiltrosCondiciones(sqlcondiciones);

            //Asigno a la grilla la lista de objetos bug
            dgvMarcas.DataSource = listadoMarcas;

            if (dgvMarcas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvMarcas.ColumnCount = 2;
            dgvMarcas.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvMarcas.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);
            dgvMarcas.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            //Los nombre de DataPropertyName coinciden con los nombres en el select...

            //Name nombre que muestra en la columna
            //DataPropertyName nombre de la propiedad del objeto instanciado

            dgvMarcas.Columns[0].Name = "ID Marca";
            dgvMarcas.Columns[0].DataPropertyName = "IdMarca";
            // Definimos el ancho de la columna.
            dgvMarcas.Columns[0].Width = 20;

            dgvMarcas.Columns[1].Name = "Nombre";
            dgvMarcas.Columns[1].DataPropertyName = "Descripcion";

        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cuando seleccionamos una fila de la grilla habilitamos el boton btnDetalleBug y el boton de borrado.
            btnDetalleProd.Enabled = true;
            btnBorrado.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDetalleMarca_Click_1(object sender, EventArgs e)
        {
           if (dgvMarcas.CurrentRow != null)
            {
                frmABMMarca frmDetalle = new frmABMMarca();
                var selectedItem = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                int seleccionado = (selectedItem.IdMarca)   ;
                frmDetalle.SeleccionarMarca(frmABMMarca.FormMode.update, selectedItem);
                frmDetalle.ShowDialog();
                
            }
        }

        private void btnBorrado_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                frmABMMarca frmDetalle = new frmABMMarca();
                var selectedItem = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                int seleccionado = (selectedItem.IdMarca);
                frmDetalle.SeleccionarMarca(frmABMMarca.FormMode.delete, selectedItem);
                frmDetalle.ShowDialog();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMMarca frmDetalle = new frmABMMarca();
            frmDetalle.ShowDialog();
        }

        private void pnl_filtros_Enter(object sender, EventArgs e)
        {

        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
           
    
    }
}
