using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DL_Usuario
    {
        // Devuelve una lista de objetos de tipo Usuario y no acepta ningún parámetro.
        public List<Usuario> ListarUsuarios()
        {
            // Se declara una lista llamada lista que contendrá objetos de tipo Usuario. Esta lista se utilizará para almacenar los usuarios recuperados de la base de datos.
            List<Usuario> lista = new List<Usuario>();

            // Se utiliza un bloque using para crear y abrir una conexión a la base de datos SQL Server. La cadena de conexión se obtiene de una clase llamada Conexion.
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se define una cadena de consulta SQL que selecciona ciertos campos de la tabla Usuarios.
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT U.Usu_Id, U.Usu_Documento, U.Usu_NombreCompleto, U.Usu_Correo, U.Usu_Contrasena, U.Usu_Estatus, R.Rol_Id, R.Rol_Descripcion");
                    query.AppendLine("FROM Usuarios U INNER JOIN Roles R ON R.Rol_Id = U.Usu_Rol_Id;");

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
                            lista.Add(new Usuario()
                            {
                                Usu_Id = Convert.ToInt32(reader["Usu_Id"]),
                                Usu_Documento = reader["Usu_Documento"].ToString(),
                                Usu_NombreCompleto = reader["Usu_NombreCompleto"].ToString(),
                                Usu_Correo = reader["Usu_Correo"].ToString(),
                                Usu_Contrasena = reader["Usu_Contrasena"].ToString(),
                                Usu_Estatus = reader["Usu_Estatus"].ToString(),
                                oRol_Id = new Rol()
                                {
                                    Rol_Id = Convert.ToInt32(reader["Rol_Id"]),
                                    Rol_Descripcion = reader["Rol_Descripcion"].ToString()
                                }
                            });
                            Console.WriteLine(lista);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si se produce una excepción, se asigna una nueva lista vacía a lista.
                    Console.WriteLine("Error al listar usuarios: " + ex.Message);
                    lista = new List<Usuario>();
                    // Aquí puedes manejar la excepción de acuerdo a tu lógica de aplicación.
                }
            }

            // Se devuelve la lista lista, que contiene todos los usuarios recuperados de la base de datos.
            return lista;
        }


        public bool VerificarDocumentoExistente(string documento)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usu_Documento = @Documento";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Documento", documento);

                try
                {
                    conexion.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al verificar el documento existente: " + ex.Message);
                    return true; // Devolver true en caso de error para evitar la inserción accidental
                }
            }
        }


        public bool CrearUsuario(Usuario usuario)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("INSERT INTO Usuarios (Usu_Rol_Id, Usu_Documento, Usu_NombreCompleto, Usu_Correo, Usu_Contrasena, Usu_Estatus)");
                    query.AppendLine("VALUES (@Usu_Rol_Id, @Usu_Documento, @Usu_NombreCompleto, @Usu_Correo, @Usu_Contrasena, @Usu_Estatus);");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Usu_Rol_Id", usuario.oRol_Id.Rol_Id);
                    cmd.Parameters.AddWithValue("@Usu_Documento", usuario.Usu_Documento);
                    cmd.Parameters.AddWithValue("@Usu_NombreCompleto", usuario.Usu_NombreCompleto);
                    cmd.Parameters.AddWithValue("@Usu_Correo", usuario.Usu_Correo);
                    cmd.Parameters.AddWithValue("@Usu_Contrasena", usuario.Usu_Contrasena);
                    cmd.Parameters.AddWithValue("@Usu_Estatus", usuario.Usu_Estatus);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        resultado = true;
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al crear el usuario: " + ex.Message);
                    resultado = false;
                }
            }
            return resultado;
        }



        public bool EditarUsuario(Usuario usuario)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Usuarios");
                    query.AppendLine("SET Usu_Rol_Id = @Usu_Rol_Id,");
                    query.AppendLine("    Usu_Documento = @Usu_Documento,");
                    query.AppendLine("    Usu_NombreCompleto = @Usu_NombreCompleto,");
                    query.AppendLine("    Usu_Correo = @Usu_Correo,");
                    query.AppendLine("    Usu_Contrasena = @Usu_Contrasena,");
                    query.AppendLine("    Usu_Estatus = @Usu_Estatus");
                    query.AppendLine("WHERE Usu_Id = @Usu_Id;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Usu_Rol_Id", usuario.oRol_Id.Rol_Id);
                    cmd.Parameters.AddWithValue("@Usu_Documento", usuario.Usu_Documento);
                    cmd.Parameters.AddWithValue("@Usu_NombreCompleto", usuario.Usu_NombreCompleto);
                    cmd.Parameters.AddWithValue("@Usu_Correo", usuario.Usu_Correo);
                    cmd.Parameters.AddWithValue("@Usu_Contrasena", usuario.Usu_Contrasena);
                    cmd.Parameters.AddWithValue("@Usu_Estatus", usuario.Usu_Estatus);
                    cmd.Parameters.AddWithValue("@Usu_Id", usuario.Usu_Id);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        resultado = true;
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al editar el usuario: " + ex.Message);
                    resultado = false;
                }
            }
            return resultado;
        }



        public bool EliminarUsuario(int usuarioId)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM Usuarios");
                    query.AppendLine("WHERE Usu_Id = @Usu_Id;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Usu_Id", usuarioId);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        resultado = true;
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al eliminar el usuario: " + ex.Message);
                    resultado = false;
                }
            }
            return resultado;
        }

    }
}
