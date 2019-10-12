namespace Deportivo.GUILayer.Mantenimiento
{
    partial class frmABMCliente
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcuit = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcuit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(12, 39);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(28, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID(*)";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido(*)";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(82, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(47, 20);
            this.txtid.TabIndex = 1;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(81, 67);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(99, 20);
            this.txtapellido.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(51, 197);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(156, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(81, 100);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(98, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtcuit
            // 
            this.txtcuit.Location = new System.Drawing.Point(81, 138);
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(98, 20);
            this.txtcuit.TabIndex = 4;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 103);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(54, 13);
            this.lblnombre.TabIndex = 26;
            this.lblnombre.Text = "Nombre(*)";
            // 
            // lblcuit
            // 
            this.lblcuit.AutoSize = true;
            this.lblcuit.Location = new System.Drawing.Point(16, 141);
            this.lblcuit.Name = "lblcuit";
            this.lblcuit.Size = new System.Drawing.Size(35, 13);
            this.lblcuit.TabIndex = 27;
            this.lblcuit.Text = "Cuit(*)";
            // 
            // frmABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblcuit);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtcuit);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblid);
            this.Name = "frmABMCliente";
            this.Text = "Detalle Cliente";
            this.Load += new System.EventHandler(this.frmABMCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtapellido;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcuit;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcuit;

    }
}