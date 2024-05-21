using BusinessLayer;
using EntityLayer;
using POSSystem.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class FormUsuarios : Form
    {
        public int indice_combo_rol;
        public int indice_combo_estatus;
        private bool seleccionado = true; // Cambiado a true
        private int rowIndexSelected = -1;
        public FormUsuarios()
        {
            InitializeComponent();
        }


         /// The function "CargarUsuarios" loads a list of users into a DataGridView in a C# application.
        private void CargarUsuarios()
        {
            BL_Usuario blUsuario = new BL_Usuario();
            List<Usuario> listaUsuarios = blUsuario.Listar(); // Asumiendo que existe un método Listar que retorna una lista de usuarios

            dgvdata.Rows.Clear(); // Limpiar las filas existentes

            foreach (var usuario in listaUsuarios)
            {
                dgvdata.Rows.Add(new object[] { "", usuario.Usu_Id, usuario.Usu_Documento, usuario.Usu_NombreCompleto, usuario.Usu_Correo, usuario.Usu_Contrasena,
                usuario.oRol_Id.Rol_Id, usuario.oRol_Id.Rol_Descripcion, usuario.Usu_Estatus, usuario.Usu_Estatus });
            }
        }


        /// The FormUsuarios_Load function initializes ComboBoxes with specific options and populates them with
        /// data from lists, while also setting up filtering options for a DataGridView.
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // Agrega un nuevo elemento al ComboBox cboestatus. Este nuevo elemento es una instancia de la clase OpcionCombo con el valor "A" y el texto "Activo"
            cboestatus.Items.Add(new OpcionCombo()
            {
                Valor = "A",
                Texto = "Activo"
            });
            cboestatus.Items.Add(new OpcionCombo()
            {
                Valor = "I",
                Texto = "Inactivo"
            });

            cboestatus.DisplayMember = "Texto"; // muestre el texto de los elementos en lugar de cualquier otro valor. En este caso, mostrará el texto definido en la propiedad Texto de la clase OpcionCombo.
            cboestatus.ValueMember = "Valor"; // Establece la propiedad ValueMember del ComboBox cboestatus para que el valor seleccionado sea el valor definido en la propiedad Valor de la clase OpcionCombo.
            cboestatus.SelectedIndex = 0; // Establece el índice seleccionado inicialmente en el ComboBox cboestatus como 0, lo que significa que el primer elemento en la lista desplegable será seleccionado por defecto.

            // Listar los roles en el dropdown
            List<Rol> listaRol = new BL_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cborol.Items.Add(new OpcionCombo()
                {
                    Valor = item.Rol_Id,
                    Texto = item.Rol_Descripcion
                });

            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;


            // Agregar los campos para filtrar
            // Este bucle recorre todas las columnas en el DataGridView dgvdata.
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                // Aquí se verifica si la columna actual es visible (Visible == true) y si su nombre no es "btnSeleccionar". Esto se hace para excluir una columna especial que probablemente no se desea incluir en el ComboBox (quizás una columna de botón de selección).
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    // Para cada columna visible que pase la condición anterior, se agrega un nuevo elemento al ComboBox cboBuscar. Este nuevo elemento es una instancia de la clase OpcionCombo, donde el valor es el nombre de la columna (columna.Name) y el texto es el encabezado de la columna (columna.HeaderText).
                    cboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cboBuscar.DisplayMember = "Texto";
            cboBuscar.ValueMember = "Valor";
            cboBuscar.SelectedIndex = 0;

            CargarUsuarios();
        }


        private void LimpiarCampos()
        {
            txtIndice.Text = "-1";
            textId.Text = "0";
            boxdocumento.Text = "";
            boxnombrecompleto.Text = "";
            boxcorreo.Text = "";
            boxcontrasena.Text = "";
            boxconfirmarcontrasena.Text = "";
            cborol.SelectedItem = 0;
            cboestatus.SelectedItem = 0;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(boxdocumento.Text) ||
                string.IsNullOrWhiteSpace(boxnombrecompleto.Text) ||
                string.IsNullOrWhiteSpace(boxcorreo.Text) ||
                string.IsNullOrWhiteSpace(boxcontrasena.Text) ||
                cborol.SelectedItem == null ||
                cboestatus.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución adicional si alguno de los campos está vacío
            }

            // Crear el objeto usuario con los datos del formulario
            Usuario nuevoUsuario = new Usuario
            {
                Usu_Documento = boxdocumento.Text,
                Usu_NombreCompleto = boxnombrecompleto.Text,
                Usu_Correo = boxcorreo.Text,
                Usu_Contrasena = boxcontrasena.Text,
                oRol_Id = new Rol { Rol_Id = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) }, // Asumiendo que el Rol_Id es un int
                Usu_Estatus = ((OpcionCombo)cboestatus.SelectedItem).Valor.ToString()
            };

            // Instanciar la lógica de negocio y tratar de agregar el usuario
            BL_Usuario blUsuario = new BL_Usuario();

            // Verificar si ya existe un usuario con el mismo documento
            bool documentoExistente = blUsuario.VerificarDocumentoExistente(nuevoUsuario.Usu_Documento);

            if (documentoExistente)
            {
                MessageBox.Show("Ya existe un usuario con el mismo documento.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
                return; // Detener la ejecución si existe ya un documento similar
            }
            else
            {
                bool resultado = blUsuario.AgregarUsuario(nuevoUsuario);

                // Verificar si el usuario fue agregado correctamente
                if (resultado)
                {
                    MessageBox.Show("Usuario creado correctamente.", "Información");
                    CargarUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    // Hubo un error al crear el usuario
                    MessageBox.Show("Error al crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpiarCampos();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Crear el objeto usuario con los datos del formulario
            Usuario usuarioEditado = new Usuario
            {
                Usu_Id = Convert.ToInt32(textId.Text), // Suponiendo que textId contiene el Id del usuario a editar
                Usu_Documento = boxdocumento.Text,
                Usu_NombreCompleto = boxnombrecompleto.Text,
                Usu_Correo = boxcorreo.Text,
                Usu_Contrasena = boxcontrasena.Text,
                oRol_Id = new Rol { Rol_Id = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) },
                Usu_Estatus = ((OpcionCombo)cboestatus.SelectedItem).Valor.ToString()
            };

            // Instanciar la lógica de negocio y tratar de editar el usuario
            BL_Usuario blUsuario = new BL_Usuario();
            bool resultado = blUsuario.EditarUsuario(usuarioEditado);

            // Verificar si el usuario fue editado correctamente
            if (resultado)
            {
                // Actualizar la fila correspondiente en el DataGridView con los nuevos datos del usuario editado
                int indiceFila = dgvdata.CurrentRow.Index;
                dgvdata.Rows[indiceFila].Cells["Usu_Id"].Value = usuarioEditado.Usu_Id;
                dgvdata.Rows[indiceFila].Cells["Usu_Documento"].Value = usuarioEditado.Usu_Documento;
                dgvdata.Rows[indiceFila].Cells["Usu_NombreCompleto"].Value = usuarioEditado.Usu_NombreCompleto;
                dgvdata.Rows[indiceFila].Cells["Usu_Correo"].Value = usuarioEditado.Usu_Correo;
                dgvdata.Rows[indiceFila].Cells["Usu_Contrasena"].Value = usuarioEditado.Usu_Contrasena;
                dgvdata.Rows[indiceFila].Cells["Usu_Rol_Id"].Value = usuarioEditado.oRol_Id.Rol_Id;
                dgvdata.Rows[indiceFila].Cells["Usu_Rol"].Value = ((OpcionCombo)cborol.SelectedItem).Texto;
                dgvdata.Rows[indiceFila].Cells["EstatusValor"].Value = usuarioEditado.Usu_Estatus;
                dgvdata.Rows[indiceFila].Cells["Usu_Estatus"].Value = ((OpcionCombo)cboestatus.SelectedItem).Valor;

                MessageBox.Show("Usuario editado correctamente.", "Información");
                seleccionado = false;
                CargarUsuarios();
                LimpiarCampos();
            }
            else
            {
                // Hubo un error al editar el usuario
                MessageBox.Show("Error al editar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del usuario a eliminar desde el DataGridView
            int usuarioId = Convert.ToInt32(dgvdata.CurrentRow.Cells["Usu_Id"].Value);

            // Instanciar la lógica de negocio y tratar de eliminar el usuario
            BL_Usuario blUsuario = new BL_Usuario();
            bool resultado = blUsuario.EliminarUsuario(usuarioId);

            // Verificar si el usuario fue eliminado correctamente
            if (resultado)
            {
                // Eliminar la fila correspondiente en el DataGridView
                dgvdata.Rows.RemoveAt(dgvdata.CurrentRow.Index);
                LimpiarCampos();

                MessageBox.Show("Usuario eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hubo un error al eliminar el usuario
                MessageBox.Show("Error al eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PintarIconoTickEnTodasLasCeldas()
        {
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                // Si la fila no está seleccionada, pinta el ícono del tick en la celda
                if (row.Index != rowIndexSelected)
                {
                    dgvdata.InvalidateCell(0, row.Index);
                }
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                Image icono = Properties.Resources.tick_symbol_icon15;

                if (e.RowIndex == rowIndexSelected && seleccionado)
                {
                    icono = Properties.Resources.close_icon15;
                }

                var w = icono.Width;
                var h = icono.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(icono, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // Verifica si la fila seleccionada ya coincide con la fila seleccionada anteriormente
                if (e.RowIndex == rowIndexSelected)
                {
                    // Si es así, deselecciona la fila y limpia los campos
                    LimpiarCampos();
                    dgvdata.InvalidateCell(0, rowIndexSelected);
                    rowIndexSelected = -1; // Establece rowIndexSelected a -1 para indicar que no hay fila seleccionada
                    seleccionado = false;
                }
                else
                {
                    // Si la fila seleccionada es diferente a la fila seleccionada anteriormente
                    if (seleccionado)
                    {
                        // Limpia los campos y deselecciona la fila anteriormente seleccionada
                        LimpiarCampos();
                        dgvdata.InvalidateCell(0, rowIndexSelected);
                    }

                    // Actualiza rowIndexSelected y marca la fila como seleccionada
                    rowIndexSelected = e.RowIndex;
                    seleccionado = true;

                    // Carga los datos de la fila seleccionada en los campos
                    CargarDatosFilaSeleccionada();

                    // Actualiza la apariencia de la celda del botón
                    dgvdata.InvalidateCell(0, e.RowIndex);
                }

                // Pinta el ícono del tick en todas las demás celdas
                PintarIconoTickEnTodasLasCeldas();
            }
        }

        private void CargarDatosFilaSeleccionada()
        {
            int indice = rowIndexSelected;
            if (indice >= 0)
            {
                txtIndice.Text = indice.ToString();
                textId.Text = dgvdata.Rows[indice].Cells["Usu_Id"].Value.ToString();
                boxdocumento.Text = dgvdata.Rows[indice].Cells["Usu_Documento"].Value.ToString();
                boxnombrecompleto.Text = dgvdata.Rows[indice].Cells["Usu_NombreCompleto"].Value.ToString();
                boxcorreo.Text = dgvdata.Rows[indice].Cells["Usu_Correo"].Value.ToString();
                boxcontrasena.Text = dgvdata.Rows[indice].Cells["Usu_Contrasena"].Value.ToString();
                boxconfirmarcontrasena.Text = dgvdata.Rows[indice].Cells["Usu_Contrasena"].Value.ToString();

                foreach (OpcionCombo oc in cborol.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Usu_Rol_Id"].Value))
                    {
                        indice_combo_rol = cborol.Items.IndexOf(oc);
                        cborol.SelectedIndex = indice_combo_rol;
                        break;
                    }
                }

                foreach (OpcionCombo os in cboestatus.Items)
                {
                    if (os.Valor.ToString() == dgvdata.Rows[indice].Cells["EstatusValor"].Value.ToString())
                    {
                        indice_combo_estatus = cboestatus.Items.IndexOf(os);
                        cboestatus.SelectedIndex = indice_combo_estatus;
                    }
                }
            }
        }
    }
}
