using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Salas
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, numero, ubicacion, vigente, sede_id FROM sala ORDER BY ubicacion ASC";
            }
            else
            {
                sql = "SELECT id, numero, ubicacion, vigente, sede_id FROM sala WHERE numero LIKE '%" + dato + "%' OR ubicacion LIKE '%" + dato + "%' OR vigente LIKE '%" + dato + "%' OR sede_id LIKE '%" + dato + "%' ORDER BY ubicacion ASC";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Sala _sala = new Sala();
                    _sala.Id = int.Parse(reader.GetString(0));
                    _sala.Numero = int.Parse(reader.GetString(1));
                    _sala.Ubicacion = reader[2].ToString();
                    _sala.Vigente = reader[3].ToString();
                    _sala.Sede_id = int.Parse(reader.GetString(4));



                    lista.Add(_sala);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }


        public bool insertar(Sala datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO sala (numero, ubicacion, vigente, sede_id)" +
                " VALUES ('" + datos.Numero + "', '" + datos.Ubicacion + "', '" + '1' + "', '" + '1' + "')";


            try
            {


                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;

            }
            return bandera;
        }

        public bool actualizar(Sala datos)
        {
            bool bandera = false;

            string sql = "UPDATE sala SET numero='" + datos.Numero + "', ubicacion='"
                + datos.Ubicacion + "', vigente='" + '1' + "', sede_id='" + '1' + "' WHERE id='" + datos.Id + "'";

            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;

            }
            return bandera;
        }

        public bool eliminar(int id)
        {
            bool bandera = false;

            string sql = "DELETE FROM sala WHERE id='" + id + "'";

            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;

            }
            return bandera;
        }
    }
}
