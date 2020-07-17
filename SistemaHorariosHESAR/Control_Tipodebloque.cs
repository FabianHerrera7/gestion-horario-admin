using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Tipodebloque
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, codigo, descripcion, vigente FROM tipo_bloque ORDER BY codigo ASC";
            }
            else
            {
                sql = "SELECT id, codigo, descripcion, vigente FROM tipo_bloque WHERE codigo LIKE '%" + dato + "%' OR descripcion LIKE '%" + dato + "%' OR vigente LIKE '%" + dato + "%' ORDER BY codigo ASC";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Tipodebloque _tb = new Tipodebloque();
                    _tb.Id = int.Parse(reader.GetString(0));
                    _tb.Codigo = reader[1].ToString();
                    _tb.Descripcion = reader[2].ToString();
                    _tb.Vigente = reader[3].ToString();

                    lista.Add(_tb);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(Tipodebloque datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO tipo_bloque (codigo, descripcion, vigente)" +
                " VALUES ('" + datos.Codigo + "', '" + datos.Descripcion + "', '" + '1' + "')";


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

        public bool actualizar(Tipodebloque datos)
        {
            bool bandera = false;

            string sql = "UPDATE tipo_bloque SET codigo='" + datos.Codigo + "', descripcion='"
                + datos.Descripcion + "', vigente='" + '1' + "' WHERE id='" + datos.Id + "'";

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

            string sql = "DELETE FROM tipo_bloque WHERE id='" + id + "'";

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
