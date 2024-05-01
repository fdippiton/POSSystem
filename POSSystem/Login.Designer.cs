namespace POSSystem
{
    partial class Login
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
            this.CancelarBtn = new FontAwesome.Sharp.IconButton();
            this.IngresarBtn = new FontAwesome.Sharp.IconButton();
            this.contrasena = new System.Windows.Forms.Label();
            this.documentoTitulo = new System.Windows.Forms.Label();
            this.boxContrasena = new System.Windows.Forms.TextBox();
            this.boxDocumento = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.logintitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.BackColor = System.Drawing.Color.MistyRose;
            this.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarBtn.Font = new System.Drawing.Font("Roboto Mono", 9F);
            this.CancelarBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CancelarBtn.IconColor = System.Drawing.Color.Black;
            this.CancelarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarBtn.IconSize = 30;
            this.CancelarBtn.Location = new System.Drawing.Point(790, 308);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(149, 43);
            this.CancelarBtn.TabIndex = 17;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarBtn.UseVisualStyleBackColor = false;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // IngresarBtn
            // 
            this.IngresarBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.IngresarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IngresarBtn.Font = new System.Drawing.Font("Roboto Mono", 9F);
            this.IngresarBtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.IngresarBtn.IconColor = System.Drawing.Color.Black;
            this.IngresarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IngresarBtn.IconSize = 30;
            this.IngresarBtn.Location = new System.Drawing.Point(572, 308);
            this.IngresarBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IngresarBtn.Name = "IngresarBtn";
            this.IngresarBtn.Size = new System.Drawing.Size(149, 43);
            this.IngresarBtn.TabIndex = 16;
            this.IngresarBtn.Text = "Ingresar";
            this.IngresarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IngresarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IngresarBtn.UseVisualStyleBackColor = false;
            this.IngresarBtn.Click += new System.EventHandler(this.IngresarBtn_Click);
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.Font = new System.Drawing.Font("Roboto Mono", 9F);
            this.contrasena.Location = new System.Drawing.Point(572, 236);
            this.contrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(77, 16);
            this.contrasena.TabIndex = 15;
            this.contrasena.Text = "Contraseña";
            // 
            // documentoTitulo
            // 
            this.documentoTitulo.AutoSize = true;
            this.documentoTitulo.Font = new System.Drawing.Font("Roboto Mono", 9F);
            this.documentoTitulo.Location = new System.Drawing.Point(572, 169);
            this.documentoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.documentoTitulo.Name = "documentoTitulo";
            this.documentoTitulo.Size = new System.Drawing.Size(98, 16);
            this.documentoTitulo.TabIndex = 14;
            this.documentoTitulo.Text = "No. Documento";
            // 
            // boxContrasena
            // 
            this.boxContrasena.Font = new System.Drawing.Font("Roboto Mono", 9F);
            this.boxContrasena.Location = new System.Drawing.Point(572, 254);
            this.boxContrasena.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxContrasena.Name = "boxContrasena";
            this.boxContrasena.PasswordChar = '*';
            this.boxContrasena.Size = new System.Drawing.Size(367, 23);
            this.boxContrasena.TabIndex = 13;
            // 
            // boxDocumento
            // 
            this.boxDocumento.Font = new System.Drawing.Font("Roboto Mono", 9F);
            this.boxDocumento.Location = new System.Drawing.Point(572, 187);
            this.boxDocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxDocumento.Name = "boxDocumento";
            this.boxDocumento.Size = new System.Drawing.Size(367, 23);
            this.boxDocumento.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 88;
            this.iconPictureBox1.Location = new System.Drawing.Point(106, 142);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(88, 96);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // logintitulo
            // 
            this.logintitulo.AutoSize = true;
            this.logintitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logintitulo.Font = new System.Drawing.Font("Roboto Mono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintitulo.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.logintitulo.Location = new System.Drawing.Point(91, 287);
            this.logintitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logintitulo.Name = "logintitulo";
            this.logintitulo.Size = new System.Drawing.Size(120, 26);
            this.logintitulo.TabIndex = 10;
            this.logintitulo.Text = "POSSystem";
            this.logintitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 591);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Roboto Mono", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(91, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Punto de Venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.IngresarBtn);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.documentoTitulo);
            this.Controls.Add(this.boxContrasena);
            this.Controls.Add(this.boxDocumento);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.logintitulo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelarBtn;
        private FontAwesome.Sharp.IconButton IngresarBtn;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.Label documentoTitulo;
        private System.Windows.Forms.TextBox boxContrasena;
        private System.Windows.Forms.TextBox boxDocumento;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label logintitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}