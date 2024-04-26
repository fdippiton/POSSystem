namespace POSSystem
{
    partial class FormDetalleCompras
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.txtListaUsuarios = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtDetalleUsuario = new System.Windows.Forms.Label();
            this.cboestatus = new System.Windows.Forms.ComboBox();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.boxdocumento = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Usu_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Com_Proveedor_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Com_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Com_Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Com_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(256, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(106, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Usuario  actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(54, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(54, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Usuario:";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(1073, 41);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.ReadOnly = true;
            this.txtIndice.Size = new System.Drawing.Size(48, 20);
            this.txtIndice.TabIndex = 102;
            this.txtIndice.Text = "-1";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(1019, 41);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(48, 20);
            this.textId.TabIndex = 101;
            this.textId.Text = "0";
            // 
            // txtListaUsuarios
            // 
            this.txtListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtListaUsuarios.Location = new System.Drawing.Point(51, 201);
            this.txtListaUsuarios.Name = "txtListaUsuarios";
            this.txtListaUsuarios.Size = new System.Drawing.Size(172, 25);
            this.txtListaUsuarios.TabIndex = 100;
            this.txtListaUsuarios.Text = "Productos";
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
            this.Com_Proveedor_Id,
            this.Com_Proveedor,
            this.Com_Comprobante,
            this.Com_Producto});
            this.dgvdata.Location = new System.Drawing.Point(56, 229);
            this.dgvdata.MinimumSize = new System.Drawing.Size(0, 28);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.Size = new System.Drawing.Size(1117, 270);
            this.dgvdata.TabIndex = 99;
            // 
            // txtDetalleUsuario
            // 
            this.txtDetalleUsuario.AutoSize = true;
            this.txtDetalleUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtDetalleUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtDetalleUsuario.Location = new System.Drawing.Point(52, 50);
            this.txtDetalleUsuario.Name = "txtDetalleUsuario";
            this.txtDetalleUsuario.Size = new System.Drawing.Size(242, 22);
            this.txtDetalleUsuario.TabIndex = 98;
            this.txtDetalleUsuario.Text = "Registrar Compra Productos ";
            // 
            // cboestatus
            // 
            this.cboestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestatus.FormattingEnabled = true;
            this.cboestatus.Location = new System.Drawing.Point(57, 163);
            this.cboestatus.Name = "cboestatus";
            this.cboestatus.Size = new System.Drawing.Size(192, 21);
            this.cboestatus.TabIndex = 94;
            // 
            // cborol
            // 
            this.cborol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(259, 98);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(237, 21);
            this.cborol.TabIndex = 93;
            // 
            // boxdocumento
            // 
            this.boxdocumento.Location = new System.Drawing.Point(259, 164);
            this.boxdocumento.Name = "boxdocumento";
            this.boxdocumento.Size = new System.Drawing.Size(117, 20);
            this.boxdocumento.TabIndex = 92;
            // 
            // txtdocumento
            // 
            this.txtdocumento.AutoSize = true;
            this.txtdocumento.BackColor = System.Drawing.Color.Transparent;
            this.txtdocumento.Location = new System.Drawing.Point(54, 98);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(101, 13);
            this.txtdocumento.TabIndex = 91;
            this.txtdocumento.Text = "Información Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(258, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(383, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Precio de compra";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 109;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(513, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(510, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 110;
            this.label7.Text = "Precio de venta";
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
            this.btnEliminar.Location = new System.Drawing.Point(1073, 89);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 97;
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
            this.btnEditar.Location = new System.Drawing.Point(1046, 141);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 30);
            this.btnEditar.TabIndex = 96;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAñadir.IconColor = System.Drawing.Color.White;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 16;
            this.btnAñadir.Location = new System.Drawing.Point(648, 158);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(110, 30);
            this.btnAñadir.TabIndex = 95;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadir.UseVisualStyleBackColor = false;
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
            // Com_Proveedor_Id
            // 
            this.Com_Proveedor_Id.HeaderText = "Proveedor_Id";
            this.Com_Proveedor_Id.Name = "Com_Proveedor_Id";
            this.Com_Proveedor_Id.ReadOnly = true;
            this.Com_Proveedor_Id.Visible = false;
            // 
            // Com_Proveedor
            // 
            this.Com_Proveedor.HeaderText = "Proveedor";
            this.Com_Proveedor.Name = "Com_Proveedor";
            this.Com_Proveedor.ReadOnly = true;
            this.Com_Proveedor.Width = 150;
            // 
            // Com_Comprobante
            // 
            this.Com_Comprobante.HeaderText = "Comprobante";
            this.Com_Comprobante.Name = "Com_Comprobante";
            this.Com_Comprobante.ReadOnly = true;
            this.Com_Comprobante.Width = 180;
            // 
            // Com_Producto
            // 
            this.Com_Producto.HeaderText = "Producto";
            this.Com_Producto.Name = "Com_Producto";
            this.Com_Producto.ReadOnly = true;
            this.Com_Producto.Width = 150;
            // 
            // FormDetalleCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 583);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.Name = "FormDetalleCompras";
            this.Text = "FormDetalleCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label txtListaUsuarios;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label txtDetalleUsuario;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAñadir;
        private System.Windows.Forms.ComboBox cboestatus;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.TextBox boxdocumento;
        private System.Windows.Forms.Label txtdocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usu_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Com_Proveedor_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Com_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Com_Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Com_Producto;
    }
}