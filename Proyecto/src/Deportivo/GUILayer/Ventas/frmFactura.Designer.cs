﻿namespace Deportivo.GUILayer
{
    partial class frmFactura
    {
        //cambio para que se suba en el repositorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTipoFact = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipoFact = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dpbDetalle = new System.Windows.Forms.GroupBox();
            this.cboForma = new System.Windows.Forms.ComboBox();
            this.cboTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.cboTarjeta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this._txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this._txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this._btnQuitar = new System.Windows.Forms.Button();
            this._btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.NroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this._lblCantidad = new System.Windows.Forms.Label();
            this._lblArticulo = new System.Windows.Forms.Label();
            this._cboArticulo = new System.Windows.Forms.ComboBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.MaskedTextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dpbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoFact
            // 
            this.lblTipoFact.AutoSize = true;
            this.lblTipoFact.Location = new System.Drawing.Point(1, 30);
            this.lblTipoFact.Name = "lblTipoFact";
            this.lblTipoFact.Size = new System.Drawing.Size(77, 13);
            this.lblTipoFact.TabIndex = 0;
            this.lblTipoFact.Text = "Tipo Factura(*)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(255, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(29, 53);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente(*)";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(298, 24);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2019, 9, 29, 17, 20, 8, 0);
            // 
            // cboTipoFact
            // 
            this.cboTipoFact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFact.FormattingEnabled = true;
            this.cboTipoFact.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboTipoFact.Location = new System.Drawing.Point(84, 23);
            this.cboTipoFact.Name = "cboTipoFact";
            this.cboTipoFact.Size = new System.Drawing.Size(143, 21);
            this.cboTipoFact.TabIndex = 0;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(84, 53);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(143, 21);
            this.cboCliente.TabIndex = 2;
            // 
            // dpbDetalle
            // 
            this.dpbDetalle.Controls.Add(this.txtCodigo);
            this.dpbDetalle.Controls.Add(this.label5);
            this.dpbDetalle.Controls.Add(this.label4);
            this.dpbDetalle.Controls.Add(this.txtNumero);
            this.dpbDetalle.Controls.Add(this.label3);
            this.dpbDetalle.Controls.Add(this.cboForma);
            this.dpbDetalle.Controls.Add(this.cboTipoTarjeta);
            this.dpbDetalle.Controls.Add(this.cboTarjeta);
            this.dpbDetalle.Controls.Add(this.label2);
            this.dpbDetalle.Controls.Add(this.label1);
            this.dpbDetalle.Controls.Add(this.txtImporteTotal);
            this.dpbDetalle.Controls.Add(this.txtDescuento);
            this.dpbDetalle.Controls.Add(this.txtSubtotal);
            this.dpbDetalle.Controls.Add(this.lblImporteTotal);
            this.dpbDetalle.Controls.Add(this.lblDescuento);
            this.dpbDetalle.Controls.Add(this.lblSubtotal);
            this.dpbDetalle.Controls.Add(this._txtCantidad);
            this.dpbDetalle.Controls.Add(this._txtImporte);
            this.dpbDetalle.Controls.Add(this.lblImporte);
            this.dpbDetalle.Controls.Add(this._btnQuitar);
            this.dpbDetalle.Controls.Add(this._btnAgregar);
            this.dpbDetalle.Controls.Add(this.dgvDetalle);
            this.dpbDetalle.Controls.Add(this._txtPrecio);
            this.dpbDetalle.Controls.Add(this.lblPrecio);
            this.dpbDetalle.Controls.Add(this._lblCantidad);
            this.dpbDetalle.Controls.Add(this._lblArticulo);
            this.dpbDetalle.Controls.Add(this._cboArticulo);
            this.dpbDetalle.Location = new System.Drawing.Point(12, 77);
            this.dpbDetalle.Name = "dpbDetalle";
            this.dpbDetalle.Size = new System.Drawing.Size(777, 504);
            this.dpbDetalle.TabIndex = 7;
            this.dpbDetalle.TabStop = false;
            this.dpbDetalle.Text = "Detalle";
            // 
            // cboForma
            // 
            this.cboForma.FormattingEnabled = true;
            this.cboForma.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cboForma.Location = new System.Drawing.Point(87, 322);
            this.cboForma.Name = "cboForma";
            this.cboForma.Size = new System.Drawing.Size(127, 21);
            this.cboForma.TabIndex = 35;
            // 
            // cboTipoTarjeta
            // 
            this.cboTipoTarjeta.FormattingEnabled = true;
            this.cboTipoTarjeta.Location = new System.Drawing.Point(87, 353);
            this.cboTipoTarjeta.Name = "cboTipoTarjeta";
            this.cboTipoTarjeta.Size = new System.Drawing.Size(126, 21);
            this.cboTipoTarjeta.TabIndex = 34;
            // 
            // cboTarjeta
            // 
            this.cboTarjeta.FormattingEnabled = true;
            this.cboTarjeta.Location = new System.Drawing.Point(87, 386);
            this.cboTarjeta.Name = "cboTarjeta";
            this.cboTarjeta.Size = new System.Drawing.Size(127, 21);
            this.cboTarjeta.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tarjeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Forma de Pago";
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Enabled = false;
            this.txtImporteTotal.Location = new System.Drawing.Point(667, 379);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(100, 20);
            this.txtImporteTotal.TabIndex = 27;
            this.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(667, 353);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 26;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.Leave += new System.EventHandler(this.TxtDescuento_Leave);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(667, 327);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 25;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(580, 382);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(81, 13);
            this.lblImporteTotal.TabIndex = 30;
            this.lblImporteTotal.Text = "Importe Total: $";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(590, 356);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(71, 13);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento: $";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(603, 330);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(58, 13);
            this.lblSubtotal.TabIndex = 28;
            this.lblSubtotal.Text = "Subtotal: $";
            // 
            // _txtCantidad
            // 
            this._txtCantidad.Location = new System.Drawing.Point(267, 29);
            this._txtCantidad.Mask = "99999";
            this._txtCantidad.Name = "_txtCantidad";
            this._txtCantidad.Size = new System.Drawing.Size(41, 20);
            this._txtCantidad.TabIndex = 1;
            this._txtCantidad.ValidatingType = typeof(int);
            this._txtCantidad.Leave += new System.EventHandler(this._txtCantidad_Leave);
            // 
            // _txtImporte
            // 
            this._txtImporte.Location = new System.Drawing.Point(518, 30);
            this._txtImporte.Name = "_txtImporte";
            this._txtImporte.ReadOnly = true;
            this._txtImporte.Size = new System.Drawing.Size(68, 20);
            this._txtImporte.TabIndex = 3;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(467, 33);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(54, 13);
            this.lblImporte.TabIndex = 8;
            this.lblImporte.Text = "Importe: $";
            // 
            // _btnQuitar
            // 
            this._btnQuitar.Image = global::Deportivo.Properties.Resources.eliminar;
            this._btnQuitar.Location = new System.Drawing.Point(729, 20);
            this._btnQuitar.Name = "_btnQuitar";
            this._btnQuitar.Size = new System.Drawing.Size(38, 36);
            this._btnQuitar.TabIndex = 6;
            this._btnQuitar.UseVisualStyleBackColor = true;
            this._btnQuitar.Click += new System.EventHandler(this._btnQuitar_Click);
            // 
            // _btnAgregar
            // 
            this._btnAgregar.Image = global::Deportivo.Properties.Resources.agregar;
            this._btnAgregar.Location = new System.Drawing.Point(687, 21);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(36, 36);
            this._btnAgregar.TabIndex = 5;
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroItem,
            this.CodArt,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Importe});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalle.Location = new System.Drawing.Point(13, 61);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(754, 252);
            this.dgvDetalle.TabIndex = 7;
            // 
            // NroItem
            // 
            this.NroItem.DataPropertyName = "NroItem";
            this.NroItem.HeaderText = "Nro. Ítem";
            this.NroItem.Name = "NroItem";
            this.NroItem.ReadOnly = true;
            this.NroItem.Width = 70;
            // 
            // CodArt
            // 
            this.CodArt.DataPropertyName = "IdProducto";
            this.CodArt.HeaderText = "Cod. Art.";
            this.CodArt.Name = "CodArt";
            this.CodArt.ReadOnly = true;
            this.CodArt.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "ProductoDescripcion";
            dataGridViewCellStyle8.NullValue = null;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle8;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle9.Format = "C2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle9;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            dataGridViewCellStyle10.Format = "C2";
            this.Importe.DefaultCellStyle = dataGridViewCellStyle10;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 150;
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Location = new System.Drawing.Point(382, 30);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.ReadOnly = true;
            this._txtPrecio.Size = new System.Drawing.Size(68, 20);
            this._txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(336, 33);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio: $";
            // 
            // _lblCantidad
            // 
            this._lblCantidad.AutoSize = true;
            this._lblCantidad.Location = new System.Drawing.Point(212, 33);
            this._lblCantidad.Name = "_lblCantidad";
            this._lblCantidad.Size = new System.Drawing.Size(49, 13);
            this._lblCantidad.TabIndex = 2;
            this._lblCantidad.Text = "Cantidad";
            // 
            // _lblArticulo
            // 
            this._lblArticulo.AutoSize = true;
            this._lblArticulo.Location = new System.Drawing.Point(8, 32);
            this._lblArticulo.Name = "_lblArticulo";
            this._lblArticulo.Size = new System.Drawing.Size(44, 13);
            this._lblArticulo.TabIndex = 1;
            this._lblArticulo.Text = "Artículo";
            // 
            // _cboArticulo
            // 
            this._cboArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboArticulo.FormattingEnabled = true;
            this._cboArticulo.Location = new System.Drawing.Point(58, 28);
            this._cboArticulo.Name = "_cboArticulo";
            this._cboArticulo.Size = new System.Drawing.Size(133, 21);
            this._cboArticulo.TabIndex = 0;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(260, 56);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 15;
            this.lblCUIT.Text = "CUIT";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Enabled = false;
            this.txtCUIT.Location = new System.Drawing.Point(298, 56);
            this.txtCUIT.Mask = "00-00000000-0";
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(100, 20);
            this.txtCUIT.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 587);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 36);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Deportivo.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(704, 587);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::Deportivo.Properties.Resources.cerrarBug;
            this.btnGrabar.Location = new System.Drawing.Point(99, 587);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 35);
            this.btnGrabar.TabIndex = 14;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tipo Tarjeta";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(87, 422);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(126, 20);
            this.txtNumero.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nro Tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 457);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 20);
            this.txtCodigo.TabIndex = 40;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 635);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.dpbDetalle);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.cboTipoFact);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTipoFact);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.dpbDetalle.ResumeLayout(false);
            this.dpbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoFact;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipoFact;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.GroupBox dpbDetalle;
        private System.Windows.Forms.Button _btnQuitar;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label _lblCantidad;
        private System.Windows.Forms.Label _lblArticulo;
        private System.Windows.Forms.ComboBox _cboArticulo;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.MaskedTextBox txtCUIT;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox _txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.MaskedTextBox _txtCantidad;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.ComboBox cboTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoTarjeta;
        private System.Windows.Forms.ComboBox cboForma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
    }
}