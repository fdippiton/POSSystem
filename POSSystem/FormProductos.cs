using BusinessLayer;
using EntityLayer;
using POSSystem.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace POSSystem
{
    public partial class FormProductos : Form
    {
        public int indice_combo_Cat;
        private bool seleccionado = true; // Cambiado a true
        private int rowIndexSelected = -1;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // Listar los categorias en el dropdown
            List<Categoria> listaCategorias = new BL_Categoria().ListarCategorias();
            foreach (Categoria item in listaCategorias)
            {
                cboCategoria.Items.Add(new OpcionCombo()
                {
                    Valor = item.Cat_Id,
                    Texto = item.Cat_Nombre
                });

            }
            cboCategoria.DisplayMember = "Texto";
            cboCategoria.ValueMember = "Valor";
            cboCategoria.SelectedIndex = 0;

            CargarProductos();
            boxCantidadInicial.Enabled = true;
            boxPrecioCompra.Enabled = true;
        }

     
        private void LimpiarCampos()
        {
            textId.Text = "0";
            boxNombre.Text = "";
            boxDescripcion.Text = "";
            boxCantidadInicial.Text = "";
            boxPrecioCompra.Text = "";
            boxPrecioVenta.Text = "";
            cboCategoria.SelectedItem = 0;
            boxCantidadInicial.Enabled = true;
            boxPrecioCompra.Enabled = true;
        }

        private void CargarProductos()
        {
            BL_Producto blProducto = new BL_Producto();
            List<Producto> listaProductos = blProducto.ListarProductos("A"); // Asumiendo que existe un método ListarProductos que retorna una lista de productos

            dgvdata.Rows.Clear(); // Limpiar las filas existentes



            foreach (var producto in listaProductos)
            {
                // Convertir la cadena Base64 de la imagen a un objeto Image
                byte[] byteImage = Convert.FromBase64String(producto.Prod_Barras);
                Image imagenCodigoBarras;
                using (MemoryStream memoryStream = new MemoryStream(byteImage))
                {
                    imagenCodigoBarras = Image.FromStream(memoryStream);
                }

                // Crear una celda de imagen para la columna de código de barras
                DataGridViewImageCell imagenCell = new DataGridViewImageCell();
                imagenCell.Value = imagenCodigoBarras;

                // Convertir los valores numéricos
                decimal valorInventarioInicial = producto.Prod_StockInicial * producto.Prod_PrecioCompra;
                decimal valorInventarioActual = producto.Prod_StockActual * producto.Prod_PrecioCompra;


                // Agregar las demás celdas a la fila
                dgvdata.Rows.Add(new object[] {
                "", // Esto representa la primera columna (si hay una columna para el ID, por ejemplo)
                // producto.Prod_Id,
                producto.Prod_CodigoBarras,
                producto.Prod_Barras,
                producto.Prod_Nombre,
                producto.oProd_Categoria_Id.Cat_Id,
                producto.oProd_Categoria_Id.Cat_Nombre, // Asumiendo que el objeto Categoria tiene una propiedad Cat_Id
                producto.Prod_Descripcion,
                producto.Prod_StockInicial,
                producto.Prod_StockActual,
                producto.Prod_PrecioCompra,
                producto.Prod_PrecioVenta,
                valorInventarioInicial,
                valorInventarioActual,
                producto.Prod_Fecha.ToString("d")
                });

                int rowIndex = dgvdata.Rows.Count - 1;
                // Agregar la celda de imagen a la columna específica del DataGridView
                dgvdata.Rows[rowIndex].Cells["Prod_Barras"] = imagenCell;

                // Centrar la imagen en la celda
                dgvdata.Rows[rowIndex].Cells["Prod_Barras"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Agregar relleno a la imagen en la celda
                int padding = 5; // Puedes ajustar este valor según tu preferencia
                dgvdata.Rows[rowIndex].Cells["Prod_Barras"].Style.Padding = new Padding(padding);
                dgvdata.Rows[rowIndex].Height = 30;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            // Validar cada campo individualmente para ofrecer retroalimentación específica.
            if (string.IsNullOrWhiteSpace(boxNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es requerido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!int.TryParse(boxCantidadInicial.Text, out int stockInicial))
            {
                MessageBox.Show("El campo 'Cantidad Inicial' debe ser un número entero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(boxPrecioCompra.Text, out decimal precioCompra))
            {
                MessageBox.Show("El campo 'Precio de Compra' debe ser un número entero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(boxPrecioVenta.Text, out decimal precioVenta))
            {
                MessageBox.Show("El campo 'Precio de Venta' debe ser un número entero.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cboCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!(cboCategoria.SelectedItem is OpcionCombo opcion) ||
                !int.TryParse(Convert.ToString(opcion.Valor), out int categoriaId))
            {
                MessageBox.Show("El valor de la categoría seleccionada no es válido.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crear el objeto producto con los datos del formulario
            Producto nuevoProducto = new Producto
            {
                Prod_Nombre = boxNombre.Text,
                Prod_Descripcion = boxDescripcion.Text,
                oProd_Categoria_Id = new Categoria { Cat_Id = categoriaId },
                Prod_StockInicial = stockInicial,
                Prod_StockActual = stockInicial,
                Prod_PrecioCompra = precioCompra,
                Prod_PrecioVenta = precioVenta,
                Prod_Estatus = "A"
            };

            // Instanciar la lógica de negocio y tratar de agregar el producto
            BL_Producto blProducto = new BL_Producto();

            bool resultado = blProducto.CrearProducto(nuevoProducto);

            // Verificar si el producto fue agregado correctamente
            if (resultado)
            {
                MessageBox.Show("Producto creado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                LimpiarCampos();
            }
            else
            {
                // Hubo un error al crear el producto
                MessageBox.Show("Error al crear el producto.", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarCampos();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Crear el objeto producto con los datos del formulario
            Producto productoEditado = new Producto
            {
                Prod_CodigoBarras = textId.Text,
                //Prod_Id = Convert.ToInt32(textId.Text),
                Prod_Nombre = boxNombre.Text,
                Prod_Descripcion = boxDescripcion.Text,
                oProd_Categoria_Id = new Categoria { Cat_Id = Convert.ToInt32(((OpcionCombo)cboCategoria.SelectedItem).Valor) },
                Prod_PrecioVenta = Convert.ToDecimal(boxPrecioVenta.Text),
            };

            // Instanciar la lógica de negocio y tratar de editar el producto
            BL_Producto blProducto = new BL_Producto();
            bool resultado = blProducto.EditarProducto(productoEditado);

            // Verificar si el producto fue editado correctamente
            if (resultado)
            {
                seleccionado = false;
                CargarProductos();
                MessageBox.Show("Producto editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                // Hubo un error al editar el producto
                MessageBox.Show("Error al editar el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            // Crear el objeto producto con los datos del formulario
            Producto productoEditado = new Producto
            {
                Prod_CodigoBarras = textId.Text,
                //Prod_Id = Convert.ToInt32(textId.Text),
                Prod_Nombre = boxNombre.Text,
                Prod_Descripcion = boxDescripcion.Text,
                Prod_Estatus = "I",
                oProd_Categoria_Id = new Categoria { Cat_Id = Convert.ToInt32(((OpcionCombo)cboCategoria.SelectedItem).Valor) },
            };

            // Instanciar la lógica de negocio y tratar de editar el producto
            BL_Producto blProducto = new BL_Producto();
            bool resultado = blProducto.InactivarProducto(productoEditado);

            // Verificar si el producto fue editado correctamente
            if (resultado)
            {
                seleccionado = false;
                CargarProductos();
                MessageBox.Show("Producto inactivado correctamente.", "Información",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                // Hubo un error al editar el producto
                MessageBox.Show("Error al inactivar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    // Obtener el ID del producto a eliminar desde el DataGridView
        //    int productoId = Convert.ToInt32(dgvdata.CurrentRow.Cells["Prod_Id"].Value);

        //    // Instanciar la lógica de negocio y tratar de eliminar el producto
        //    BL_Producto blProducto = new BL_Producto();
        //    bool resultado = blProducto.EliminarProducto(productoId);

        //    // Verificar si el producto fue eliminado correctamente
        //    if (resultado)
        //    {
        //        // Eliminar la fila correspondiente en el DataGridView
        //        dgvdata.Rows.RemoveAt(dgvdata.CurrentRow.Index);
        //        LimpiarCampos();

        //        MessageBox.Show("Producto eliminado correctamente.");
        //    }
        //    else
        //    {
        //        // Hubo un error al eliminar el producto
        //        MessageBox.Show("Error al eliminar el producto.");
        //    }
        //}


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

        private void CargarDatosFilaSeleccionada()
        {
            int indice = rowIndexSelected;
            if (indice >= 0)
            {
                textId.Text = dgvdata.Rows[indice].Cells["Prod_CodigoBarras"].Value.ToString();
                // textId.Text = dgvdata.Rows[indice].Cells["Prod_Id"].Value.ToString();
                boxNombre.Text = dgvdata.Rows[indice].Cells["Prod_Nombre"].Value.ToString();
                boxDescripcion.Text = dgvdata.Rows[indice].Cells["Prod_Descripcion"].Value.ToString();
                boxCantidadInicial.Text = dgvdata.Rows[indice].Cells["Prod_StockInicial"].Value.ToString();
                boxPrecioCompra.Text = dgvdata.Rows[indice].Cells["Prod_PrecioCompra"].Value.ToString();
                boxPrecioVenta.Text = dgvdata.Rows[indice].Cells["Prod_PrecioVenta"].Value.ToString();

                boxCantidadInicial.Enabled = false;
                boxPrecioCompra.Enabled = false;

                foreach (OpcionCombo oc in cboCategoria.Items)
                {
                    if (oc.Valor.ToString() == dgvdata.Rows[indice].Cells["Prod_Categoria_Id"].Value.ToString())
                    {
                        indice_combo_Cat = cboCategoria.Items.IndexOf(oc);
                        cboCategoria.SelectedIndex = indice_combo_Cat;
                        break;
                    }
                }

                seleccionado = true;
            }
        }

        // Cargar los datos en los textBox
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


    }
}
