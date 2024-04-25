using EntityLayer;
using BusinessLayer;
using POSSystem.Utilidades;
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
    public partial class FormCategorias : Form
    {
        public int indice_combo_estatus;

        public FormCategorias()
        {
            InitializeComponent();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            // Agrega un nuevo elemento al ComboBox cboestatus. Este nuevo elemento es una instancia de la clase OpcionCombo con el valor "A" y el texto "Activo"
            cboEstatus.Items.Add(new OpcionCombo()
            {
                Valor = "A",
                Texto = "Activo"
            });
            cboEstatus.Items.Add(new OpcionCombo()
            {
                Valor = "I",
                Texto = "Inactivo"
            });

            cboEstatus.DisplayMember = "Texto"; // muestre el texto de los elementos en lugar de cualquier otro valor. En este caso, mostrará el texto definido en la propiedad Texto de la clase OpcionCombo.
            cboEstatus.ValueMember = "Valor"; // Establece la propiedad ValueMember del ComboBox cboestatus para que el valor seleccionado sea el valor definido en la propiedad Valor de la clase OpcionCombo.
            cboEstatus.SelectedIndex = 0; // Establece el índice seleccionado inicialmente en el ComboBox cboestatus como 0, lo que significa que el primer elemento en la lista desplegable será seleccionado por defecto.


            //foreach (DataGridViewColumn columna in dgvdata.Columns)
            //{
            //    // Aquí se verifica si la columna actual es visible (Visible == true) y si su nombre no es "btnSeleccionar". Esto se hace para excluir una columna especial que probablemente no se desea incluir en el ComboBox (quizás una columna de botón de selección).
            //    if (columna.Visible == true && columna.Name != "btnSeleccionar")
            //    {
            //        // Para cada columna visible que pase la condición anterior, se agrega un nuevo elemento al ComboBox cboBuscar. Este nuevo elemento es una instancia de la clase OpcionCombo, donde el valor es el nombre de la columna (columna.Name) y el texto es el encabezado de la columna (columna.HeaderText).
            //        cboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            //    }
            //}

            //cboBuscar.DisplayMember = "Texto";
            //cboBuscar.ValueMember = "Valor";
            //cboBuscar.SelectedIndex = 0;



            // Listar todos los usuarios en el dataGrid
            List<Categoria> listaCategorias = new BL_Categoria().ListarCategorias();

            foreach (Categoria categoria in listaCategorias)
            {
                dgvdata.Rows.Add(new object[] { "",
                categoria.Cat_Id,
                categoria.Cat_Nombre,
                categoria.Cat_Estatus,
                categoria.Cat_Estatus
                });

            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Para que no considere la primera fila, ya que es la cabecera
            if (e.RowIndex < 0) { return; }

            if (e.ColumnIndex == 0)
            {
                // Para que considere todos los limites de la celda
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.tick_symbol_icon15.Width;
                var h = Properties.Resources.tick_symbol_icon15.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.tick_symbol_icon15, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void Limpiar()
        {
            // Limpiar o resetear los controles del formulario
            boxNombre.Text = "";
        }


        private void CargarDatos()
        {
            BL_Categoria blCategoria = new BL_Categoria();
            List<Categoria> listaCategorias = blCategoria.ListarCategorias(); // Asumiendo que existe un método ListarCategorias que retorna una lista de categorías

            dgvdata.Rows.Clear(); // Limpiar las filas existentes

            foreach (var categoria in listaCategorias)
            {
                // Asumiendo que tienes un DataGridView llamado dgvdata con las columnas adecuadas
                dgvdata.Rows.Add(new object[] {
            "", // Para un posible campo de control, como un checkbox o ícono
            categoria.Cat_Id,
            categoria.Cat_Nombre,
            categoria.Cat_Estatus,
            categoria.Cat_Estatus
        });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                cboEstatus.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return; // Detener la ejecución adicional si alguno de los campos está vacío
            }

            // Crear el objeto categoría con los datos del formulario
            Categoria nuevaCategoria = new Categoria
            {
                Cat_Nombre = boxNombre.Text,
                Cat_Estatus = ((OpcionCombo)cboEstatus.SelectedItem).Valor.ToString() // Asumiendo que Cat_Estatus es un string
            };

            // Instanciar la lógica de negocio y tratar de agregar la categoría
            BL_Categoria blCategoria = new BL_Categoria();

            // Intentar agregar la categoría a la base de datos
            bool resultado = blCategoria.CrearCategoria(nuevaCategoria);

            // Verificar si la categoría fue agregada correctamente
            if (resultado)
            {
                MessageBox.Show("Categoría creada correctamente.");
                CargarDatos(); // Actualizar la lista o el DataGridView con los datos actualizados
                Limpiar();     // Limpiar los campos del formulario
            }
            else
            {
                // Hubo un error al crear la categoría
                MessageBox.Show("Error al crear la categoría.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Crear el objeto categoría con los datos del formulario
            Categoria categoriaEditada = new Categoria
            {
                Cat_Id = Convert.ToInt32(txtId.Text), // Suponiendo que textId contiene el Id de la categoría a editar
                Cat_Nombre = boxNombre.Text,
                Cat_Estatus = ((OpcionCombo)cboEstatus.SelectedItem).Valor.ToString()
            };

            // Instanciar la lógica de negocio y tratar de editar la categoría
            BL_Categoria blCategoria = new BL_Categoria();
            bool resultado = blCategoria.EditarCategoria(categoriaEditada);

            // Verificar si la categoría fue editada correctamente
            if (resultado)
            {
                // Actualizar la fila correspondiente en el DataGridView con los nuevos datos de la categoría editada
                int indiceFila = dgvdata.CurrentRow.Index;
                dgvdata.Rows[indiceFila].Cells["Cat_Id"].Value = categoriaEditada.Cat_Id;
                dgvdata.Rows[indiceFila].Cells["Cat_Nombre"].Value = categoriaEditada.Cat_Nombre;
                dgvdata.Rows[indiceFila].Cells["Cat_Estatus"].Value = categoriaEditada.Cat_Estatus;

                MessageBox.Show("Categoría editada correctamente.");
                Limpiar();
            }
            else
            {
                // Hubo un error al editar la categoría
                MessageBox.Show("Error al editar la categoría.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la categoría a eliminar desde el DataGridView
            int categoriaId = Convert.ToInt32(dgvdata.CurrentRow.Cells["Cat_Id"].Value);

            // Instanciar la lógica de negocio y tratar de eliminar la categoría
            BL_Categoria blCategoria = new BL_Categoria();
            bool resultado = blCategoria.EliminarCategoria(categoriaId);

            // Verificar si la categoría fue eliminada correctamente
            if (resultado)
            {
                // Eliminar la fila correspondiente en el DataGridView
                dgvdata.Rows.RemoveAt(dgvdata.CurrentRow.Index);
                Limpiar();
                MessageBox.Show("Categoría eliminada correctamente.");
            }
            else
            {
                // Hubo un error al eliminar la categoría
                MessageBox.Show("Error al eliminar la categoría.");
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtId.Text = dgvdata.Rows[indice].Cells["Cat_Id"].Value.ToString();
                    boxNombre.Text = dgvdata.Rows[indice].Cells["Cat_Nombre"].Value.ToString();

                    foreach (OpcionCombo os in cboEstatus.Items)
                    {
                        if (os.Valor.ToString() == dgvdata.Rows[indice].Cells["EstatusValor"].Value.ToString())
                        {
                            indice_combo_estatus = cboEstatus.Items.IndexOf(os);
                            cboEstatus.SelectedIndex = indice_combo_estatus;
                            break;
                        }
                    }
                }
            }
        }
    }
}
