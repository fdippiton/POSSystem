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
        public int UsuarioId { get; set; }
        private bool seleccionado = true; // Cambiado a true
        private int rowIndexSelected = -1;


        public FormVentas()
        {
            InitializeComponent();
        }


        private void FormVentas_Load(object sender, EventArgs e)
        {

            /* The above C# code is adding items to a ComboBox control named `cboItbis`. Two items are
            being added, each represented by an instance of the `OpcionCombo` class. The first item has
            a value of 0 and a text of "No aplicar ITBIS", while the second item has a value of 0.18
            and a text of "Aplicar ITBIS". This code is likely setting up options for the user to
            select whether or not to apply ITBIS (Impuesto sobre la Transferencia de Bienes
            Industrializados y Servicios, */
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


            // Listar los clientes en el dropdown
            List<Cliente> listaClientes = new BL_Cliente().ListarClientes();
            foreach (Cliente item in listaClientes)
            {
                cboCliente.Items.Add(new OpcionCombo()
                {
                    Valor = item.Cli_Id,
                    Texto = item.Cli_Nombres + " "+ item.Cli_Apellidos
                }) ;

            }
            cboCliente.DisplayMember = "Texto";
            cboCliente.ValueMember = "Valor";
            cboCliente.SelectedIndex = 0;

            boxTotalPagar.Enabled = false;
            boxTotalItbis.Enabled = false;
            boxCambio.Enabled = false;

        }


        /// This C# function searches for a product by its barcode and returns the found product.
        private Producto BuscarProductoPorCodigoBarras(string codigoBarras)
        {
            BL_Producto blProducto = new BL_Producto();
            Producto productoEncontrado = blProducto.BuscarProducto(codigoBarras);

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
            boxCambio.Clear();
            boxPagarCon.Clear();
        }



        /// The function btnBuscarCodProducto_Click searches for a product by barcode, displays its information
        /// if found, and clears the fields if not found.
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
                MessageBox.Show("Producto no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
                codigoBarras = null;
            }
        }

        /** The function `btnAñadir_Click` adds a product to a DataGridView with validation checks for
        various input fields.**/
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(boxCodProducto.Text))
            {
                MessageBox.Show("El código de producto está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(boxProducto.Text))
            {
                MessageBox.Show("El campo de producto está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(boxPrecio.Text))
            {
                MessageBox.Show("El campo de precio está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(boxStockActual.Text))
            {
                MessageBox.Show("No hay stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (boxCantidad.Text == "0")
            {
                MessageBox.Show("El campo de cantidad está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(boxCantidad.Text) > Convert.ToInt32(boxStockActual.Text))
            {
                MessageBox.Show("No hay stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            decimal total = (precio * (cantidadExistente + cantidad)) + nuevoItbis;
                            decimal subtotal = (cantidadExistente + cantidad) * precio;
                            row.Cells["Prod_Itbis"].Value = Math.Round(nuevoItbis, 2);
                            row.Cells["Prod_Total"].Value = Math.Round(total, 2);
                            row.Cells["Prod_Subtotal"].Value = Math.Round(subtotal, 2);
                            ActualizarTotales();
                        }
                        else
                        {
                            MessageBox.Show("Agregar esta cantidad supera el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                }

                if (!productoEncontrado)
                {
                    decimal itbis = precio * cantidad * tasaItbis;
                    decimal total = (precio * cantidad) + itbis;
                    decimal subtotal = cantidad * precio;

                    dgvdata.Rows.Add(new object[] {
                    "",
                    codigoProducto,
                    boxProducto.Text,
                    cantidad,
                    precio.ToString(),
                    Math.Round(subtotal, 2),
                    Math.Round(itbis, 2),
                    Math.Round(total, 2)
            });
                    ActualizarTotales();
                }
                LimpiarCampos();
            }
        }


    /// The function `ActualizarTotales` calculates and updates the total ITBIS and total amount to pay
    /// based on the values in a DataGridView.
        private void ActualizarTotales()
        {
            decimal totalItbis = 0;
            decimal totalAPagar = 0;
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                totalItbis += Convert.ToDecimal(row.Cells["Prod_Itbis"].Value.ToString());
                totalAPagar += Convert.ToDecimal(row.Cells["Prod_Total"].Value.ToString());
            }
            boxTotalItbis.Text = Math.Round(totalItbis, 2).ToString();
            boxTotalPagar.Text = Math.Round(totalAPagar, 2).ToString();
        }

        /// This C# function removes a row from a DataGridView when a cell is clicked and updates total values
        /// displayed in text boxes.
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
                    totalAPagar += Convert.ToDecimal(row.Cells["Prod_Total"].Value.ToString());
                }

                boxTotalItbis.Text = Math.Round(totalItbis, 2).ToString();
                boxTotalPagar.Text = Math.Round(totalAPagar, 2).ToString();
            }
        }

        /// The function dgvdata_CellPainting in C# is used to paint a recycle bin icon in the specified cell
        /// of a DataGridView.
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


        /// The function calculates the change to be given back based on the amount paid and the total amount
        /// to be paid.
        private void btnTotalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(boxPagarCon.Text))
            {
                MessageBox.Show("El campo pagar con esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (string.IsNullOrWhiteSpace(boxTotalPagar.Text))
            {
                MessageBox.Show("No tiene productos en detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                decimal pagarCon = Convert.ToDecimal(boxPagarCon.Text);
                decimal cambio = pagarCon - Convert.ToDecimal(boxTotalPagar.Text);
                boxCambio.Text = Math.Round(cambio, 2).ToString();

            }
        }


        /// The function `btnGenerarVenta_Click` generates a sale by collecting details of the products
        /// sold and creating a sale object with associated client and user information.
        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            BL_Venta bl_Venta = new BL_Venta();
            // Crear una lista de detalles de venta
            List<DetalleVenta> detallesVenta = new List<DetalleVenta>();

            // Aquí debes llenar la lista de detalles de venta con los productos vendidos. 
            // Puedes obtener esta información de algún control de tu formulario, como un DataGridView o una lista de productos seleccionados.

            // Ejemplo de cómo podrías llenar la lista de detalles de venta desde un DataGridView:
            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                // Obtener los valores de la fila del DataGridView
                string productoCodigo = fila.Cells["Prod_CodigoBarras"].Value.ToString();
                string Producto = fila.Cells["Prod_Nombre"].Value.ToString();
                int cantidad = Convert.ToInt32(fila.Cells["Prod_Cantidad"].Value);
                decimal precioVenta = Convert.ToDecimal(fila.Cells["Prod_PrecioVenta"].Value);
                decimal subtotal = Convert.ToDecimal(fila.Cells["Prod_Subtotal"].Value) ;
                decimal itbis = Convert.ToDecimal(fila.Cells["Prod_Itbis"].Value);
                decimal total = Convert.ToDecimal(fila.Cells["Prod_Total"].Value);

                // Crear un objeto DetalleVenta y agregarlo a la lista
                DetalleVenta detalle = new DetalleVenta
                {
                    DetV_Producto_CodigoBarras = new Producto { Prod_CodigoBarras = productoCodigo },
                    DetV_Cantidad = cantidad,
                    DetV_Subtotal = subtotal,
                    DetV_Itbis = itbis,
                    DetV_Total = total,
                };
                detallesVenta.Add(detalle);
            }

            Venta venta = new Venta
            {
                Ven_Fecha = dateTimePicker.Value,
                Ven_Cliente_Id = new Cliente { Cli_Id = Convert.ToInt32(((OpcionCombo)cboCliente.SelectedItem).Valor) },
                Ven_Usuario_Id = UsuarioId,
                Ven_TotalItbis = Convert.ToDecimal(boxTotalItbis.Text),
                Ven_MontoTotal = Convert.ToDecimal(boxTotalPagar.Text),
            };

            if (string.IsNullOrWhiteSpace(boxTotalItbis.Text))
            {
                MessageBox.Show("El campo total Itbis esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(boxTotalPagar.Text))
            {
                MessageBox.Show("El campo total a pagar esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(boxPagarCon.Text))
            {
                MessageBox.Show("El campo pagar con esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool resultado = bl_Venta.GenerarVenta(venta, detallesVenta);

                // Verificar si el usuario fue agregado correctamente
                if (resultado)
                {
                    MessageBox.Show("Venta generada correctamente.", "Información");
                    dgvdata.Rows.Clear();
                    boxTotalItbis.Text = "";
                    boxTotalPagar.Text = "";
                    LimpiarCampos();
                }
                else
                {
                    // Hubo un error al crear el usuario
                    MessageBox.Show("Error al generar venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
