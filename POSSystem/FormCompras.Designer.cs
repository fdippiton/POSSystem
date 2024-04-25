namespace POSSystem
{
    partial class FormCompras
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
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.boxBuscar = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtFiltrar = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.txtListaUsuarios = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Usu_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Rol_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstatusValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usu_Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDetalleUsuario = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtestatus = new System.Windows.Forms.Label();
            this.cboestatus = new System.Windows.Forms.ComboBox();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.txtrol = new System.Windows.Forms.Label();
            this.boxconfirmarcontrasena = new System.Windows.Forms.TextBox();
            this.txtconfirmarcontrasena = new System.Windows.Forms.Label();
            this.boxcontrasena = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.Label();
            this.boxcorreo = new System.Windows.Forms.TextBox();
            this.boxnombrecompleto = new System.Windows.Forms.TextBox();
            this.boxdocumento = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.Label();
            this.txtnombrecompleto = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(163, 53);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ReadOnly = true;
            this.txtIndice.Size = new System.Drawing.Size(48, 20);
            this.txtIndice.TabIndex = 86;
            this.txtIndice.Text = "-1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoSize = true;
            this.txtBuscar.Location = new System.Drawing.Point(830, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(61, 13);
            this.txtBuscar.TabIndex = 85;
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
            this.btnLimpiar.Location = new System.Drawing.Point(1103, 18);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(36, 30);
            this.btnLimpiar.TabIndex = 84;
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
            this.btnBuscar.Location = new System.Drawing.Point(1061, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 30);
            this.btnBuscar.TabIndex = 83;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // boxBuscar
            // 
            this.boxBuscar.Location = new System.Drawing.Point(890, 23);
            this.boxBuscar.Name = "boxBuscar";
            this.boxBuscar.Size = new System.Drawing.Size(156, 20);
            this.boxBuscar.TabIndex = 82;
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(651, 23);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(156, 21);
            this.cboBuscar.TabIndex = 81;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.AutoSize = true;
            this.txtFiltrar.Location = new System.Drawing.Point(616, 27);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(35, 13);
            this.txtFiltrar.TabIndex = 80;
            this.txtFiltrar.Text = "Filtrar:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(217, 53);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(48, 20);
            this.textId.TabIndex = 79;
            this.textId.Text = "0";
            // 
            // txtListaUsuarios
            // 
            this.txtListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtListaUsuarios.Location = new System.Drawing.Point(300, 21);
            this.txtListaUsuarios.Name = "txtListaUsuarios";
            this.txtListaUsuarios.Size = new System.Drawing.Size(172, 25);
            this.txtListaUsuarios.TabIndex = 78;
            this.txtListaUsuarios.Text = "Lista de Usuarios";
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
            this.Usu_Id,
            this.Usu_Documento,
            this.Usu_NombreCompleto,
            this.Usu_Correo,
            this.Usu_Contrasena,
            this.Usu_Rol_Id,
            this.Usu_Rol,
            this.EstatusValor,
            this.Usu_Estatus});
            this.dgvdata.Location = new System.Drawing.Point(302, 71);
            this.dgvdata.MinimumSize = new System.Drawing.Size(0, 28);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.Size = new System.Drawing.Size(837, 429);
            this.dgvdata.TabIndex = 77;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 25;
            // 
            // Usu_Id
            // 
            this.Usu_Id.HeaderText = "Id";
            this.Usu_Id.Name = "Usu_Id";
            this.Usu_Id.ReadOnly = true;
            this.Usu_Id.Visible = false;
            // 
            // Usu_Documento
            // 
            this.Usu_Documento.HeaderText = "Nro. Documento";
            this.Usu_Documento.Name = "Usu_Documento";
            this.Usu_Documento.ReadOnly = true;
            this.Usu_Documento.Width = 150;
            // 
            // Usu_NombreCompleto
            // 
            this.Usu_NombreCompleto.HeaderText = "Nombre Completo";
            this.Usu_NombreCompleto.Name = "Usu_NombreCompleto";
            this.Usu_NombreCompleto.ReadOnly = true;
            this.Usu_NombreCompleto.Width = 180;
            // 
            // Usu_Correo
            // 
            this.Usu_Correo.HeaderText = "Correo";
            this.Usu_Correo.Name = "Usu_Correo";
            this.Usu_Correo.ReadOnly = true;
            this.Usu_Correo.Width = 150;
            // 
            // Usu_Contrasena
            // 
            this.Usu_Contrasena.HeaderText = "Contraseña";
            this.Usu_Contrasena.Name = "Usu_Contrasena";
            this.Usu_Contrasena.ReadOnly = true;
            this.Usu_Contrasena.Visible = false;
            // 
            // Usu_Rol_Id
            // 
            this.Usu_Rol_Id.HeaderText = "Id Rol";
            this.Usu_Rol_Id.Name = "Usu_Rol_Id";
            this.Usu_Rol_Id.ReadOnly = true;
            // 
            // Usu_Rol
            // 
            this.Usu_Rol.HeaderText = "Rol";
            this.Usu_Rol.Name = "Usu_Rol";
            this.Usu_Rol.ReadOnly = true;
            // 
            // EstatusValor
            // 
            this.EstatusValor.HeaderText = "EstatusValor";
            this.EstatusValor.Name = "EstatusValor";
            this.EstatusValor.ReadOnly = true;
            this.EstatusValor.Visible = false;
            // 
            // Usu_Estatus
            // 
            this.Usu_Estatus.HeaderText = "Estatus";
            this.Usu_Estatus.Name = "Usu_Estatus";
            this.Usu_Estatus.ReadOnly = true;
            // 
            // txtDetalleUsuario
            // 
            this.txtDetalleUsuario.AutoSize = true;
            this.txtDetalleUsuario.BackColor = System.Drawing.Color.White;
            this.txtDetalleUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtDetalleUsuario.Location = new System.Drawing.Point(24, 15);
            this.txtDetalleUsuario.Name = "txtDetalleUsuario";
            this.txtDetalleUsuario.Size = new System.Drawing.Size(133, 22);
            this.txtDetalleUsuario.TabIndex = 76;
            this.txtDetalleUsuario.Text = "Detalle Usuario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 16;
            this.btnEliminar.Location = new System.Drawing.Point(190, 420);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 75;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnEditar.Location = new System.Drawing.Point(109, 420);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 30);
            this.btnEditar.TabIndex = 74;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(28, 420);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 73;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtestatus
            // 
            this.txtestatus.AutoSize = true;
            this.txtestatus.BackColor = System.Drawing.Color.White;
            this.txtestatus.Location = new System.Drawing.Point(25, 370);
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.Size = new System.Drawing.Size(42, 13);
            this.txtestatus.TabIndex = 72;
            this.txtestatus.Text = "Estatus";
            // 
            // cboestatus
            // 
            this.cboestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestatus.FormattingEnabled = true;
            this.cboestatus.Location = new System.Drawing.Point(28, 386);
            this.cboestatus.Name = "cboestatus";
            this.cboestatus.Size = new System.Drawing.Size(237, 21);
            this.cboestatus.TabIndex = 71;
            // 
            // cborol
            // 
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(28, 334);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(237, 21);
            this.cborol.TabIndex = 70;
            // 
            // txtrol
            // 
            this.txtrol.AutoSize = true;
            this.txtrol.BackColor = System.Drawing.Color.White;
            this.txtrol.Location = new System.Drawing.Point(25, 318);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(23, 13);
            this.txtrol.TabIndex = 69;
            this.txtrol.Text = "Rol";
            // 
            // boxconfirmarcontrasena
            // 
            this.boxconfirmarcontrasena.Location = new System.Drawing.Point(28, 283);
            this.boxconfirmarcontrasena.Name = "boxconfirmarcontrasena";
            this.boxconfirmarcontrasena.PasswordChar = '*';
            this.boxconfirmarcontrasena.Size = new System.Drawing.Size(237, 20);
            this.boxconfirmarcontrasena.TabIndex = 68;
            // 
            // txtconfirmarcontrasena
            // 
            this.txtconfirmarcontrasena.AutoSize = true;
            this.txtconfirmarcontrasena.BackColor = System.Drawing.Color.White;
            this.txtconfirmarcontrasena.Location = new System.Drawing.Point(25, 267);
            this.txtconfirmarcontrasena.Name = "txtconfirmarcontrasena";
            this.txtconfirmarcontrasena.Size = new System.Drawing.Size(107, 13);
            this.txtconfirmarcontrasena.TabIndex = 67;
            this.txtconfirmarcontrasena.Text = "Confirmar contraseña";
            // 
            // boxcontrasena
            // 
            this.boxcontrasena.Location = new System.Drawing.Point(28, 232);
            this.boxcontrasena.Name = "boxcontrasena";
            this.boxcontrasena.PasswordChar = '*';
            this.boxcontrasena.Size = new System.Drawing.Size(237, 20);
            this.boxcontrasena.TabIndex = 66;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.AutoSize = true;
            this.txtcontrasena.BackColor = System.Drawing.Color.White;
            this.txtcontrasena.Location = new System.Drawing.Point(25, 216);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(61, 13);
            this.txtcontrasena.TabIndex = 65;
            this.txtcontrasena.Text = "Contraseña";
            // 
            // boxcorreo
            // 
            this.boxcorreo.Location = new System.Drawing.Point(28, 181);
            this.boxcorreo.Name = "boxcorreo";
            this.boxcorreo.Size = new System.Drawing.Size(237, 20);
            this.boxcorreo.TabIndex = 64;
            // 
            // boxnombrecompleto
            // 
            this.boxnombrecompleto.Location = new System.Drawing.Point(28, 130);
            this.boxnombrecompleto.Name = "boxnombrecompleto";
            this.boxnombrecompleto.Size = new System.Drawing.Size(237, 20);
            this.boxnombrecompleto.TabIndex = 63;
            // 
            // boxdocumento
            // 
            this.boxdocumento.Location = new System.Drawing.Point(28, 79);
            this.boxdocumento.Name = "boxdocumento";
            this.boxdocumento.Size = new System.Drawing.Size(237, 20);
            this.boxdocumento.TabIndex = 62;
            // 
            // txtcorreo
            // 
            this.txtcorreo.AutoSize = true;
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            this.txtcorreo.Location = new System.Drawing.Point(25, 165);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(38, 13);
            this.txtcorreo.TabIndex = 61;
            this.txtcorreo.Text = "Correo";
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.AutoSize = true;
            this.txtnombrecompleto.BackColor = System.Drawing.Color.White;
            this.txtnombrecompleto.Location = new System.Drawing.Point(25, 114);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(91, 13);
            this.txtnombrecompleto.TabIndex = 60;
            this.txtnombrecompleto.Text = "Nombre Completo";
            // 
            // txtdocumento
            // 
            this.txtdocumento.AutoSize = true;
            this.txtdocumento.BackColor = System.Drawing.Color.White;
            this.txtdocumento.Location = new System.Drawing.Point(25, 63);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(85, 13);
            this.txtdocumento.TabIndex = 59;
            this.txtdocumento.Text = "Nro. Documento";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 511);
            this.label1.TabIndex = 58;
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 511);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.boxBuscar);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.txtListaUsuarios);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txtDetalleUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtestatus);
            this.Controls.Add(this.cboestatus);
            this.Controls.Add(this.cborol);
            this.Controls.Add(this.txtrol);
            this.Controls.Add(this.boxconfirmarcontrasena);
            this.Controls.Add(this.txtconfirmarcontrasena);
            this.Controls.Add(this.boxcontrasena);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.boxcorreo);
            this.Controls.Add(this.boxnombrecompleto);
            this.Controls.Add(this.boxdocumento);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtnombrecompleto);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.label1);
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label txtBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox boxBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Label txtFiltrar;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label txtListaUsuarios;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Rol_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstatusValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Estatus;
        private System.Windows.Forms.Label txtDetalleUsuario;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label txtestatus;
        private System.Windows.Forms.ComboBox cboestatus;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.Label txtrol;
        private System.Windows.Forms.TextBox boxconfirmarcontrasena;
        private System.Windows.Forms.Label txtconfirmarcontrasena;
        private System.Windows.Forms.TextBox boxcontrasena;
        private System.Windows.Forms.Label txtcontrasena;
        private System.Windows.Forms.TextBox boxcorreo;
        private System.Windows.Forms.TextBox boxnombrecompleto;
        private System.Windows.Forms.TextBox boxdocumento;
        private System.Windows.Forms.Label txtcorreo;
        private System.Windows.Forms.Label txtnombrecompleto;
        private System.Windows.Forms.Label txtdocumento;
        private System.Windows.Forms.Label label1;
    }
}