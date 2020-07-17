using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Bloques
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, numero_bloque, dia, hora_inicio, hora_fin, vigente, " +
                    "plantilla_id, tipo_bloque_id FROM bloque ORDER BY numero_bloque ASC";
            }
            else
            {
                sql = "SELECT id, numero_bloque, dia, hora_inicio, hora_fin, vigente, " +
                    "plantilla_id, tipo_bloque_id FROM bloque WHERE numero_bloque LIKE '%" + dato + "%' OR dia LIKE" +
                    " '%" + dato + "%' OR hora_inicio LIKE '%" + dato + "%' OR hora_fin LIKE '%" + dato + "%'" +
                    " OR vigente LIKE '%" + dato + "%' ORDER BY numero_bloque ASC";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Bloque _bloque = new Bloque();
                    _bloque.Id = int.Parse(reader.GetString(0));
                    _bloque.Numero_bloque = int.Parse(reader.GetString(1));
                    _bloque.Dia = int.Parse(reader.GetString(2));
                    _bloque.Hora_inicio = reader[3].ToString();
                    _bloque.Hora_fin = reader[4].ToString();
                    _bloque.Vigente = reader[5].ToString();
                    _bloque.Plantilla_id = int.Parse(reader.GetString(6));
                    _bloque.Tipo_bloque_id = int.Parse(reader.GetString(7));

                    lista.Add(_bloque);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }


        public bool insertar(Bloque datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO bloque (numero_bloque, dia, hora_inicio, hora_fin, vigente, plantilla_id, tipo_bloque_id)" +
                " VALUES ('" + datos.Numero_bloque + "', '" + datos.Dia + "', '" + datos.Hora_inicio + "', '" + datos.Hora_fin + "'," +
                " '" + '1' + "', '" + '2' + "', '" + '2' + "')";

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

        public bool actualizar(Bloque datos)
        {
            bool bandera = false;

            string sql = "UPDATE bloque SET numero_bloque='" + datos.Numero_bloque + "', dia='"
                + datos.Dia + "', hora_inicio='" + datos.Hora_inicio + "', hora_fin='" + datos.Hora_fin +
                 "', vigente='" + '1' + "', plantilla_id='" + '1' +
                "',  tipo_bloque_id='" + '1' + "' WHERE id='" + datos.Id + "'";

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

            string sql = "DELETE FROM bloque WHERE id='" + id + "'";

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
