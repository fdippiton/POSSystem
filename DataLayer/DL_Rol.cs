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
    public class DL_Rol
    {
        public List<Rol> ListarRoles()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT Rol_Id, Rol_Descripcion FROM Roles";

                    SqlCommand cmd = new SqlCommand(query, conexion);

                    cmd.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Rol()
                            {
                                Rol_Id = Convert.ToInt32(reader["Rol_Id"]),
                                Rol_Descripcion = reader["Rol_Descripcion"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Aquí podrías manejar la excepción si necesitas hacer algo específico
                    lista = new List<Rol>();
                }
            }

            return lista;
        }

    }
}
