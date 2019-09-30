namespace Deportivo.GUILayer.Mantenimiento
{
    partial class frmConsultaMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_filtros = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnDetalleProd = new System.Windows.Forms.Button();
            this.btnBorrado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnl_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_filtros
            // 
            this.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_filtros.Controls.Add(this.txtNombre);
            this.pnl_filtros.Controls.Add(this.lblMarcas);
            this.pnl_filtros.Controls.Add(this.btnConsultar);
            this.pnl_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_filtros.Location = new System.Drawing.Point(0, 0);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Size = new System.Drawing.Size(852, 142);
            this.pnl_filtros.TabIndex = 1;
            this.pnl_filtros.TabStop = false;
            this.pnl_filtros.Text = "Filtros";
            this.pnl_filtros.Enter += new System.EventHandler(this.pnl_filtros_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(378, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(6, 27);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(48, 13);
            this.lblMarcas.TabIndex = 14;
            this.lblMarcas.Text = "Marcas: ";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(753, 105);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMarcas.Location = new System.Drawing.Point(0, 142);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(852, 265);
            this.dgvMarcas.TabIndex = 6;
            this.dgvMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellClick);
            this.dgvMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcas_CellContentClick);
            // 
            // btnDetalleProd
            // 
            this.btnDetalleProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalleProd.Enabled = false;
            this.btnDetalleProd.Image = global::Deportivo.Properties.Resources.editar;
            this.btnDetalleProd.Location = new System.Drawing.Point(46, 413);
            this.btnDetalleProd.Name = "btnDetalleProd";
            this.btnDetalleProd.Size = new System.Drawing.Size(44, 39);
            this.btnDetalleProd.TabIndex = 32;
            this.btnDetalleProd.UseVisualStyleBackColor = true;
            this.btnDetalleProd.Click += new System.EventHandler(this.btnDetalleMarca_Click_1);
            // 
            // btnBorrado
            // 
            this.btnBorrado.Enabled = false;
            this.btnBorrado.Image = global::Deportivo.Properties.Resources.eliminar;
            this.btnBorrado.Location = new System.Drawing.Point(98, 413);
            this.btnBorrado.Name = "btnBorrado";
            this.btnBorrado.Size = new System.Drawing.Size(40, 40);
            this.btnBorrado.TabIndex = 35;
            this.btnBorrado.UseVisualStyleBackColor = true;
            this.btnBorrado.Click += new System.EventHandler(this.btnBorrado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Deportivo.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(812, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Deportivo.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(0, 413);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 524);
            this.Controls.Add(this.btnBorrado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnDetalleProd);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.pnl_filtros);
            this.Name = "frmConsultaProductos";
            this.Text = "Consultar Marcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        internal System.Windows.Forms.GroupBox pnl_filtros;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.DataGridView dgvMarcas;
        internal System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Button btnDetalleProd;
        internal System.Windows.Forms.Button btnBorrado;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnNuevo;

    }
}