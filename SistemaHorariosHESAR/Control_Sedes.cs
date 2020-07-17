using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Sedes
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, codigo, direccion, vigente, colegio_id FROM sede ORDER BY direccion ASC";
            }
            else
            {
                sql = "SELECT id, codigo, direccion, vigente, colegio_id FROM sede WHERE codigo LIKE '%" + dato + "%' OR direccion LIKE '%" + dato + "%' OR vigente LIKE '%" + dato + "%' OR colegio_id LIKE '%" + dato + "%' ORDER BY direccion ASC";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Sede _sede = new Sede();
                    _sede.Id = int.Parse(reader.GetString(0));
                    _sede.Codigo = reader.GetString(1);
                    _sede.Direccion = reader[2].ToString();
                    _sede.Vigente = reader[3].ToString();
                    _sede.Colegio_id = int.Parse(reader.GetString(4));

                    lista.Add(_sede);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }


        public bool insertar(Sede datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO sede (codigo, direccion, vigente, colegio_id)" +
                " VALUES ('" + datos.Codigo + "', '" + datos.Direccion + "', '" + '1' + "', '" + '1' + "')";


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

        public bool actualizar(Sede datos)
        {
            bool bandera = false;

            string sql = "UPDATE sede SET codigo='" + datos.Codigo + "', direccion='"
                + datos.Direccion + "', vigente='" + '1' + "', colegio_id='" + '1' + "' WHERE id='" + datos.Id + "'";

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

            string sql = "DELETE FROM sede WHERE id='" + id + "'";

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
