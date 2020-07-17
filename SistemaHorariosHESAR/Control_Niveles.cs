using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Niveles
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, codigo, descripcion, nivel_mueve_sala, requier_co_educadora FROM nivel ORDER BY descripcion ASC";
            }
            else
            {
                sql = "SELECT id, codigo, descripcion, nivel_mueve_sala, requier_co_educadora FROM nivel WHERE codigo LIKE '%" + dato + "%' OR descripcion LIKE '%" + dato + "%' OR nivel_mueve_sala LIKE '%" + dato + "%' OR requier_co_educadora LIKE '%" + dato + "%' ORDER BY descripcion ASC";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Nivel _nivel = new Nivel();
                    _nivel.Id = int.Parse(reader.GetString(0));
                    _nivel.Codigo = reader[1].ToString();
                    _nivel.Descripcion= reader[2].ToString();
                    _nivel.Nivel_mueve_sala= reader[3].ToString();
                    _nivel.Requier_co_educadora=reader[4].ToString();



                    lista.Add(_nivel);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(Nivel datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO nivel (codigo, descripcion, nivel_mueve_sala, requier_co_educadora)" +
                " VALUES ('" + datos.Codigo + "', '" + datos.Descripcion + "', '" + '1' + "', '" + '1' + "')";


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

        public bool actualizar(Nivel datos)
        {
            bool bandera = false;

            string sql = "UPDATE nivel SET codigo='" + datos.Codigo + "', descripcion='"
                + datos.Descripcion + "', nivel_mueve_sala='" + '1' + "', requier_co_educadora='" + '1' + "' WHERE id='" + datos.Id + "'";

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

            string sql = "DELETE FROM nivel WHERE id='" + id + "'";

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
