using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DASA
{

    public class personaDAL
    {
        public static int AgregarPersona(Persona persona)
        {
            int retorna = 0;
            using (SqlConnection conn = BDGeneral.ObtenerConexion())
            {
                String query = "insert into productos (id, nombre, tipo, marca, precio, stock) values('" + persona.id + "','" + persona.nombre + "','" + persona.tipo + "','" + persona.marca + "','" + persona.precio + "','" + persona.stock + "')";
                SqlCommand comando = new SqlCommand(query, conn);

                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Persona> PresentarRegistro()
        {
            List<Persona> lista = new List<Persona>();
            using (SqlConnection conn = BDGeneral.ObtenerConexion())
            {
                string query = "select * from productos";
                SqlCommand comando = new SqlCommand(query, conn);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.id = reader.GetInt32(0);
                    persona.nombre = reader.GetString(1);
                    persona.tipo = reader.GetString(2);
                    persona.marca = reader.GetString(3);
                    persona.precio = reader.GetDecimal(4);
                    persona.stock = reader.GetInt32(5);
                    lista.Add(persona);
                }
                conn.Close();
                return lista;
            }

        }

        public static int modificarPersona(Persona persona)
        {
            int result = 0;
            using (SqlConnection conn = BDGeneral.ObtenerConexion())
            {
                string query = "update productos set nombre ='" + persona.nombre + "',tipo='" + persona.tipo + "',marca='" + persona.marca + "',precio='" + persona.precio + "' where id= " + persona.id + "";
                SqlCommand comando = new SqlCommand(query, conn);

                result = comando.ExecuteNonQuery();
                conn.Close();
            }
            return result;
        }

        public static int EliminarPersona(int id )
        {
            int retorna = 0;
            using (SqlConnection conn = BDGeneral.ObtenerConexion())
            {
                String query = "delete from productos where id= "+id+"";
                SqlCommand comando = new SqlCommand(query, conn);

                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }
    }
}
