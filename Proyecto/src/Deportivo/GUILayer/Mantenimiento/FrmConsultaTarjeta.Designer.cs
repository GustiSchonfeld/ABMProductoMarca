namespace Deportivo.GUILayer.Mantenimiento
{
    partial class frmConsultaTarjeta
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
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDetalleProd = new System.Windows.Forms.Button();
            this.btnBorrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Location = new System.Drawing.Point(12, 133);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.Size = new System.Drawing.Size(462, 151);
            this.dgvTarjetas.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(387, 104);
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
            this.btnNuevo.Location = new System.Drawing.Point(12, 290);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnDetalleProd
            // 
            this.btnDetalleProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalleProd.Enabled = false;
            this.btnDetalleProd.Image = global::Deportivo.Properties.Resources.editar;
            this.btnDetalleProd.Location = new System.Drawing.Point(58, 290);
            this.btnDetalleProd.Name = "btnDetalleProd";
            this.btnDetalleProd.Size = new System.Drawing.Size(44, 39);
            this.btnDetalleProd.TabIndex = 35;
            this.btnDetalleProd.UseVisualStyleBackColor = true;
           
            // 
            // btnBorrado
            // 
            this.btnBorrado.Enabled = false;
            this.btnBorrado.Image = global::Deportivo.Properties.Resources.eliminar;
            this.btnBorrado.Location = new System.Drawing.Point(108, 289);
            this.btnBorrado.Name = "btnBorrado";
            this.btnBorrado.Size = new System.Drawing.Size(40, 40);
            this.btnBorrado.TabIndex = 36;
            this.btnBorrado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre Tarjeta:";
            // 
            // txtNombreTarjeta
            // 
            this.txtNombreTarjeta.Location = new System.Drawing.Point(103, 18);
            this.txtNombreTarjeta.Name = "txtNombreTarjeta";
            this.txtNombreTarjeta.Size = new System.Drawing.Size(137, 20);
            this.txtNombreTarjeta.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tipo Tarjeta:";
            // 
            // cboTipoTarjeta
            // 
            this.cboTipoTarjeta.FormattingEnabled = true;
            this.cboTipoTarjeta.Location = new System.Drawing.Point(103, 52);
            this.cboTipoTarjeta.Name = "cboTipoTarjeta";
            this.cboTipoTarjeta.Size = new System.Drawing.Size(136, 21);
            this.cboTipoTarjeta.TabIndex = 40;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(103, 90);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 41;
            this.chkTodos.Text = "Todas";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // frmConsultaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 355);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.cboTipoTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrado);
            this.Controls.Add(this.btnDetalleProd);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvTarjetas);
            this.Name = "frmConsultaTarjeta";
            this.Text = "ConsultarTarjeta";
            this.Load += new System.EventHandler(this.frmConsultaTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarjetas;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnDetalleProd;
        internal System.Windows.Forms.Button btnBorrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoTarjeta;
        private System.Windows.Forms.CheckBox chkTodos;
    }
}