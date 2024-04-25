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
    public class DL_Permiso
    {
        public List<Permiso> ListarPermisos(int idUsuario)
        {

            // Se declara una lista llamada lista que contendrá objetos de tipo Usuario. Esta lista se utilizará para almacenar los usuarios recuperados de la base de datos.
            List<Permiso> lista = new List<Permiso>();

            // Se utiliza un bloque using para crear y abrir una conexión a la base de datos MySQL. La cadena de conexión se obtiene de una clase llamada Conexion.
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Para que el query se pueda poner en varias lineas
                    // StringBuilder query = new StringBuilder();
                    // query.AppendLine("select p.Per_Id, p.Per_Rol_Id, p.Per_Nombre, p.Per_Estatus from Permisos p");
                    // query.AppendLine("inner join Roles r on r.Rol_Id = p.Per_Rol_Id");
                    // query.AppendLine("inner join Usuarios u on u.Usu_Rol_Id = r.Rol_Id");
                    // query.AppendLine("where u.Usu_Id = @idusuario");

                    string query = "select p.Per_Id, p.Per_Rol_Id, p.Per_Nombre, p.Per_Estatus from Permisos p inner join Roles r on r.Rol_Id = p.Per_Rol_Id inner join Usuarios u on u.Usu_Rol_Id = r.Rol_Id where u.Usu_Id = @idusuario";


                    // Se crea un objeto de tipo MySqlCommand que representa una consulta SQL a ejecutar en la base de datos. Se pasa la consulta SQL y la conexión como parámetros al constructor del MySqlCommand
                    SqlCommand cmd = new SqlCommand(query, oconexion);

                    cmd.Parameters.AddWithValue("@idusuario", idUsuario); // Se le pasa el idUsuario

                    // Se establece el tipo de comando como texto. Esto indica que la consulta es una cadena de texto SQL.
                    cmd.CommandType = CommandType.Text;

                    // Se abre la conexión a la base de datos.
                    oconexion.Open();

                    // Se utiliza un bloque using para crear y leer un objeto MySqlDataReader, que permite leer los resultados de la consulta SQL.
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Se itera sobre cada fila del resultado de la consulta utilizando un bucle while. Dentro del bucle, se lee cada fila y se crea un nuevo objeto Usuario utilizando los valores de las columnas de la fila.
                        while (reader.Read())
                        {
                            // Se agrega el nuevo objeto Usuario a la lista lista.
                            lista.Add(new Permiso()
                            {
                                Per_Id = Convert.ToInt32(reader["Per_Id"]),
                                oRol_Id = new Rol() { Rol_Id = Convert.ToInt32(reader["Per_Rol_Id"]) },
                                Per_Nombre = reader["Per_Nombre"].ToString(),
                                Per_Estatus = reader["Per_Estatus"].ToString(),
                            });
                        }

                    }
                }
                catch (Exception ex)
                {
                    // Si se produce una excepción, se asigna una nueva lista vacía a lista.
                    lista = new List<Permiso>();
                }
            }

            // Se devuelve la lista lista, que contiene todos los usuarios recuperados de la base de datos.
            return lista;
        }
    }
}
