using BusinessLayer;
using EntityLayer;
using FontAwesome.Sharp;
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
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        // Se le pasa el usuario
        public Inicio(Usuario objusuario = null)
        {
            // Si el usuario no existe
            if (objusuario == null)
            {
                usuarioActual = new Usuario()
                {
                    Usu_NombreCompleto = "Usuario Admin",
                    Usu_Id = 1
                };
            }
            else
            {
                // Si el usuario existe se inicializa una nueva instancia de usuario
                usuarioActual = objusuario;
            }
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // Se obtienen todos los permisos del usuario actual
            List<Permiso> ListaPermisos = new BL_Permiso().Listar(usuarioActual.Usu_Id);

            // En el menu solo se muestran los permisos que ese usuario tiene disponible 
            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.Per_Nombre == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }
            // Se muestra el usuario actual en la esquina superior derecha
            UsuarioActual.Text = usuarioActual.Usu_NombreCompleto;
        }

        // Mostrar el contenido segun ventana especifica del menu
        // Esto define una función llamada AbrirFormulario que toma dos parámetros: menu, que parece ser un elemento de menú, y formulario, que es un objeto de tipo Form
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            // Esta línea comprueba si hay algún elemento de menú activo actualmente (almacenado en una variable llamada MenuActivo). Si hay uno, cambia su color de fondo a blanco.
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;  // Establece el color de fondo del elemento de menú seleccionado (menu) como plateado para indicar que está activo
            MenuActivo = menu; // Actualiza la variable MenuActivo para almacenar el elemento de menú que se ha seleccionado recientemente

            // Verifica si ya hay un formulario activo en la ventana. Si existe, lo cierra.
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario; // // Actualiza la variable FormularioActivo para almacenar el nuevo formulario que se va a mostrar.
            formulario.TopLevel = false; // Esta línea indica que el formulario no es de nivel superior, lo que significa que es un formulario secundario dentro de otro formulario.
            formulario.FormBorderStyle = FormBorderStyle.None; // Establece el estilo del borde del formulario como "None", lo que significa que el formulario no tendrá bordes visibles.
            formulario.Dock = DockStyle.Fill; // Hace que el formulario se ajuste al tamaño completo del contenedor en el que se va a colocar.
            formulario.BackColor = Color.LightGray; // Establece el color de fondo del formulario como gris claro.

            contenedor.Controls.Add(formulario); // Agrega el formulario al contenedor especificado (contenedor). Esto permite que el formulario se muestre dentro del contenedor.
            formulario.Show(); // Finalmente, muestra el formulario.
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormUsuarios());
        }

        private void SubmenuCategoria_Click(object sender, EventArgs e)
        {
            // Se le pasa la opcion del menu y la vista que mostrara
            AbrirFormulario(menuMantenedor, new FormCategorias());
        }

        private void SubMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new FormProductos());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuClientes, new FormClientes());
        }

        private void SubmenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new FormVentas());
        }

        private void SubmenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new FormDetalleVentas());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuProveedores, new FormProveedores());
        }

        private void SubmenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new FormCompras());
        }

        private void SubmenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuCompras, new FormDetalleCompras());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuReportes, new FormReportes());
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuAcercaDe, new FormAcercaDe());
        }

        private void SubMenuImprimirCodigo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new FormImprimirCodigos());
        }

        private void SubmenuProductosInactivos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenedor, new FormProductosInactivos());
        }
    }
}
