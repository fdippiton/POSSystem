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

  

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            boxDocumento.Text = string.Empty; // Limpiar los box
            boxContrasena.Text = string.Empty;
            this.Show(); // Mostrar la vista de Login
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new BL_Usuario().Listar();

            // Se obtiene el usuario si existe
            Usuario oUsuario = new BL_Usuario().Listar().Where(u => u.Usu_Documento == boxDocumento.Text && u.Usu_Contrasena == boxContrasena.Text && u.Usu_Estatus == "A").FirstOrDefault();

            if (oUsuario != null)
            {
                Inicio form = new Inicio(oUsuario);

                form.Show(); // Mostrar la proxima ventana despues de iniciar sesion
                this.Hide(); // Ocultar la ventana de inicio de sesion

                form.FormClosing += form_closing;  // Cuando se cierre la vista de Inicio, se muestre la vista de Login

            }
            else
            {
                // En caso de credenciales incorrectas
                MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // Para cerrar la ventana  
        }
    }
}
