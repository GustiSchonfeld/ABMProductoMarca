﻿namespace Deportivo.GUILayer.Usuarios

{
    partial class frmABMProducto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblD = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(164, 196);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 23);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(108, 21);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(31, 13);
            this.lblD.TabIndex = 17;
            this.lblD.Text = "ID(*):";
            this.lblD.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(168, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 20);
            this.txtID.TabIndex = 15;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(108, 52);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(50, 13);
            this.lblmarca.TabIndex = 27;
            this.lblmarca.Text = "Marca(*):";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(171, 108);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(194, 20);
            this.txtCantidad.TabIndex = 29;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(169, 47);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(196, 21);
            this.cboMarca.TabIndex = 32;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(108, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre(*):";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(109, 112);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 13);
            this.lblCantidad.TabIndex = 35;
            this.lblCantidad.Text = "Cantidad(*):";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(109, 141);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 13);
            this.lblPrecio.TabIndex = 36;
            this.lblPrecio.Text = "Precio(*):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha (*):";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(171, 79);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(194, 20);
            this.txtNombres.TabIndex = 38;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(171, 134);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(194, 20);
            this.txtPrecio.TabIndex = 39;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(171, 164);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(194, 20);
            this.dtpFecha.TabIndex = 40;
            // 
            // frmABMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 231);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmABMProducto";
            this.Text = "Detalle de Producto";
            this.Load += new System.EventHandler(this.frmABMProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.Label lblD;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label lblmarca;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.TextBox txtCantidad;
        internal System.Windows.Forms.TextBox txtPrecioVenta;
        internal System.Windows.Forms.ComboBox cboMarca;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.Label lblCantidad;
        internal System.Windows.Forms.Label lblPrecio;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtNombres;
        internal System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}