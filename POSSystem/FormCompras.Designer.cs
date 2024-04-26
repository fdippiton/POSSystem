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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIndice = new System.Windows.Forms.TextBox();
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
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.cboestatus = new System.Windows.Forms.ComboBox();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.boxdocumento = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(1044, 12);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ReadOnly = true;
            this.txtIndice.Size = new System.Drawing.Size(48, 20);
            this.txtIndice.TabIndex = 86;
            this.txtIndice.Text = "-1";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(990, 12);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(48, 20);
            this.textId.TabIndex = 79;
            this.textId.Text = "0";
            // 
            // txtListaUsuarios
            // 
            this.txtListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtListaUsuarios.Location = new System.Drawing.Point(23, 198);
            this.txtListaUsuarios.Name = "txtListaUsuarios";
            this.txtListaUsuarios.Size = new System.Drawing.Size(172, 25);
            this.txtListaUsuarios.TabIndex = 78;
            this.txtListaUsuarios.Text = "Productos";
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
            this.Usu_Id,
            this.Usu_Documento,
            this.Usu_NombreCompleto,
            this.Usu_Correo,
            this.Usu_Contrasena,
            this.Usu_Rol_Id,
            this.Usu_Rol,
            this.EstatusValor,
            this.Usu_Estatus});
            this.dgvdata.Location = new System.Drawing.Point(27, 242);
            this.dgvdata.MinimumSize = new System.Drawing.Size(0, 28);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.Size = new System.Drawing.Size(1117, 270);
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
            this.txtDetalleUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtDetalleUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtDetalleUsuario.Location = new System.Drawing.Point(23, 21);
            this.txtDetalleUsuario.Name = "txtDetalleUsuario";
            this.txtDetalleUsuario.Size = new System.Drawing.Size(156, 22);
            this.txtDetalleUsuario.TabIndex = 76;
            this.txtDetalleUsuario.Text = "Registrar Compra ";
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
            this.btnEliminar.Location = new System.Drawing.Point(1044, 60);
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
            this.btnEditar.Location = new System.Drawing.Point(1017, 112);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 30);
            this.btnEditar.TabIndex = 74;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAñadir.IconColor = System.Drawing.Color.White;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 16;
            this.btnAñadir.Location = new System.Drawing.Point(856, 21);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 30);
            this.btnAñadir.TabIndex = 73;
            this.btnAñadir.Text = "Guardar";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // cboestatus
            // 
            this.cboestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestatus.FormattingEnabled = true;
            this.cboestatus.Location = new System.Drawing.Point(282, 112);
            this.cboestatus.Name = "cboestatus";
            this.cboestatus.Size = new System.Drawing.Size(237, 21);
            this.cboestatus.TabIndex = 71;
            // 
            // cborol
            // 
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(282, 154);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(237, 21);
            this.cborol.TabIndex = 70;
            // 
            // boxdocumento
            // 
            this.boxdocumento.Location = new System.Drawing.Point(640, 165);
            this.boxdocumento.Name = "boxdocumento";
            this.boxdocumento.Size = new System.Drawing.Size(237, 20);
            this.boxdocumento.TabIndex = 62;
            // 
            // txtdocumento
            // 
            this.txtdocumento.AutoSize = true;
            this.txtdocumento.BackColor = System.Drawing.Color.Transparent;
            this.txtdocumento.Location = new System.Drawing.Point(25, 69);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(101, 13);
            this.txtdocumento.TabIndex = 59;
            this.txtdocumento.Text = "Información Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(279, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(279, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(77, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Usuario  actual";
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.txtListaUsuarios);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txtDetalleUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.cboestatus);
            this.Controls.Add(this.cborol);
            this.Controls.Add(this.boxdocumento);
            this.Controls.Add(this.txtdocumento);
            this.Name = "FormCompras";
            this.Text = "FormCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndice;
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
        private FontAwesome.Sharp.IconButton btnAñadir;
        private System.Windows.Forms.ComboBox cboestatus;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.TextBox boxdocumento;
        private System.Windows.Forms.Label txtdocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}