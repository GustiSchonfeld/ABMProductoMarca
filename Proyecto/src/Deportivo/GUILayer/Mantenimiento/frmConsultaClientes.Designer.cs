namespace Deportivo.GUILayer.Mantenimiento
{
    partial class frmConsultaClientes
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
            this.lblClientes = new System.Windows.Forms.Label();
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDetalleCli = new System.Windows.Forms.Button();
            this.btnBorrado = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(12, 22);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(44, 13);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Clientes";
            // 
            // txtClientes
            // 
            this.txtClientes.Location = new System.Drawing.Point(62, 19);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.Size = new System.Drawing.Size(200, 20);
            this.txtClientes.TabIndex = 1;
            this.txtClientes.TextChanged += new System.EventHandler(this.txtClientes_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(175, 56);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Deportivo.Properties.Resources.agregar;
            this.btnNuevo.Location = new System.Drawing.Point(34, 416);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDetalleCli
            // 
            this.btnDetalleCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalleCli.Enabled = false;
            this.btnDetalleCli.Image = global::Deportivo.Properties.Resources.editar;
            this.btnDetalleCli.Location = new System.Drawing.Point(95, 417);
            this.btnDetalleCli.Name = "btnDetalleCli";
            this.btnDetalleCli.Size = new System.Drawing.Size(44, 39);
            this.btnDetalleCli.TabIndex = 35;
            this.btnDetalleCli.UseVisualStyleBackColor = true;
            this.btnDetalleCli.Click += new System.EventHandler(this.btnDetalleCli_Click);
            // 
            // btnBorrado
            // 
            this.btnBorrado.Enabled = false;
            this.btnBorrado.Image = global::Deportivo.Properties.Resources.eliminar;
            this.btnBorrado.Location = new System.Drawing.Point(187, 417);
            this.btnBorrado.Name = "btnBorrado";
            this.btnBorrado.Size = new System.Drawing.Size(40, 40);
            this.btnBorrado.TabIndex = 36;
            this.btnBorrado.UseVisualStyleBackColor = true;
            this.btnBorrado.Click += new System.EventHandler(this.btnBorrado_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(2, 106);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1370, 248);
            this.dgvClientes.TabIndex = 38;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // frmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 469);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBorrado);
            this.Controls.Add(this.btnDetalleCli);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtClientes);
            this.Controls.Add(this.lblClientes);
            this.Name = "frmConsultaClientes";
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.frmConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TextBox txtClientes;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnDetalleCli;
        internal System.Windows.Forms.Button btnBorrado;
        internal System.Windows.Forms.DataGridView dgvClientes;
    }
}