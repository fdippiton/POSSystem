namespace POSSystem
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsuarioActual = new System.Windows.Forms.Label();
            this.UsuarioTitulo = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.tituloPrincipal = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuProductosInactivos = new System.Windows.Forms.ToolStripMenuItem();
            this.SubmenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuImprimirCodigo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsuarioActual
            // 
            this.UsuarioActual.AutoSize = true;
            this.UsuarioActual.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsuarioActual.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioActual.ForeColor = System.Drawing.SystemColors.Window;
            this.UsuarioActual.Location = new System.Drawing.Point(1257, 21);
            this.UsuarioActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsuarioActual.Name = "UsuarioActual";
            this.UsuarioActual.Size = new System.Drawing.Size(65, 19);
            this.UsuarioActual.TabIndex = 11;
            this.UsuarioActual.Text = "Usuario";
            // 
            // UsuarioTitulo
            // 
            this.UsuarioTitulo.AutoSize = true;
            this.UsuarioTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsuarioTitulo.Font = new System.Drawing.Font("Roboto Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.UsuarioTitulo.Location = new System.Drawing.Point(1156, 21);
            this.UsuarioTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsuarioTitulo.Name = "UsuarioTitulo";
            this.UsuarioTitulo.Size = new System.Drawing.Size(81, 19);
            this.UsuarioTitulo.TabIndex = 10;
            this.UsuarioTitulo.Text = "Usuario: ";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 90);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1575, 637);
            this.contenedor.TabIndex = 9;
            // 
            // tituloPrincipal
            // 
            this.tituloPrincipal.AutoSize = true;
            this.tituloPrincipal.BackColor = System.Drawing.SystemColors.MenuText;
            this.tituloPrincipal.Font = new System.Drawing.Font("Roboto Mono", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tituloPrincipal.Location = new System.Drawing.Point(16, 15);
            this.tituloPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloPrincipal.Name = "tituloPrincipal";
            this.tituloPrincipal.Size = new System.Drawing.Size(130, 29);
            this.tituloPrincipal.TabIndex = 8;
            this.tituloPrincipal.Text = "POSSystem";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMantenedor,
            this.menuVentas,
            this.menuUsuarios,
            this.menuClientes,
            this.menuProveedores,
            this.menuCompras,
            this.menuReportes,
            this.menuAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 59);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(1575, 31);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuProducto,
            this.SubmenuProductosInactivos,
            this.SubmenuCategoria,
            this.SubMenuImprimirCodigo});
            this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuMantenedor.IconColor = System.Drawing.Color.Black;
            this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenedor.IconSize = 23;
            this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(127, 27);
            this.menuMantenedor.Text = "Mantenedor";
            // 
            // SubMenuProducto
            // 
            this.SubMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuProducto.IconColor = System.Drawing.Color.Black;
            this.SubMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuProducto.Name = "SubMenuProducto";
            this.SubMenuProducto.Size = new System.Drawing.Size(220, 26);
            this.SubMenuProducto.Text = "Producto";
            this.SubMenuProducto.Click += new System.EventHandler(this.SubMenuProducto_Click);
            // 
            // SubmenuProductosInactivos
            // 
            this.SubmenuProductosInactivos.Name = "SubmenuProductosInactivos";
            this.SubmenuProductosInactivos.Size = new System.Drawing.Size(220, 26);
            this.SubmenuProductosInactivos.Text = "Productos inactivos";
            this.SubmenuProductosInactivos.Click += new System.EventHandler(this.SubmenuProductosInactivos_Click);
            // 
            // SubmenuCategoria
            // 
            this.SubmenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuCategoria.IconColor = System.Drawing.Color.Black;
            this.SubmenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuCategoria.Name = "SubmenuCategoria";
            this.SubmenuCategoria.Size = new System.Drawing.Size(220, 26);
            this.SubmenuCategoria.Text = "Categoria";
            this.SubmenuCategoria.Click += new System.EventHandler(this.SubmenuCategoria_Click);
            // 
            // SubMenuImprimirCodigo
            // 
            this.SubMenuImprimirCodigo.Name = "SubMenuImprimirCodigo";
            this.SubMenuImprimirCodigo.Size = new System.Drawing.Size(220, 26);
            this.SubMenuImprimirCodigo.Text = "Imprimir codigos";
            this.SubMenuImprimirCodigo.Click += new System.EventHandler(this.SubMenuImprimirCodigo_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRegistrarVenta,
            this.SubmenuVerDetalleVenta});
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 23;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(89, 27);
            this.menuVentas.Text = "Ventas";
            // 
            // SubmenuRegistrarVenta
            // 
            this.SubmenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.SubmenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuRegistrarVenta.Name = "SubmenuRegistrarVenta";
            this.SubmenuRegistrarVenta.Size = new System.Drawing.Size(191, 26);
            this.SubmenuRegistrarVenta.Text = "Registrar venta";
            this.SubmenuRegistrarVenta.Click += new System.EventHandler(this.SubmenuRegistrarVenta_Click);
            // 
            // SubmenuVerDetalleVenta
            // 
            this.SubmenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.SubmenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuVerDetalleVenta.Name = "SubmenuVerDetalleVenta";
            this.SubmenuVerDetalleVenta.Size = new System.Drawing.Size(191, 26);
            this.SubmenuVerDetalleVenta.Text = "Ver detalle";
            this.SubmenuVerDetalleVenta.Click += new System.EventHandler(this.SubmenuVerDetalleVenta_Click);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 23;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(102, 27);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 23;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(98, 27);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuProveedores.IconColor = System.Drawing.Color.Black;
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.IconSize = 23;
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(128, 27);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRegistrarCompra,
            this.SubmenuVerDetalleCompra});
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 23;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(105, 27);
            this.menuCompras.Text = "Compras";
            // 
            // SubmenuRegistrarCompra
            // 
            this.SubmenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.SubmenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuRegistrarCompra.Name = "SubmenuRegistrarCompra";
            this.SubmenuRegistrarCompra.Size = new System.Drawing.Size(206, 26);
            this.SubmenuRegistrarCompra.Text = "Registrar compra";
            this.SubmenuRegistrarCompra.Click += new System.EventHandler(this.SubmenuRegistrarCompra_Click);
            // 
            // SubmenuVerDetalleCompra
            // 
            this.SubmenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.SubmenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuVerDetalleCompra.Name = "SubmenuVerDetalleCompra";
            this.SubmenuVerDetalleCompra.Size = new System.Drawing.Size(206, 26);
            this.SubmenuVerDetalleCompra.Text = "Ver detalle";
            this.SubmenuVerDetalleCompra.Click += new System.EventHandler(this.SubmenuVerDetalleCompra_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 23;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(105, 27);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.menuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.menuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcercaDe.IconSize = 23;
            this.menuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(112, 27);
            this.menuAcercaDe.Text = "Acerca de";
            this.menuAcercaDe.Click += new System.EventHandler(this.menuAcercaDe_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.SystemColors.MenuText;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1575, 59);
            this.menuTitulo.TabIndex = 7;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 727);
            this.Controls.Add(this.UsuarioActual);
            this.Controls.Add(this.UsuarioTitulo);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.tituloPrincipal);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioActual;
        private System.Windows.Forms.Label UsuarioTitulo;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label tituloPrincipal;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem SubmenuCategoria;
        private FontAwesome.Sharp.IconMenuItem SubMenuProducto;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem SubmenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem SubmenuVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem SubmenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem SubmenuVerDetalleCompra;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private FontAwesome.Sharp.IconMenuItem menuAcercaDe;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.ToolStripMenuItem SubMenuImprimirCodigo;
        private System.Windows.Forms.ToolStripMenuItem SubmenuProductosInactivos;
    }
}

