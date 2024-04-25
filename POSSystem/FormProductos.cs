﻿using BusinessLayer;
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

            CargarDatos();
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
            textId.Text = "0";
            boxNombre.Text = "";
            boxDescripcion.Text = "";
        }

        private void CargarDatos()
        {
            BL_Producto blProducto = new BL_Producto();
            List<Producto> listaProductos = blProducto.ListarProductos(); // Asumiendo que existe un método ListarProductos que retorna una lista de productos

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

                // Agregar las demás celdas a la fila
                dgvdata.Rows.Add(new object[] {
                "", // Esto representa la primera columna (si hay una columna para el ID, por ejemplo)
                producto.Prod_Id,
                producto.Prod_CodigoBarras,
                producto.Prod_Barras,
                producto.Prod_Nombre,
                producto.oProd_Categoria_Id.Cat_Nombre, // Asumiendo que el objeto Categoria tiene una propiedad Cat_Id
                producto.Prod_Descripcion,
                producto.Prod_Fecha
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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(boxNombre.Text) ||
                string.IsNullOrWhiteSpace(boxDescripcion.Text) ||
                cboCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return; // Detener la ejecución adicional si alguno de los campos está vacío
            }

            // Crear el objeto producto con los datos del formulario
            Producto nuevoProducto = new Producto
            {
                Prod_Nombre = boxNombre.Text,
                Prod_Descripcion = boxDescripcion.Text,
                oProd_Categoria_Id = new Categoria { Cat_Id = Convert.ToInt32(((OpcionCombo)cboCategoria.SelectedItem).Valor) },
                // Prod_Itbis = Convert.ToInt32(boxItbis.Text), // Asumiendo que Prod_Itbis es un int
            };

            // Instanciar la lógica de negocio y tratar de agregar el producto
            BL_Producto blProducto = new BL_Producto();

            bool resultado = blProducto.CrearProducto(nuevoProducto);

            // Verificar si el producto fue agregado correctamente
            if (resultado)
            {
                // Producto creado correctamente, actualizar el DataGridView
                //dgvdata.Rows.Add(new object[] { "",
                //nuevoProducto.Prod_Id,
                //nuevoProducto.Prod_CodigoBarras,
                //nuevoProducto.Prod_Barras,
                //nuevoProducto.Prod_Nombre,
                //((OpcionCombo) cboCategoria.SelectedItem).Valor.ToString(),
                //nuevoProducto.Prod_Descripcion
              
                //nuevoProducto.Prod_Fecha
      

                MessageBox.Show("Producto creado correctamente.");
                CargarDatos();
                Limpiar();
            }
            else
            {
                // Hubo un error al crear el producto
                MessageBox.Show("Error al crear el producto.");
            }

            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
