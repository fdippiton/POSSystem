namespace POSSystem
{
    partial class FormProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.boxBuscar = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtFiltrar = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.txtListaUsuarios = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtDetalleProducto = new System.Windows.Forms.Label();
            this.btnInactivar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtItbis = new System.Windows.Forms.Label();
            this.boxDescripcion = new System.Windows.Forms.TextBox();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCantidadInicial = new System.Windows.Forms.TextBox();
            this.txtCantidadInicial = new System.Windows.Forms.Label();
            this.boxPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.Label();
            this.boxPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Prod_CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Categoria_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_StockInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_ValorInventarioInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_ValorInventarioActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(31, 168);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(237, 21);
            this.cboCategoria.TabIndex = 80;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoSize = true;
            this.txtBuscar.Location = new System.Drawing.Point(833, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(61, 13);
            this.txtBuscar.TabIndex = 79;
            this.txtBuscar.Text = "Buscar por:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(1106, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(36, 30);
            this.btnLimpiar.TabIndex = 78;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(1064, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 30);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // boxBuscar
            // 
            this.boxBuscar.Location = new System.Drawing.Point(893, 24);
            this.boxBuscar.Name = "boxBuscar";
            this.boxBuscar.Size = new System.Drawing.Size(156, 20);
            this.boxBuscar.TabIndex = 76;
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(654, 24);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(156, 21);
            this.cboBuscar.TabIndex = 75;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.AutoSize = true;
            this.txtFiltrar.Location = new System.Drawing.Point(619, 28);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(35, 13);
            this.txtFiltrar.TabIndex = 74;
            this.txtFiltrar.Text = "Filtrar:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(133, 40);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(135, 20);
            this.textId.TabIndex = 73;
            this.textId.Text = "0";
            // 
            // txtListaUsuarios
            // 
            this.txtListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtListaUsuarios.Location = new System.Drawing.Point(303, 22);
            this.txtListaUsuarios.Name = "txtListaUsuarios";
            this.txtListaUsuarios.Size = new System.Drawing.Size(212, 25);
            this.txtListaUsuarios.TabIndex = 72;
            this.txtListaUsuarios.Text = "Lista de Productos";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Prod_CodigoBarras,
            this.Prod_Barras,
            this.Prod_Nombre,
            this.Prod_Categoria_Id,
            this.Prod_Categoria,
            this.Prod_Descripcion,
            this.Prod_StockInicial,
            this.Prod_StockActual,
            this.Prod_PrecioCompra,
            this.Prod_PrecioVenta,
            this.Prod_ValorInventarioInicial,
            this.Prod_ValorInventarioActual,
            this.Prod_Fecha});
            this.dgvdata.Location = new System.Drawing.Point(292, 51);
            this.dgvdata.MinimumSize = new System.Drawing.Size(0, 28);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.Size = new System.Drawing.Size(889, 460);
            this.dgvdata.TabIndex = 71;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // txtDetalleProducto
            // 
            this.txtDetalleProducto.AutoSize = true;
            this.txtDetalleProducto.BackColor = System.Drawing.Color.White;
            this.txtDetalleProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtDetalleProducto.Location = new System.Drawing.Point(27, 9);
            this.txtDetalleProducto.Name = "txtDetalleProducto";
            this.txtDetalleProducto.Size = new System.Drawing.Size(160, 22);
            this.txtDetalleProducto.TabIndex = 70;
            this.txtDetalleProducto.Text = "Registrar Producto";
            // 
            // btnInactivar
            // 
            this.btnInactivar.BackColor = System.Drawing.Color.Crimson;
            this.btnInactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactivar.ForeColor = System.Drawing.Color.White;
            this.btnInactivar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnInactivar.IconColor = System.Drawing.Color.White;
            this.btnInactivar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInactivar.IconSize = 16;
            this.btnInactivar.Location = new System.Drawing.Point(193, 350);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 30);
            this.btnInactivar.TabIndex = 69;
            this.btnInactivar.Text = "Eliminar";
            this.btnInactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInactivar.UseVisualStyleBackColor = false;
            this.btnInactivar.Click += new System.EventHandler(this.btnInactivar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 16;
            this.btnEditar.Location = new System.Drawing.Point(112, 350);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 30);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(31, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 67;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtItbis
            // 
            this.txtItbis.AutoSize = true;
            this.txtItbis.BackColor = System.Drawing.Color.White;
            this.txtItbis.Location = new System.Drawing.Point(28, 203);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new System.Drawing.Size(0, 13);
            this.txtItbis.TabIndex = 65;
            // 
            // boxDescripcion
            // 
            this.boxDescripcion.Location = new System.Drawing.Point(31, 117);
            this.boxDescripcion.Name = "boxDescripcion";
            this.boxDescripcion.Size = new System.Drawing.Size(237, 20);
            this.boxDescripcion.TabIndex = 64;
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(31, 66);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(237, 20);
            this.boxNombre.TabIndex = 63;
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoSize = true;
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.Location = new System.Drawing.Point(28, 152);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(52, 13);
            this.txtCategoria.TabIndex = 62;
            this.txtCategoria.Text = "Categoria";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(28, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(63, 13);
            this.txtDescripcion.TabIndex = 61;
            this.txtDescripcion.Text = "Descripcion";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(28, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 60;
            this.txtNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 514);
            this.label2.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 58;
            // 
            // boxCantidadInicial
            // 
            this.boxCantidadInicial.Location = new System.Drawing.Point(31, 217);
            this.boxCantidadInicial.Name = "boxCantidadInicial";
            this.boxCantidadInicial.Size = new System.Drawing.Size(237, 20);
            this.boxCantidadInicial.TabIndex = 82;
            // 
            // txtCantidadInicial
            // 
            this.txtCantidadInicial.AutoSize = true;
            this.txtCantidadInicial.BackColor = System.Drawing.Color.White;
            this.txtCantidadInicial.Location = new System.Drawing.Point(28, 201);
            this.txtCantidadInicial.Name = "txtCantidadInicial";
            this.txtCantidadInicial.Size = new System.Drawing.Size(49, 13);
            this.txtCantidadInicial.TabIndex = 81;
            this.txtCantidadInicial.Text = "Cantidad";
            // 
            // boxPrecioCompra
            // 
            this.boxPrecioCompra.Location = new System.Drawing.Point(31, 264);
            this.boxPrecioCompra.Name = "boxPrecioCompra";
            this.boxPrecioCompra.Size = new System.Drawing.Size(237, 20);
            this.boxPrecioCompra.TabIndex = 84;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.AutoSize = true;
            this.txtPrecioCompra.BackColor = System.Drawing.Color.White;
            this.txtPrecioCompra.Location = new System.Drawing.Point(28, 248);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(136, 13);
            this.txtPrecioCompra.TabIndex = 83;
            this.txtPrecioCompra.Text = "Precio de Compra x Unidad";
            // 
            // boxPrecioVenta
            // 
            this.boxPrecioVenta.Location = new System.Drawing.Point(31, 312);
            this.boxPrecioVenta.Name = "boxPrecioVenta";
            this.boxPrecioVenta.Size = new System.Drawing.Size(237, 20);
            this.boxPrecioVenta.TabIndex = 86;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.AutoSize = true;
            this.txtPrecioVenta.BackColor = System.Drawing.Color.White;
            this.txtPrecioVenta.Location = new System.Drawing.Point(28, 296);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(128, 13);
            this.txtPrecioVenta.TabIndex = 85;
            this.txtPrecioVenta.Text = "Precio de Venta x Unidad";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 25;
            // 
            // Prod_CodigoBarras
            // 
            this.Prod_CodigoBarras.HeaderText = "Codigo de Barras";
            this.Prod_CodigoBarras.Name = "Prod_CodigoBarras";
            this.Prod_CodigoBarras.ReadOnly = true;
            // 
            // Prod_Barras
            // 
            this.Prod_Barras.HeaderText = "Barras";
            this.Prod_Barras.Name = "Prod_Barras";
            this.Prod_Barras.ReadOnly = true;
            this.Prod_Barras.Width = 180;
            // 
            // Prod_Nombre
            // 
            this.Prod_Nombre.HeaderText = "Nombre Producto";
            this.Prod_Nombre.Name = "Prod_Nombre";
            this.Prod_Nombre.ReadOnly = true;
            this.Prod_Nombre.Width = 150;
            // 
            // Prod_Categoria_Id
            // 
            this.Prod_Categoria_Id.HeaderText = "Categoria Id";
            this.Prod_Categoria_Id.Name = "Prod_Categoria_Id";
            this.Prod_Categoria_Id.ReadOnly = true;
            this.Prod_Categoria_Id.Visible = false;
            // 
            // Prod_Categoria
            // 
            this.Prod_Categoria.HeaderText = "Categoria";
            this.Prod_Categoria.Name = "Prod_Categoria";
            this.Prod_Categoria.ReadOnly = true;
            // 
            // Prod_Descripcion
            // 
            this.Prod_Descripcion.HeaderText = "Descripcion";
            this.Prod_Descripcion.Name = "Prod_Descripcion";
            this.Prod_Descripcion.ReadOnly = true;
            this.Prod_Descripcion.Width = 150;
            // 
            // Prod_StockInicial
            // 
            this.Prod_StockInicial.HeaderText = "Stock Inicial";
            this.Prod_StockInicial.Name = "Prod_StockInicial";
            this.Prod_StockInicial.ReadOnly = true;
            // 
            // Prod_StockActual
            // 
            this.Prod_StockActual.HeaderText = "Stock Actual";
            this.Prod_StockActual.Name = "Prod_StockActual";
            this.Prod_StockActual.ReadOnly = true;
            // 
            // Prod_PrecioCompra
            // 
            this.Prod_PrecioCompra.HeaderText = "Precio de Compra";
            this.Prod_PrecioCompra.Name = "Prod_PrecioCompra";
            this.Prod_PrecioCompra.ReadOnly = true;
            // 
            // Prod_PrecioVenta
            // 
            this.Prod_PrecioVenta.HeaderText = "Precio de Venta";
            this.Prod_PrecioVenta.Name = "Prod_PrecioVenta";
            this.Prod_PrecioVenta.ReadOnly = true;
            // 
            // Prod_ValorInventarioInicial
            // 
            this.Prod_ValorInventarioInicial.HeaderText = "Valor de Inventario Inicial";
            this.Prod_ValorInventarioInicial.Name = "Prod_ValorInventarioInicial";
            this.Prod_ValorInventarioInicial.ReadOnly = true;
            // 
            // Prod_ValorInventarioActual
            // 
            this.Prod_ValorInventarioActual.HeaderText = "Valor de Inventario Actual";
            this.Prod_ValorInventarioActual.Name = "Prod_ValorInventarioActual";
            this.Prod_ValorInventarioActual.ReadOnly = true;
            // 
            // Prod_Fecha
            // 
            this.Prod_Fecha.HeaderText = "Fecha de Creación";
            this.Prod_Fecha.Name = "Prod_Fecha";
            this.Prod_Fecha.ReadOnly = true;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 514);
            this.Controls.Add(this.boxPrecioVenta);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.boxPrecioCompra);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.boxCantidadInicial);
            this.Controls.Add(this.txtCantidadInicial);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.boxBuscar);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.txtListaUsuarios);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txtDetalleProducto);
            this.Controls.Add(this.btnInactivar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtItbis);
            this.Controls.Add(this.boxDescripcion);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label txtBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox boxBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label txtFiltrar;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label txtListaUsuarios;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label txtDetalleProducto;
        private FontAwesome.Sharp.IconButton btnInactivar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label txtItbis;
        private System.Windows.Forms.TextBox boxDescripcion;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.Label txtCategoria;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxCantidadInicial;
        private System.Windows.Forms.Label txtCantidadInicial;
        private System.Windows.Forms.TextBox boxPrecioCompra;
        private System.Windows.Forms.Label txtPrecioCompra;
        private System.Windows.Forms.TextBox boxPrecioVenta;
        private System.Windows.Forms.Label txtPrecioVenta;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Categoria_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_StockInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_StockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_ValorInventarioInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_ValorInventarioActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Fecha;
    }
}