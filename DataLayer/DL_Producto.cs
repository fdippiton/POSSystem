using EntityLayer;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using ZXing;

namespace DataLayer
{
    public class DL_Producto
    {
        public List<Producto> ListarProductos()
        {
            // Se declara una lista llamada lista que contendrá objetos de tipo Producto. Esta lista se utilizará para almacenar los productos recuperados de la base de datos.
            List<Producto> lista = new List<Producto>();

            // Se utiliza un bloque using para crear y abrir una conexión a la base de datos SQL Server. La cadena de conexión se obtiene de una clase llamada Conexion.
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se define una cadena de consulta SQL que selecciona ciertos campos de la tabla Productos.
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT P.Prod_Id, P.Prod_CodigoBarras, P.Prod_Barras, P.Prod_Nombre, P.Prod_Descripcion, P.Prod_Categoria_Id, P.Prod_Fecha, P.Prod_Categoria_Id, C.Cat_Id, C.Cat_Nombre");
                    query.AppendLine("FROM Productos P INNER JOIN Categorias C ON P.Prod_Categoria_Id = C.Cat_Id;");

                    // Se crea un objeto de tipo SqlCommand que representa una consulta SQL a ejecutar en la base de datos. Se pasa la consulta SQL y la conexión como parámetros al constructor del SqlCommand.
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);

                    // Se establece el tipo de comando como texto. Esto indica que la consulta es una cadena de texto SQL.
                    cmd.CommandType = CommandType.Text;

                    // Se abre la conexión a la base de datos.
                    conexion.Open();

                    // Se utiliza un bloque using para crear y leer un objeto SqlDataReader, que permite leer los resultados de la consulta SQL.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Se itera sobre cada fila del resultado de la consulta utilizando un bucle while. Dentro del bucle, se lee cada fila y se crea un nuevo objeto Producto utilizando los valores de las columnas de la fila.
                        while (reader.Read())
                        {
                            // Se agrega el nuevo objeto Producto a la lista lista.
                            lista.Add(new Producto()
                            {
                                Prod_Id = Convert.ToInt32(reader["Prod_Id"]),
                                Prod_CodigoBarras = reader["Prod_CodigoBarras"].ToString(),
                                Prod_Barras = reader["Prod_Barras"].ToString(),
                                Prod_Nombre = reader["Prod_Nombre"].ToString(),
                                Prod_Descripcion = reader["Prod_Descripcion"].ToString(),
                                oProd_Categoria_Id = new Categoria()
                                {
                                    Cat_Id = Convert.ToInt32(reader["Cat_Id"]),
                                    Cat_Nombre = reader["Cat_Nombre"].ToString()
                                },
                                Prod_Fecha = Convert.ToDateTime(reader["Prod_Fecha"])
                            });
                            Console.WriteLine(lista);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si se produce una excepción, se asigna una nueva lista vacía a lista.
                    Console.WriteLine("Error al listar productos: " + ex.Message);
                    lista = new List<Producto>();
                    // Aquí puedes manejar la excepción de acuerdo a tu lógica de aplicación.
                }
            }

            // Se devuelve la lista lista, que contiene todos los productos recuperados de la base de datos.
            return lista;
        }

        // Función para generar las barras del código de barras
        private string GenerarBarrasCodigo(string numeroACodificar)
        {

            // Crear un objeto BarcodeWriter
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128, // Tipo de código de barras a generar
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300, // Ancho del código de barras
                    Height = 100 // Altura del código de barras
                }
            };

            // Generar el código de barras como un bitmap
            Bitmap bitmap = writer.Write(numeroACodificar);

            // Convertir el bitmap a una cadena Base64
            string base64String;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, ImageFormat.Png);
                byte[] byteImage = memoryStream.ToArray();
                base64String = Convert.ToBase64String(byteImage);
            }

            // Devolver la cadena Base64
            return base64String;
        }

        private string GenerarNumeroAleatorio()
        {
            // Crear un objeto Random
            Random random = new Random();

            // Definir los caracteres que se pueden utilizar en el número aleatorio
            const string caracteres = "0123456789";

            // Crear una cadena para almacenar el número aleatorio
            StringBuilder numeroAleatorio = new StringBuilder();

            // Generar el número aleatorio de 15 caracteres
            for (int i = 0; i < 15; i++)
            {
                // Seleccionar un carácter aleatorio de la lista de caracteres
                char caracter = caracteres[random.Next(caracteres.Length)];

                // Agregar el carácter a la cadena del número aleatorio
                numeroAleatorio.Append(caracter);
            }

            // Devolver el número aleatorio generado
            return numeroAleatorio.ToString();
        }


        public bool CrearProducto(Producto producto)
        {
            string numeroAleatorio = GenerarNumeroAleatorio();
            // Variable para indicar si la creación del producto fue exitosa
            bool creadoExitosamente = false;

            // Se utiliza un bloque using para crear y abrir una conexión a la base de datos SQL Server. La cadena de conexión se obtiene de una clase llamada Conexion.
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Generar el código de barras para el producto
                    string codigoBarras = GenerarBarrasCodigo(numeroAleatorio);

                    // Convertir la imagen del código de barras a una cadena Base64
                    // string imagenBase64 = GenerarBarrasCodigo(numeroAleatorio);

                    // Se define una cadena de consulta SQL para insertar un nuevo producto en la tabla Productos.
                    string query = "INSERT INTO Productos (Prod_CodigoBarras, Prod_Barras, Prod_Nombre, Prod_Descripcion, Prod_Categoria_Id) VALUES (@CodigoBarras, @Barras, @Nombre, @Descripcion, @CategoriaId)";

                    // Se crea un objeto de tipo SqlCommand que representa una consulta SQL a ejecutar en la base de datos. Se pasa la consulta SQL y la conexión como parámetros al constructor del SqlCommand.
                    SqlCommand cmd = new SqlCommand(query, conexion);

                    // Se establece el tipo de comando como texto. Esto indica que la consulta es una cadena de texto SQL.
                    cmd.CommandType = CommandType.Text;

                    // Se agregan los parámetros a la consulta SQL para evitar la inyección de SQL y establecer los valores del producto.
                    cmd.Parameters.AddWithValue("@CodigoBarras", numeroAleatorio);
                    cmd.Parameters.AddWithValue("@Barras", codigoBarras); // Se utiliza el número aleatorio como código de barras
                    cmd.Parameters.AddWithValue("@Nombre", producto.Prod_Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Prod_Descripcion);
                    cmd.Parameters.AddWithValue("@CategoriaId", producto.oProd_Categoria_Id.Cat_Id);
                    // cmd.Parameters.AddWithValue("@Itbis", producto.Prod_Itbis);
                    // cmd.Parameters.AddWithValue("@Imagen", imagenBase64); // Se agrega la imagen del código de barras como cadena Base64

                    // Se abre la conexión a la base de datos.
                    conexion.Open();

                    // Se ejecuta la consulta SQL para insertar el nuevo producto.
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    // Si se insertó al menos una fila en la base de datos, se considera que la creación del producto fue exitosa.
                    creadoExitosamente = filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    // Si se produce una excepción, se muestra un mensaje de error.
                    Console.WriteLine("Error al crear producto: " + ex.Message);
                    // Aquí puedes manejar la excepción de acuerdo a tu lógica de aplicación.
                }
            }

            // Se devuelve un valor booleano que indica si la creación del producto fue exitosa.
            return creadoExitosamente;
        }

        public bool EditarProducto(Producto producto)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Productos");
                    query.AppendLine("SET Prod_Nombre = @Prod_Nombre,");
                    query.AppendLine("    Prod_Descripcion = @Prod_Descripcion,");
                    query.AppendLine("    Prod_Categoria_Id = @Prod_Categoria_Id");
                    query.AppendLine("WHERE Prod_Id = @Prod_Id;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Prod_Nombre", producto.Prod_Nombre);
                    cmd.Parameters.AddWithValue("@Prod_Descripcion", producto.Prod_Descripcion);
                    cmd.Parameters.AddWithValue("@Prod_Categoria_Id", producto.oProd_Categoria_Id.Cat_Id);
                    cmd.Parameters.AddWithValue("@Prod_Id", producto.Prod_Id);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        resultado = true;
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al editar el producto: " + ex.Message);
                    resultado = false;
                }
            }
            return resultado;
        }


        public bool EliminarProducto(int productoId)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM Productos");
                    query.AppendLine("WHERE Prod_Id = @Prod_Id;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Prod_Id", productoId);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        resultado = true;
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al eliminar el producto: " + ex.Message);
                    resultado = false;
                }
            }
            return resultado;
        }

    }
}
