using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DL_Categoria
    {

        public List<Categoria> ListarCategorias()
        {
            // Se declara una lista que contendrá objetos de tipo Categoria.
            List<Categoria> lista = new List<Categoria>();

            // Se utiliza un bloque using para crear y abrir una conexión a la base de datos MySQL.
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se define una cadena de consulta SQL que selecciona todos los campos de la tabla Categorias.
                    string query = "SELECT Cat_Id, Cat_Nombre, Cat_Estatus FROM Categorias";

                    // Se crea un objeto de tipo MySqlCommand que representa la consulta SQL.
                    SqlCommand cmd = new SqlCommand(query, oconexion);

                    // Se abre la conexión a la base de datos.
                    oconexion.Open();

                    // Se crea y lee un objeto MySqlDataReader para leer los resultados de la consulta.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Se itera sobre cada fila del resultado de la consulta.
                        while (reader.Read())
                        {
                            // Se crea un nuevo objeto Categoria y se agrega a la lista.
                            lista.Add(new Categoria()
                            {
                                Cat_Id = Convert.ToInt32(reader["Cat_Id"]),
                                Cat_Nombre = reader["Cat_Nombre"].ToString(),
                                Cat_Estatus = reader["Cat_Estatus"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // En caso de excepción, se puede manejar el error o devolver una lista vacía.
                    Console.WriteLine("Error al listar las categorías: " + ex.Message);
                    lista = new List<Categoria>(); // Asignar una lista vacía en caso de error.
                }
            }

            // Devuelve la lista de categorías recuperadas de la base de datos.
            return lista;
        }

        public bool CrearCategoria(Categoria categoria)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"INSERT INTO Categorias (Cat_Nombre, Cat_Estatus)
                             VALUES (@Cat_Nombre, @Cat_Estatus);";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Cat_Nombre", categoria.Cat_Nombre);
                    cmd.Parameters.AddWithValue("@Cat_Estatus", categoria.Cat_Estatus);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    resultado = filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al crear la categoría: " + ex.Message);
                    resultado = false;
                }
            }
            return resultado;
        }


        public bool EditarCategoria(Categoria categoria)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"UPDATE Categorias SET Cat_Nombre = @Cat_Nombre, Cat_Estatus = @Cat_Estatus
                             WHERE Cat_Id = @Cat_Id;";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Cat_Id", categoria.Cat_Id);
                    cmd.Parameters.AddWithValue("@Cat_Nombre", categoria.Cat_Nombre);
                    cmd.Parameters.AddWithValue("@Cat_Estatus", categoria.Cat_Estatus);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    resultado = filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al editar la categoría: " + ex.Message);
                    resultado = false;
                }
            }
            return resultado;
        }


        public bool EliminarCategoria(int catId)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"DELETE FROM Categorias WHERE Cat_Id = @Cat_Id;";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Cat_Id", catId);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    resultado = filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar la categoría: " + ex.Message);
                    resultado = false;
                }
            }
            return resultado;
        }
    }
}
