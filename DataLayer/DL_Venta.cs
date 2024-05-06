using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DL_Venta
    {
        public bool GenerarVenta(Venta venta, List<DetalleVenta> detallesVenta)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlTransaction transaction = null;

                try
                {
                    conexion.Open();
                    transaction = conexion.BeginTransaction();

                    // Insertar la venta
                    int ventaId = InsertarVenta(conexion, transaction, venta);

                    // Si se insertó correctamente la venta
                    if (ventaId != -1)
                    {
                        // Insertar los detalles de la venta
                        foreach (var detalle in detallesVenta)
                        {
                            InsertarDetalleVenta(conexion, transaction, ventaId, detalle);
                            ActualizarStockProducto(conexion, transaction, detalle.DetV_Producto_CodigoBarras.Prod_CodigoBarras, detalle.DetV_Cantidad);
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                        resultado = true;
                    }
                    else
                    {
                        // Si hubo un problema al insertar la venta, hacer rollback de la transacción
                        transaction.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al generar la venta: " + ex.Message);
                    resultado = false;

                    // Si ocurrió un error, asegúrate de hacer rollback de la transacción
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                }
                finally
                {
                    // Cerrar la conexión
                    if (conexion.State != ConnectionState.Closed)
                    {
                        conexion.Close();
                    }
                }
            }
            return resultado;
        }

        private int InsertarVenta(SqlConnection conexion, SqlTransaction transaction, Venta venta)
        {
            int ventaId = -1;
            StringBuilder queryVenta = new StringBuilder();
            queryVenta.AppendLine("INSERT INTO Ventas (Ven_Cliente_Id, Ven_Usuario_Id, Ven_Fecha, Ven_TotalItbis, Ven_MontoTotal, Ven_Estatus)");
            queryVenta.AppendLine("VALUES (@Ven_Cliente_Id, @Ven_Usuario_Id, @Ven_Fecha, @Ven_TotalItbis, @Ven_MontoTotal, 'A');");
            queryVenta.AppendLine("SELECT SCOPE_IDENTITY();");

            SqlCommand cmdVenta = new SqlCommand(queryVenta.ToString(), conexion, transaction);
            cmdVenta.Parameters.AddWithValue("@Ven_Cliente_Id", venta.Ven_Cliente_Id.Cli_Id);
            cmdVenta.Parameters.AddWithValue("@Ven_Usuario_Id", venta.Ven_Usuario_Id);
            cmdVenta.Parameters.AddWithValue("@Ven_Fecha", venta.Ven_Fecha);
            cmdVenta.Parameters.AddWithValue("@Ven_TotalItbis", venta.Ven_TotalItbis);
            cmdVenta.Parameters.AddWithValue("@Ven_MontoTotal", venta.Ven_MontoTotal);

            // Ejecutar el comando y obtener el ID de la venta recién creada
            object result = cmdVenta.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                ventaId = Convert.ToInt32(result);
            }

            return ventaId;
        }

        private void InsertarDetalleVenta(SqlConnection conexion, SqlTransaction transaction, int ventaId, DetalleVenta detalle)
        {
            StringBuilder queryDetalle = new StringBuilder();
            queryDetalle.AppendLine("INSERT INTO DetallesVenta (DetV_Venta_Id,  DetV_Producto_CodigoBarras, DetV_Cantidad, DetV_Subtotal, DetV_Itbis, DetV_Total, DetV_Estatus)");
            queryDetalle.AppendLine("VALUES (@DetV_Venta_Id, @DetV_Producto_CodigoBarras, @DetV_Cantidad, @DetV_Subtotal, @DetV_Itbis, @DetV_Total, 'A');");

            SqlCommand cmdDetalle = new SqlCommand(queryDetalle.ToString(), conexion, transaction);
            cmdDetalle.Parameters.AddWithValue("@DetV_Venta_Id", ventaId);
            cmdDetalle.Parameters.AddWithValue("@DetV_Producto_CodigoBarras", detalle.DetV_Producto_CodigoBarras.Prod_CodigoBarras);
            cmdDetalle.Parameters.AddWithValue("@DetV_Cantidad", detalle.DetV_Cantidad);
            cmdDetalle.Parameters.AddWithValue("@DetV_Subtotal", detalle.DetV_Subtotal);
            cmdDetalle.Parameters.AddWithValue("@DetV_Itbis", detalle.DetV_Itbis);
            cmdDetalle.Parameters.AddWithValue("@DetV_Total", detalle.DetV_Total);

            cmdDetalle.ExecuteNonQuery();
        }


        private void ActualizarStockProducto(SqlConnection conexion, SqlTransaction transaction, string codigoBarrasProducto, int cantidadVendida)
        {
            // Actualizar el stock actual del producto
            StringBuilder queryActualizarStock = new StringBuilder();
            queryActualizarStock.AppendLine("UPDATE Productos SET Prod_StockActual = Prod_StockActual - @CantidadVendida WHERE Prod_CodigoBarras = @CodigoBarrasProducto;");
            SqlCommand cmdActualizarStock = new SqlCommand(queryActualizarStock.ToString(), conexion, transaction);
            cmdActualizarStock.Parameters.AddWithValue("@CantidadVendida", cantidadVendida);
            cmdActualizarStock.Parameters.AddWithValue("@CodigoBarrasProducto", codigoBarrasProducto);
            cmdActualizarStock.ExecuteNonQuery();

            // Consultar el nuevo stock actual del producto después de la venta
            SqlCommand cmdConsultaStock = new SqlCommand("SELECT Prod_StockActual FROM Productos WHERE Prod_CodigoBarras = @CodigoBarrasProducto;", conexion, transaction);
            cmdConsultaStock.Parameters.AddWithValue("@CodigoBarrasProducto", codigoBarrasProducto);
            int stockActual = Convert.ToInt32(cmdConsultaStock.ExecuteScalar());

            // Actualizar el estado del producto según el stock actual
            string nuevoEstatus = stockActual <= 0 ? "I" : "A";
            StringBuilder queryActualizarEstatus = new StringBuilder();
            queryActualizarEstatus.AppendLine("UPDATE Productos SET Prod_Estatus = @NuevoEstatus WHERE Prod_CodigoBarras = @CodigoBarrasProducto;");
            SqlCommand cmdActualizarEstatus = new SqlCommand(queryActualizarEstatus.ToString(), conexion, transaction);
            cmdActualizarEstatus.Parameters.AddWithValue("@NuevoEstatus", nuevoEstatus);
            cmdActualizarEstatus.Parameters.AddWithValue("@CodigoBarrasProducto", codigoBarrasProducto);
            cmdActualizarEstatus.ExecuteNonQuery();
        }


    }
}
