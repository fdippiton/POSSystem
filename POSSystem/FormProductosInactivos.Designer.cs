namespace POSSystem
{
    partial class FormProductosInactivos
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
            this.txtListaProductosInactivos = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnVaciarRegistros = new FontAwesome.Sharp.IconButton();
            this.EliminarRegistro = new FontAwesome.Sharp.IconButton();
            this.txtProductoSeleccionado = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
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
            // txtListaProductosInactivos
            // 
            this.txtListaProductosInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtListaProductosInactivos.Location = new System.Drawing.Point(12, 9);
            this.txtListaProductosInactivos.Name = "txtListaProductosInactivos";
            this.txtListaProductosInactivos.Size = new System.Drawing.Size(389, 25);
            this.txtListaProductosInactivos.TabIndex = 81;
            this.txtListaProductosInactivos.Text = "Lista de Productos Inactivos y Agotados";
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
            this.dgvdata.Location = new System.Drawing.Point(0, 42);
            this.dgvdata.MinimumSize = new System.Drawing.Size(0, 28);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.Size = new System.Drawing.Size(1181, 473);
            this.dgvdata.TabIndex = 80;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // btnVaciarRegistros
            // 
            this.btnVaciarRegistros.BackColor = System.Drawing.Color.Crimson;
            this.btnVaciarRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarRegistros.ForeColor = System.Drawing.Color.White;
            this.btnVaciarRegistros.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnVaciarRegistros.IconColor = System.Drawing.Color.White;
            this.btnVaciarRegistros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVaciarRegistros.IconSize = 16;
            this.btnVaciarRegistros.Location = new System.Drawing.Point(1062, 6);
            this.btnVaciarRegistros.Name = "btnVaciarRegistros";
            this.btnVaciarRegistros.Size = new System.Drawing.Size(107, 30);
            this.btnVaciarRegistros.TabIndex = 82;
            this.btnVaciarRegistros.Text = "Vaciar registros";
            this.btnVaciarRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVaciarRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVaciarRegistros.UseVisualStyleBackColor = false;
            this.btnVaciarRegistros.Click += new System.EventHandler(this.btnVaciarRegistros_Click);
            // 
            // EliminarRegistro
            // 
            this.EliminarRegistro.BackColor = System.Drawing.Color.Black;
            this.EliminarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarRegistro.ForeColor = System.Drawing.Color.White;
            this.EliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.EliminarRegistro.IconColor = System.Drawing.Color.White;
            this.EliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EliminarRegistro.IconSize = 16;
            this.EliminarRegistro.Location = new System.Drawing.Point(917, 6);
            this.EliminarRegistro.Name = "EliminarRegistro";
            this.EliminarRegistro.Size = new System.Drawing.Size(33, 30);
            this.EliminarRegistro.TabIndex = 83;
            this.EliminarRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarRegistro.UseVisualStyleBackColor = false;
            this.EliminarRegistro.Click += new System.EventHandler(this.EliminarRegistro_Click);
            // 
            // txtProductoSeleccionado
            // 
            this.txtProductoSeleccionado.AutoSize = true;
            this.txtProductoSeleccionado.Location = new System.Drawing.Point(739, 15);
            this.txtProductoSeleccionado.Name = "txtProductoSeleccionado";
            this.txtProductoSeleccionado.Size = new System.Drawing.Size(119, 13);
            this.txtProductoSeleccionado.TabIndex = 84;
            this.txtProductoSeleccionado.Text = "Producto seleccionado:";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(864, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 13);
            this.txtId.TabIndex = 85;
            this.txtId.Text = "Ninguno";
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
            // FormProductosInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 514);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtProductoSeleccionado);
            this.Controls.Add(this.EliminarRegistro);
            this.Controls.Add(this.btnVaciarRegistros);
            this.Controls.Add(this.txtListaProductosInactivos);
            this.Controls.Add(this.dgvdata);
            this.Name = "FormProductosInactivos";
            this.Text = "FormProductosInactivos";
            this.Load += new System.EventHandler(this.FormProductosInactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtListaProductosInactivos;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnVaciarRegistros;
        private FontAwesome.Sharp.IconButton EliminarRegistro;
        private System.Windows.Forms.Label txtProductoSeleccionado;
        private System.Windows.Forms.Label txtId;
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