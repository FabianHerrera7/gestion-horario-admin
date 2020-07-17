using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Periodo
    {

        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, ano_escolar, colegio_id FROM periodo ORDER BY ano_escolar ASC";
            }
            else
            {
                sql = "SELECT id, ano_escolar, colegio_id FROM periodo WHERE ano_escolar LIKE '%" + dato + "%' OR colegio_id LIKE '%" + dato + "%' ORDER BY ano_escolar ASC";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Periodo _periodo = new Periodo();
                    _periodo.Id = int.Parse(reader.GetString(0));
                    _periodo.Ano_escolar = int.Parse(reader.GetString(1));
                    _periodo.Colegio_id = int.Parse(reader.GetString(2));

                    lista.Add(_periodo);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(Periodo datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO periodo (ano_escolar, colegio_id)" +
                " VALUES ('" + datos.Ano_escolar + "', '" + '1' + "')";


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

        public bool actualizar(Periodo datos)
        {
            bool bandera = false;

            string sql = "UPDATE periodo SET ano_escolar='" + datos.Ano_escolar + "', colegio_id='" + '1' + "' WHERE id='" + datos.Id + "'";

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

            string sql = "DELETE FROM periodo WHERE id='" + id + "'";

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
