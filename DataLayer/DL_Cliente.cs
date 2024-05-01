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
    public class DL_Cliente
    {

        public List<Cliente> ListarClientes()
        {
            // Se declara una lista llamada lista que contendrá objetos de tipo Usuario. Esta lista se utilizará para almacenar los usuarios recuperados de la base de datos.
            List<Cliente> lista = new List<Cliente>();

            // Se utiliza un bloque using para crear y abrir una conexión a la base de datos SQL Server. La cadena de conexión se obtiene de una clase llamada Conexion.
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se define una cadena de consulta SQL que selecciona ciertos campos de la tabla Usuarios.
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT C.Cli_Id, C.Cli_Nombres, C.Cli_Apellidos");
                    query.AppendLine("FROM Clientes C;");

                    // Se crea un objeto de tipo SqlCommand que representa una consulta SQL a ejecutar en la base de datos. Se pasa la consulta SQL y la conexión como parámetros al constructor del SqlCommand.
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);

                    // Se establece el tipo de comando como texto. Esto indica que la consulta es una cadena de texto SQL.
                    cmd.CommandType = CommandType.Text;

                    // Se abre la conexión a la base de datos.
                    conexion.Open();

                    // Se utiliza un bloque using para crear y leer un objeto SqlDataReader, que permite leer los resultados de la consulta SQL.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Se itera sobre cada fila del resultado de la consulta utilizando un bucle while. Dentro del bucle, se lee cada fila y se crea un nuevo objeto Usuario utilizando los valores de las columnas de la fila.
                        while (reader.Read())
                        {
                            // Se agrega el nuevo objeto Usuario a la lista lista.
                            lista.Add(new Cliente()
                            {
                                Cli_Id = Convert.ToInt32(reader["Cli_Id"]),
                                Cli_Nombres = reader["Cli_Nombres"].ToString(),
                                Cli_Apellidos = reader["Cli_Apellidos"].ToString(),
                            });
                            Console.WriteLine(lista);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si se produce una excepción, se asigna una nueva lista vacía a lista.
                    Console.WriteLine("Error al listar clientes: " + ex.Message);
                    lista = new List<Cliente>();
                    // Aquí puedes manejar la excepción de acuerdo a tu lógica de aplicación.
                }
            }

            // Se devuelve la lista lista, que contiene todos los usuarios recuperados de la base de datos.
            return lista;
        }
    }
}
