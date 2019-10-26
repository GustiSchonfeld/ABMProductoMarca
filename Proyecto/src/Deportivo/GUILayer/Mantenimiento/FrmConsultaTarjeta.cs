using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deportivo.Entities;
using Deportivo.BusinessLayer;

namespace Deportivo.GUILayer.Mantenimiento
{
    public partial class frmConsultaTarjeta : Form
    {
        private readonly TipoTarjetaService tipotarjService;
        private readonly TarjetaService tarjService;

        public frmConsultaTarjeta()
        {
            InitializeComponent();
            InitializeDataGridView();
            tarjService = new TarjetaService();
            tipotarjService = new TipoTarjetaService();
            
        }

        private void frmConsultaTarjeta_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboTipoTarjeta, tipotarjService.ObtenerTodos(), "Descripcion", "IdTipo");
        }
    
    private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto. Que datos puede mostrar
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente, -1 indica que no hay nada seleccionado
            cbo.SelectedIndex = -1;
        }

    private void btnConsultar_Click(object sender, EventArgs e)
        {
            //var strSql = "SELECT ta.id,";
            //strSql += " ta.nombre,";
            //strSql += " ta.descripcion,";
            //strSql += " ta.tipotarjeta as tipo,";
            //strSql += " t.descripcion as destipo";
            //strSql += " FROM Tarjetas as ta";
            //strSql += " INNER JOIN TiposTarjeta as t ON  ta.TipoTarjeta = t.id";
            //strSql += " WHERE ta.borrado=0";

            // las condiciones de los filtros se puede pasar a traves de una coleccion de claves y valores (Dictionary)
            // o bien a través de una cadena de condiciones 
            String sqlcondiciones;
            sqlcondiciones = "";
            int cantfiltros = 0;
            // chk para ver si el  check esta activado
            if (!chkTodos.Checked)
            {
                // Validar si el combo 'Perfiles' esta seleccionado.
                if (!string.IsNullOrEmpty(cboTipoTarjeta.Text))
                {
                var tiposeleccionado = cboTipoTarjeta.SelectedValue.ToString();
                sqlcondiciones += " AND (t.id =" + tiposeleccionado + ") ";
                cantfiltros += 1;
                }

                if (!string.IsNullOrEmpty(txtNombreTarjeta.Text))
                {
                var nombre = txtNombreTarjeta.Text;
                sqlcondiciones += " AND ( ta.nombre LIKE "+"'"+"%"+nombre+"%" +"'" +") ";
                cantfiltros += 1;
                }
            //sin usar parametros (concatenando condiciones)
            IList<Tarjeta> listadoTarjetas = tarjService.ConsultarTarjetaConFiltrosCondiciones(sqlcondiciones);

            //Asigno a la grilla la lista de objetos bug
            dgvTarjetas.DataSource = listadoTarjetas;

            if (dgvTarjetas.Rows.Count == 0)
            {   
                if (cantfiltros > 0)
                {   
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }

            }
        }

    private void InitializeDataGridView()
    {
        // Cree un DataGridView no vinculado declarando un recuento de columnas.
        dgvTarjetas.ColumnCount = 4;
        dgvTarjetas.ColumnHeadersVisible = true;

        // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
        dgvTarjetas.AutoGenerateColumns = false;

        // Cambia el estilo de la cabecera de la grilla.
        DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

        columnHeaderStyle.BackColor = Color.Beige;
        columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
        dgvTarjetas.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

        // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
        //Los nombre de DataPropertyName coinciden con los nombres en el select...

        //Name nombre que muestra en la columna
        //DataPropertyName nombre de la propiedad del objeto instanciado

        dgvTarjetas.Columns[0].Name = "ID";
        dgvTarjetas.Columns[0].DataPropertyName = "IdTarjeta";
        // Definimos el ancho de la columna.
        dgvTarjetas.Columns[0].Width = 20;

        dgvTarjetas.Columns[1].Name = "Nombre";
        dgvTarjetas.Columns[1].DataPropertyName = "Nombre";

        dgvTarjetas.Columns[2].Name = "Descripcion";
        dgvTarjetas.Columns[2].DataPropertyName = "Descripcion";

        dgvTarjetas.Columns[3].Name = "Tipo";
        dgvTarjetas.Columns[3].DataPropertyName = "TipoTarjeta";

        // Cambia el tamaño de la altura de los encabezados de columna.
        dgvTarjetas.AutoResizeColumnHeadersHeight();

        // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
        dgvTarjetas.AutoResizeRows(
            DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
    }

    private void chkTodos_CheckedChanged(object sender, EventArgs e)
    {
       
        {
            if (chkTodos.Checked)
            {
                txtNombreTarjeta.Text = "";
                txtNombreTarjeta.Enabled = false;
                cboTipoTarjeta.SelectedIndex = -1;
                cboTipoTarjeta.Enabled = false;
            }
            else
            {
                txtNombreTarjeta.Enabled = true;
                cboTipoTarjeta.Enabled = true;
            }
        }

    }

    
    }

}
