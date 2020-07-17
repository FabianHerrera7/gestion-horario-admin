using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Colegios
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, codigo, nombre, vigente, usuario_id FROM colegio ORDER BY nombre ASC";
            }
            else
            {
                sql = "SELECT id, codigo, nombre, vigente, usuario_id FROM colegio WHERE codigo LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' OR color LIKE '%" + dato + "%' OR vigente LIKE '%" + dato + "%' OR usuario_id LIKE '%" + dato + "%'  ORDER BY nombre ASC";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Colegio _colegio = new Colegio();
                    _colegio.Id = int.Parse(reader.GetString(0));
                    _colegio.Codigo = reader[1].ToString();
                    _colegio.Nombre = reader[2].ToString();
                    _colegio.Vigente = reader[3].ToString();
                    _colegio.Usuario_id = int.Parse(reader.GetString(4));


                    lista.Add(_colegio);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(Colegio datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO colegio (codigo, nombre, vigente, usuario_id)" +
                " VALUES ('" + datos.Codigo + "', '" + datos.Nombre + "', '" + '1' + "', '" + '1' + "')";


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
        public bool actualizar(Colegio datos)
        {
            bool bandera = false;

            string sql = "UPDATE colegio SET codigo='" + datos.Codigo + "', nombre='"
                + datos.Nombre + "', vigente='" + '1' + "', usuario_id='" + '1' + "' WHERE id='" + datos.Id + "'";

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

            string sql = "DELETE FROM colegio WHERE id='" + id + "'";

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
