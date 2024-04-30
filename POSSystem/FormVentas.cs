using BusinessLayer;
using EntityLayer;
using POSSystem.Utilidades;
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
    public partial class FormVentas : Form
    {
        private bool seleccionado = true; // Cambiado a true
        private int rowIndexSelected = -1;

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

            cboItbis.Items.Add(new OpcionCombo()
            {
                Valor = 0,
                Texto = "No aplicar ITBIS"
            });
            cboItbis.Items.Add(new OpcionCombo()
            {
                Valor = 0.18,
                Texto = "Aplicar ITBIS"
            });

            cboItbis.DisplayMember = "Texto"; // muestre el texto de los elementos en lugar de cualquier otro valor. En este caso, mostrará el texto definido en la propiedad Texto de la clase OpcionCombo.
            cboItbis.ValueMember = "Valor"; // Establece la propiedad ValueMember del ComboBox cboestatus para que el valor seleccionado sea el valor definido en la propiedad Valor de la clase OpcionCombo.
            cboItbis.SelectedIndex = 0;

        }

        private Producto BuscarProductoPorCodigoBarras(string codigoBarras)
        {
            BL_Producto blProducto = new BL_Producto();
            Producto productoEncontrado = blProducto.BuscarProducto(codigoBarras);

            // Convertir los valores numéricos
            //int valorInventarioInicial = producto.Prod_StockInicial * producto.Prod_PrecioCompra;
            //int valorInventarioActual = producto.Prod_StockActual * producto.Prod_PrecioCompra;


            // Agregar las demás celdas a la fila
            //dgvdata.Rows.Add(new object[] {
            //    "", // Esto representa la primera columna (si hay una columna para el ID, por ejemplo)
            //    productoEncontrado.Prod_Id,
            //    producto.Prod_CodigoBarras,
            //    producto.Prod_Barras,
            //    producto.Prod_Nombre,
            //    producto.oProd_Categoria_Id.Cat_Id,
            //    producto.oProd_Categoria_Id.Cat_Nombre, // Asumiendo que el objeto Categoria tiene una propiedad Cat_Id
            //    producto.Prod_Descripcion,
            //    producto.Prod_StockInicial,
            //    producto.Prod_StockActual,
            //    "$" + producto.Prod_PrecioCompra,
            //    "$" + producto.Prod_PrecioVenta,
            //    "$" + valorInventarioInicial,
            //    "$" + valorInventarioActual,
            //    producto.Prod_Fecha.ToString("d")
            //    });

            //int rowIndex = dgvdata.Rows.Count - 1;

            return productoEncontrado;
        }

        private void LimpiarCampos()
        {
            boxCodProducto.Clear();
            boxProducto.Clear();
            boxPrecio.Clear();
            boxStockActual.Clear();
            boxStockActual.Clear();
            boxCantidad.Value = 0;
        }

        private void btnBuscarCodProducto_Click(object sender, EventArgs e)
        {
            string codigoBarras = boxCodProducto.Text;

            Producto producto = BuscarProductoPorCodigoBarras(codigoBarras);

            if (producto != null)
            {
                boxProducto.Text = producto.Prod_Nombre;
                boxPrecio.Text = producto.Prod_PrecioVenta.ToString();
                boxStockActual.Text = producto.Prod_StockActual.ToString();
                dateTimePicker.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                codigoBarras = null;
            }

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(boxCodProducto.Text))
            {
                MessageBox.Show("El código de producto está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(boxProducto.Text))
            {
                MessageBox.Show("El campo de producto está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(boxPrecio.Text))
            {
                MessageBox.Show("El campo de precio está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(boxStockActual.Text))
            {
                MessageBox.Show("No hay stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (boxCantidad.Text == "0")
            {
                MessageBox.Show("El campo de cantidad está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(boxCantidad.Text) > Convert.ToInt32(boxStockActual.Text))
            {
                MessageBox.Show("No hay stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string codigoProducto = boxCodProducto.Text;
                int cantidad = Convert.ToInt32(boxCantidad.Text);
                decimal precio = Convert.ToDecimal(boxPrecio.Text);
                decimal tasaItbis = Convert.ToDecimal(((OpcionCombo)cboItbis.SelectedItem).Valor.ToString());
                bool productoEncontrado = false;

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells["Prod_CodigoBarras"].Value.ToString() == codigoProducto)
                    {
                        productoEncontrado = true;
                        int cantidadExistente = Convert.ToInt32(row.Cells["Prod_Cantidad"].Value);
                        if (cantidadExistente + cantidad <= Convert.ToInt32(boxStockActual.Text))
                        {
                            row.Cells["Prod_Cantidad"].Value = cantidadExistente + cantidad;
                            decimal nuevoItbis = precio * (cantidadExistente + cantidad) * tasaItbis;
                            decimal nuevoSubtotal = (precio * (cantidadExistente + cantidad)) + nuevoItbis;
                            row.Cells["Prod_Itbis"].Value = nuevoItbis;
                            row.Cells["Prod_Subtotal"].Value = nuevoSubtotal;
                            ActualizarTotales();
                        }
                        else
                        {
                            MessageBox.Show("Agregar esta cantidad supera el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                }

                if (!productoEncontrado)
                {
                    decimal itbis = precio * cantidad * tasaItbis;
                    decimal subtotal = (precio * cantidad) + itbis;
                    dgvdata.Rows.Add(new object[] {
                "",
                codigoProducto,
                boxProducto.Text,
                cantidad,
                "$" + precio.ToString("N2"),
                itbis,
                subtotal
            });
                    ActualizarTotales();
                }

                LimpiarCampos();
            }
        }

        private void ActualizarTotales()
        {
            decimal totalItbis = 0;
            decimal totalAPagar = 0;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                totalItbis += Convert.ToDecimal(row.Cells["Prod_Itbis"].Value.ToString());
                totalAPagar += Convert.ToDecimal(row.Cells["Prod_Subtotal"].Value.ToString());
            }
            boxTotalItbis.Text = totalItbis.ToString();
            boxTotalPagar.Text = totalAPagar.ToString();
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                int indice = rowIndexSelected;

                // Eliminar la fila donde se hizo clic
                dgvdata.Rows.RemoveAt(e.RowIndex);

                decimal totalItbis = 0;
                decimal totalAPagar = 0;
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    totalItbis += Convert.ToDecimal(row.Cells["Prod_Itbis"].Value.ToString());
                    totalAPagar += Convert.ToDecimal(row.Cells["Prod_Subtotal"].Value.ToString());
                }

                boxTotalItbis.Text = totalItbis.ToString();
                boxTotalPagar.Text = totalAPagar.ToString();


            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All); // Pinta todas las partes de la celda

                System.Drawing.Image icono = Properties.Resources.recycle_bin_icon; // Ícono de reciclaje

                // Calcula las coordenadas para el ícono centrado
                var w = icono.Width;
                var h = icono.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                // Dibuja el ícono
                e.Graphics.DrawImage(icono, new Rectangle(x, y, w, h));
                e.Handled = true; // Indica que el evento de pintado ha sido manejado
            }
        }
    }
}
