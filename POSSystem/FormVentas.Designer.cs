namespace POSSystem
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfoCliente = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtRegistrarVenta = new System.Windows.Forms.Label();
            this.txtInfoVenta = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.boxPrecio = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.Label();
            this.boxProducto = new System.Windows.Forms.TextBox();
            this.txtCodProducto = new System.Windows.Forms.Label();
            this.boxCodProducto = new System.Windows.Forms.TextBox();
            this.txtStockActual = new System.Windows.Forms.Label();
            this.boxStockActual = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.boxCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtItbis = new System.Windows.Forms.Label();
            this.cboItbis = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.Label();
            this.txtTotalItbis = new System.Windows.Forms.Label();
            this.boxTotalItbis = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.Label();
            this.boxTotalPagar = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.Label();
            this.boxCambio = new System.Windows.Forms.TextBox();
            this.txtPagarCon = new System.Windows.Forms.Label();
            this.boxPagarCon = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCodProducto = new FontAwesome.Sharp.IconButton();
            this.btnGenerarVenta = new FontAwesome.Sharp.IconButton();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.btnTotalizar = new FontAwesome.Sharp.IconButton();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Prod_CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // txtInfoCliente
            // 
            this.txtInfoCliente.AutoSize = true;
            this.txtInfoCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtInfoCliente.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoCliente.Location = new System.Drawing.Point(254, 51);
            this.txtInfoCliente.Name = "txtInfoCliente";
            this.txtInfoCliente.Size = new System.Drawing.Size(140, 16);
            this.txtInfoCliente.TabIndex = 105;
            this.txtInfoCliente.Text = "Información Cliente";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.BackColor = System.Drawing.Color.Transparent;
            this.txtFecha.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(32, 71);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(49, 16);
            this.txtFecha.TabIndex = 103;
            this.txtFecha.Text = "Fecha:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEliminar,
            this.Prod_CodigoBarras,
            this.Prod_Nombre,
            this.Prod_Cantidad,
            this.Prod_PrecioVenta,
            this.Prod_Subtotal,
            this.Prod_Itbis,
            this.Prod_Total});
            this.dgvdata.Location = new System.Drawing.Point(34, 192);
            this.dgvdata.MinimumSize = new System.Drawing.Size(0, 28);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.Size = new System.Drawing.Size(825, 278);
            this.dgvdata.TabIndex = 99;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // txtRegistrarVenta
            // 
            this.txtRegistrarVenta.AutoSize = true;
            this.txtRegistrarVenta.BackColor = System.Drawing.Color.Transparent;
            this.txtRegistrarVenta.Font = new System.Drawing.Font("Roboto Mono", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtRegistrarVenta.Location = new System.Drawing.Point(30, 16);
            this.txtRegistrarVenta.Name = "txtRegistrarVenta";
            this.txtRegistrarVenta.Size = new System.Drawing.Size(160, 23);
            this.txtRegistrarVenta.TabIndex = 98;
            this.txtRegistrarVenta.Text = "Registrar Venta";
            // 
            // txtInfoVenta
            // 
            this.txtInfoVenta.AutoSize = true;
            this.txtInfoVenta.BackColor = System.Drawing.Color.Transparent;
            this.txtInfoVenta.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoVenta.Location = new System.Drawing.Point(32, 51);
            this.txtInfoVenta.Name = "txtInfoVenta";
            this.txtInfoVenta.Size = new System.Drawing.Size(126, 16);
            this.txtInfoVenta.TabIndex = 91;
            this.txtInfoVenta.Text = "Información Venta";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.AutoSize = true;
            this.txtNombreCompleto.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(254, 71);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(112, 16);
            this.txtNombreCompleto.TabIndex = 110;
            this.txtNombreCompleto.Text = "Nombre Completo";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.BackColor = System.Drawing.Color.Transparent;
            this.txtPrecio.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(445, 118);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(49, 16);
            this.txtPrecio.TabIndex = 112;
            this.txtPrecio.Text = "Precio";
            // 
            // boxPrecio
            // 
            this.boxPrecio.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPrecio.Location = new System.Drawing.Point(448, 134);
            this.boxPrecio.Name = "boxPrecio";
            this.boxPrecio.Size = new System.Drawing.Size(111, 23);
            this.boxPrecio.TabIndex = 111;
            // 
            // txtProducto
            // 
            this.txtProducto.AutoSize = true;
            this.txtProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtProducto.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(230, 118);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(63, 16);
            this.txtProducto.TabIndex = 114;
            this.txtProducto.Text = "Producto";
            // 
            // boxProducto
            // 
            this.boxProducto.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxProducto.Location = new System.Drawing.Point(230, 134);
            this.boxProducto.Name = "boxProducto";
            this.boxProducto.Size = new System.Drawing.Size(194, 23);
            this.boxProducto.TabIndex = 113;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.AutoSize = true;
            this.txtCodProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtCodProducto.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(32, 118);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(98, 16);
            this.txtCodProducto.TabIndex = 116;
            this.txtCodProducto.Text = "Cod. Producto";
            // 
            // boxCodProducto
            // 
            this.boxCodProducto.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCodProducto.Location = new System.Drawing.Point(32, 134);
            this.boxCodProducto.Name = "boxCodProducto";
            this.boxCodProducto.Size = new System.Drawing.Size(143, 23);
            this.boxCodProducto.TabIndex = 115;
            // 
            // txtStockActual
            // 
            this.txtStockActual.AutoSize = true;
            this.txtStockActual.BackColor = System.Drawing.Color.Transparent;
            this.txtStockActual.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockActual.Location = new System.Drawing.Point(573, 118);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(91, 16);
            this.txtStockActual.TabIndex = 119;
            this.txtStockActual.Text = "Stock Actual";
            // 
            // boxStockActual
            // 
            this.boxStockActual.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStockActual.Location = new System.Drawing.Point(576, 134);
            this.boxStockActual.Name = "boxStockActual";
            this.boxStockActual.Size = new System.Drawing.Size(106, 23);
            this.boxStockActual.TabIndex = 118;
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.BackColor = System.Drawing.Color.Transparent;
            this.txtCantidad.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(693, 118);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(63, 16);
            this.txtCantidad.TabIndex = 121;
            this.txtCantidad.Text = "Cantidad";
            // 
            // boxCantidad
            // 
            this.boxCantidad.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCantidad.Location = new System.Drawing.Point(696, 134);
            this.boxCantidad.Name = "boxCantidad";
            this.boxCantidad.Size = new System.Drawing.Size(60, 23);
            this.boxCantidad.TabIndex = 122;
            // 
            // txtItbis
            // 
            this.txtItbis.AutoSize = true;
            this.txtItbis.BackColor = System.Drawing.Color.Transparent;
            this.txtItbis.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItbis.Location = new System.Drawing.Point(764, 118);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new System.Drawing.Size(42, 16);
            this.txtItbis.TabIndex = 124;
            this.txtItbis.Text = "ITBIS";
            // 
            // cboItbis
            // 
            this.cboItbis.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItbis.FormattingEnabled = true;
            this.cboItbis.Location = new System.Drawing.Point(767, 133);
            this.cboItbis.Name = "cboItbis";
            this.cboItbis.Size = new System.Drawing.Size(129, 24);
            this.cboItbis.TabIndex = 125;
            // 
            // txtDetalle
            // 
            this.txtDetalle.AutoSize = true;
            this.txtDetalle.BackColor = System.Drawing.Color.Transparent;
            this.txtDetalle.Font = new System.Drawing.Font("Roboto Mono", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtDetalle.Location = new System.Drawing.Point(31, 167);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(80, 23);
            this.txtDetalle.TabIndex = 126;
            this.txtDetalle.Text = "Detalle";
            // 
            // txtTotalItbis
            // 
            this.txtTotalItbis.AutoSize = true;
            this.txtTotalItbis.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalItbis.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItbis.Location = new System.Drawing.Point(905, 162);
            this.txtTotalItbis.Name = "txtTotalItbis";
            this.txtTotalItbis.Size = new System.Drawing.Size(91, 16);
            this.txtTotalItbis.TabIndex = 128;
            this.txtTotalItbis.Text = "Total Itbis:";
            // 
            // boxTotalItbis
            // 
            this.boxTotalItbis.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTotalItbis.Location = new System.Drawing.Point(905, 183);
            this.boxTotalItbis.Name = "boxTotalItbis";
            this.boxTotalItbis.Size = new System.Drawing.Size(238, 23);
            this.boxTotalItbis.TabIndex = 127;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.AutoSize = true;
            this.txtTotalPagar.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPagar.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(905, 211);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(105, 16);
            this.txtTotalPagar.TabIndex = 130;
            this.txtTotalPagar.Text = "Total a Pagar:";
            // 
            // boxTotalPagar
            // 
            this.boxTotalPagar.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTotalPagar.Location = new System.Drawing.Point(905, 232);
            this.boxTotalPagar.Name = "boxTotalPagar";
            this.boxTotalPagar.Size = new System.Drawing.Size(244, 23);
            this.boxTotalPagar.TabIndex = 129;
            // 
            // txtCambio
            // 
            this.txtCambio.AutoSize = true;
            this.txtCambio.BackColor = System.Drawing.Color.Transparent;
            this.txtCambio.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(905, 360);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(56, 16);
            this.txtCambio.TabIndex = 134;
            this.txtCambio.Text = "Cambio:";
            // 
            // boxCambio
            // 
            this.boxCambio.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCambio.Location = new System.Drawing.Point(905, 381);
            this.boxCambio.Name = "boxCambio";
            this.boxCambio.Size = new System.Drawing.Size(244, 23);
            this.boxCambio.TabIndex = 133;
            // 
            // txtPagarCon
            // 
            this.txtPagarCon.AutoSize = true;
            this.txtPagarCon.BackColor = System.Drawing.Color.Transparent;
            this.txtPagarCon.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagarCon.Location = new System.Drawing.Point(905, 260);
            this.txtPagarCon.Name = "txtPagarCon";
            this.txtPagarCon.Size = new System.Drawing.Size(77, 16);
            this.txtPagarCon.TabIndex = 132;
            this.txtPagarCon.Text = "Pagar con:";
            // 
            // boxPagarCon
            // 
            this.boxPagarCon.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPagarCon.Location = new System.Drawing.Point(905, 281);
            this.boxPagarCon.Name = "boxPagarCon";
            this.boxPagarCon.Size = new System.Drawing.Size(244, 23);
            this.boxPagarCon.TabIndex = 131;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(32, 90);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 137;
            // 
            // btnBuscarCodProducto
            // 
            this.btnBuscarCodProducto.BackColor = System.Drawing.Color.Silver;
            this.btnBuscarCodProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCodProducto.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCodProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarCodProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarCodProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCodProducto.IconSize = 16;
            this.btnBuscarCodProducto.Location = new System.Drawing.Point(184, 131);
            this.btnBuscarCodProducto.Name = "btnBuscarCodProducto";
            this.btnBuscarCodProducto.Size = new System.Drawing.Size(33, 28);
            this.btnBuscarCodProducto.TabIndex = 136;
            this.btnBuscarCodProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCodProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCodProducto.UseVisualStyleBackColor = false;
            this.btnBuscarCodProducto.Click += new System.EventHandler(this.btnBuscarCodProducto_Click);
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGenerarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarVenta.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarVenta.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btnGenerarVenta.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerarVenta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGenerarVenta.IconSize = 30;
            this.btnGenerarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarVenta.Location = new System.Drawing.Point(905, 409);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(244, 46);
            this.btnGenerarVenta.TabIndex = 135;
            this.btnGenerarVenta.Text = "Generar Venta";
            this.btnGenerarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerarVenta.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Honeydew;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.Black;
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAñadir.IconColor = System.Drawing.Color.Green;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 30;
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAñadir.Location = new System.Drawing.Point(905, 85);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(241, 72);
            this.btnAñadir.TabIndex = 95;
            this.btnAñadir.Text = "Agregar";
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnTotalizar
            // 
            this.btnTotalizar.BackColor = System.Drawing.Color.Honeydew;
            this.btnTotalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotalizar.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalizar.ForeColor = System.Drawing.Color.Black;
            this.btnTotalizar.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnTotalizar.IconColor = System.Drawing.Color.Green;
            this.btnTotalizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTotalizar.IconSize = 30;
            this.btnTotalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotalizar.Location = new System.Drawing.Point(905, 309);
            this.btnTotalizar.Name = "btnTotalizar";
            this.btnTotalizar.Size = new System.Drawing.Size(244, 46);
            this.btnTotalizar.TabIndex = 138;
            this.btnTotalizar.Text = "Totalizar";
            this.btnTotalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTotalizar.UseVisualStyleBackColor = false;
            this.btnTotalizar.Click += new System.EventHandler(this.btnTotalizar_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Roboto Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(257, 89);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(302, 24);
            this.cboCliente.TabIndex = 139;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 25;
            // 
            // Prod_CodigoBarras
            // 
            this.Prod_CodigoBarras.HeaderText = "Codigo";
            this.Prod_CodigoBarras.Name = "Prod_CodigoBarras";
            this.Prod_CodigoBarras.ReadOnly = true;
            this.Prod_CodigoBarras.Width = 150;
            // 
            // Prod_Nombre
            // 
            this.Prod_Nombre.HeaderText = "Producto";
            this.Prod_Nombre.Name = "Prod_Nombre";
            this.Prod_Nombre.ReadOnly = true;
            this.Prod_Nombre.Width = 180;
            // 
            // Prod_Cantidad
            // 
            this.Prod_Cantidad.HeaderText = "Cantidad";
            this.Prod_Cantidad.Name = "Prod_Cantidad";
            this.Prod_Cantidad.ReadOnly = true;
            this.Prod_Cantidad.Width = 70;
            // 
            // Prod_PrecioVenta
            // 
            this.Prod_PrecioVenta.HeaderText = "Precio";
            this.Prod_PrecioVenta.Name = "Prod_PrecioVenta";
            this.Prod_PrecioVenta.ReadOnly = true;
            this.Prod_PrecioVenta.Width = 110;
            // 
            // Prod_Subtotal
            // 
            this.Prod_Subtotal.HeaderText = "Subtotal";
            this.Prod_Subtotal.Name = "Prod_Subtotal";
            this.Prod_Subtotal.ReadOnly = true;
            this.Prod_Subtotal.Width = 120;
            // 
            // Prod_Itbis
            // 
            this.Prod_Itbis.HeaderText = "Total Itbis";
            this.Prod_Itbis.Name = "Prod_Itbis";
            this.Prod_Itbis.ReadOnly = true;
            // 
            // Prod_Total
            // 
            this.Prod_Total.HeaderText = "Total";
            this.Prod_Total.Name = "Prod_Total";
            this.Prod_Total.ReadOnly = true;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 473);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.btnTotalizar);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnBuscarCodProducto);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.boxCambio);
            this.Controls.Add(this.txtPagarCon);
            this.Controls.Add(this.boxPagarCon);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.boxTotalPagar);
            this.Controls.Add(this.txtTotalItbis);
            this.Controls.Add(this.boxTotalItbis);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.cboItbis);
            this.Controls.Add(this.txtItbis);
            this.Controls.Add(this.boxCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.boxStockActual);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.boxCodProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.boxProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.boxPrecio);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtInfoCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txtRegistrarVenta);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtInfoVenta);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtInfoCliente;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label txtRegistrarVenta;
        private FontAwesome.Sharp.IconButton btnAñadir;
        private System.Windows.Forms.Label txtInfoVenta;
        private System.Windows.Forms.Label txtNombreCompleto;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.TextBox boxPrecio;
        private System.Windows.Forms.Label txtProducto;
        private System.Windows.Forms.TextBox boxProducto;
        private System.Windows.Forms.Label txtCodProducto;
        private System.Windows.Forms.TextBox boxCodProducto;
        private System.Windows.Forms.Label txtStockActual;
        private System.Windows.Forms.TextBox boxStockActual;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.NumericUpDown boxCantidad;
        private System.Windows.Forms.Label txtItbis;
        private System.Windows.Forms.ComboBox cboItbis;
        private System.Windows.Forms.Label txtDetalle;
        private System.Windows.Forms.Label txtTotalItbis;
        private System.Windows.Forms.TextBox boxTotalItbis;
        private System.Windows.Forms.Label txtTotalPagar;
        private System.Windows.Forms.TextBox boxTotalPagar;
        private System.Windows.Forms.Label txtCambio;
        private System.Windows.Forms.TextBox boxCambio;
        private System.Windows.Forms.Label txtPagarCon;
        private System.Windows.Forms.TextBox boxPagarCon;
        private FontAwesome.Sharp.IconButton btnGenerarVenta;
        private FontAwesome.Sharp.IconButton btnBuscarCodProducto;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private FontAwesome.Sharp.IconButton btnTotalizar;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_CodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_Total;
    }
}