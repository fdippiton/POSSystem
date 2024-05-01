using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace POSSystem
{
    public partial class FormProductosInactivos : Form
    {
        private bool seleccionado = true; // Cambiado a true
        private int rowIndexSelected = -1;

        public FormProductosInactivos()
        {
            InitializeComponent();
        }

        private void FormProductosInactivos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            BL_Producto blProducto = new BL_Producto();
            List<Producto> listaProductos = blProducto.ListarProductos("I"); // Asumiendo que existe un método ListarProductos que retorna una lista de productos

            dgvdata.Rows.Clear(); // Limpiar las filas existentes



            foreach (var producto in listaProductos)
            {
                // Convertir la cadena Base64 de la imagen a un objeto Image
                byte[] byteImage = Convert.FromBase64String(producto.Prod_Barras);
                System.Drawing.Image imagenCodigoBarras;
                using (MemoryStream memoryStream = new MemoryStream(byteImage))
                {
                    imagenCodigoBarras = System.Drawing.Image.FromStream(memoryStream);
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
                "$" + producto.Prod_PrecioCompra,
                "$" + producto.Prod_PrecioVenta,
                "$" + valorInventarioInicial,
                "$" + valorInventarioActual,
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
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                System.Drawing.Image icono = Properties.Resources.tick_symbol_icon15;

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
                txtId.Text = dgvdata.Rows[indice].Cells["Prod_CodigoBarras"].Value.ToString();
                seleccionado = true;
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // Verifica si la fila seleccionada ya coincide con la fila seleccionada anteriormente
                if (e.RowIndex == rowIndexSelected)
                {
                    // Si es así, deselecciona la fila y limpia los campos
                    txtId.Text = "Ninguno";
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
                        txtId.Text = "Ninguno";
                        dgvdata.InvalidateCell(0, rowIndexSelected);
                    }

                    // Actualiza rowIndexSelected y marca la fila como seleccionada
                    rowIndexSelected = e.RowIndex;
                    seleccionado = true;

                    // Verifica si rowIndexSelected es un índice de fila válido
                    if (rowIndexSelected >= 0 && rowIndexSelected < dgvdata.Rows.Count)
                    {
                        // Carga los datos de la fila seleccionada en los campos
                        CargarDatosFilaSeleccionada();

                        // Actualiza la apariencia de la celda del botón
                        dgvdata.InvalidateCell(0, e.RowIndex);
                    }
                    else
                    {
                        // Si rowIndexSelected no es válido, establece seleccionado a false
                        seleccionado = false;
                    }
                }

                // Pinta el ícono del tick en todas las demás celdas
                PintarIconoTickEnTodasLasCeldas();
            }
        }

        private void EliminarRegistro_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (rowIndexSelected >= 0 && rowIndexSelected < dgvdata.Rows.Count)
            {
                // Confirmar si el usuario desea eliminar el producto seleccionado
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar el producto seleccionado?", "Confirmación de eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Obtener el ID del producto a eliminar
                    string productoId = txtId.Text;

                    // Instanciar la lógica de negocio
                    BL_Producto blProducto = new BL_Producto();

                    // Tratar de eliminar el producto
                    bool resultado = blProducto.EliminarProducto(productoId);

                    // Verificar si el producto fue eliminado correctamente
                    if (resultado)
                    {
                        // Eliminar la fila correspondiente en el DataGridView
                        dgvdata.Rows.RemoveAt(rowIndexSelected);
                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos y deseleccionar la fila
                        txtId.Text = "Ninguno";
                        rowIndexSelected = -1;
                        seleccionado = false;
                    }
                    else
                    {
                        // Hubo un error al eliminar el producto
                        MessageBox.Show("Error al eliminar el producto con ID: " + productoId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay producto seleccionado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVaciarRegistros_Click(object sender, EventArgs e)
        {
            // Confirmar si el usuario desea vaciar todos los registros
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar todos los registros?", "Confirmación de eliminación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Instanciar la lógica de negocio
                BL_Producto blProducto = new BL_Producto();

                // Tratar de eliminar todos los registros
                bool resultado = blProducto.VaciarRegistros();

                // Verificar si los registros fueron eliminados correctamente
                if (resultado)
                {
                    // Limpiar el DataGridView
                    dgvdata.Rows.Clear();
                    MessageBox.Show("Todos los registros han sido eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Hubo un error al vaciar los registros
                    MessageBox.Show("Error al vaciar los registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }


}
