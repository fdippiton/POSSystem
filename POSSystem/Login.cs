using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        // CLOSE FORM FUNCTION
        /// The form_closing function clears the text in document and password boxes and then shows the LoginForm.
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            boxDocumento.Text = string.Empty; // Clean document box
            boxContrasena.Text = string.Empty; // Clean password box
            this.Show(); // Show LoginForm
        }

        // LOGIN BTN
        /// The function `IngresarBtn_Click` handles user login logic by retrieving a user object from a
        /// list based on input credentials and displaying the next form if login is successful.
        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new BL_Usuario().Listar();

            /* Retrieving a user object (`Usuario`) from a list of users. */
            Usuario oUsuario = new BL_Usuario().Listar().Where(u => u.Usu_Documento == boxDocumento.Text && u.Usu_Contrasena == boxContrasena.Text && u.Usu_Estatus == "A").FirstOrDefault();

            /* Handling the logic after a user attempts to log in. */
            if (oUsuario != null)
            {
                Inicio form = new Inicio(oUsuario);

                form.Show(); // Show next winform after login 
                this.Hide(); // Hide LoginForm 

                form.FormClosing += form_closing;  // Show LoginForm after close InicioForm 
            }
            else
            {
                // In case of wrong credentials 
                MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        // CANCEL LOGIN FUNCTION
        /// The CancelarBtn_Click function closes the current form when the corresponding button is clicked.
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // Close form  
        }
    }
}
