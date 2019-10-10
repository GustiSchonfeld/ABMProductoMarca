using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deportivo.BusinessLayer;

namespace Deportivo.GUILayer.Mantenimiento
{
    public partial class Ejercitacion : Form
    {   // Defino los objetos que voy a usar
        private readonly ProductoService producService;
        private readonly MarcaService marcService;
        private readonly ClienteService cliService;
        public Ejercitacion()
        {

            InitializeComponent();
            // Instancio los objetos service
            producService = new ProductoService();
            marcService = new MarcaService();
            cliService = new ClienteService();
        }

        private void Ejercitacion_Load(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBox.Show("Ejecutando load", "LOAD", buttons);
            LlenarCombo(cboProducto, producService.ObtenerTodos(), "Nombre", "IdProducto");
            LlenarCombo(cboMarcas, marcService.ObtenerTodos(), "Descripcion", "IdMarca");
            LlenarCombo(cboClientes, cliService.ObtenerTodos(), "Apellido", "Id");
        }

        // La funcion llenar combo recibe 4 parametros
        // El primero es de tipo ComboBox , la variable cbo recibe cboProducto
        // Segundo es de tipo Object, la variable source recibe una lista de objetos de tipo producto
        // Tercero es de tipo string, y es la propiedad del objeto producto que se quiere mostrar(no es texto)
        // Cuarto es de tipo String, y value recibe "la propiedad del objeto que se usa como indice"(es texto)
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


        private void Ejercitacion_FormClosing(object sender, FormClosingEventArgs e)
        {   // Indico el tipo de la variable rpta
            DialogResult rpta;
            // Asigno a rpta el resultado del message box; valores posibles, si y no
            // Componentes msjbox, mensaje, titulo, botones, icono
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var seleccionado = cboClientes.SelectedValue.ToString();
           MessageBox.Show(seleccionado, "Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        

       
    }
}
