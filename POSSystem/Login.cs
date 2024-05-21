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
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            boxDocumento.Text = string.Empty; // Clean document box
            boxContrasena.Text = string.Empty; // Clean password box
            this.Show(); // Show LoginForm
        }

        // LOGIN BTN
        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new BL_Usuario().Listar();

            // Retrieve user if exists 
            Usuario oUsuario = new BL_Usuario().Listar().Where(u => u.Usu_Documento == boxDocumento.Text && u.Usu_Contrasena == boxContrasena.Text && u.Usu_Estatus == "A").FirstOrDefault();

            if (oUsuario != null)
            {
                Inicio form = new Inicio(oUsuario);

                form.Show(); // Show next winform after login 
                this.Hide(); // Hide LoginForm 

                form.FormClosing += form_closing;  // Show LoginForm after close InicioForm 
            }
            else
            {
                // En caso de credenciales incorrectas
                MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        // CANCEL LOGIN FUNCTION
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // Close form  
        }
    }
}
