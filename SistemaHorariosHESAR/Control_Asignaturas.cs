using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Asignaturas
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, codigo, nombre, color, sala_especial, bloques, vigente, sala_id FROM asignatura ORDER BY nombre ASC";
            }
            else
            {
                sql = "SELECT id, codigo, nombre, color, sala_especial, bloques, vigente, sala_id FROM asignatura WHERE codigo LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' OR color LIKE '%" + dato + "%' OR sala_especial LIKE '%" + dato + "%' OR bloques LIKE '%" + dato + "%' OR vigente LIKE '%" + dato + "%' OR nivel_id LIKE '%" + dato + "%'  ORDER BY nombre ASC";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Asignatura _asignatura = new Asignatura();
                    _asignatura.Id = int.Parse(reader.GetString(0));
                    _asignatura.Codigo = reader[1].ToString();
                    _asignatura.Nombre = reader[2].ToString();
                    _asignatura.Color = reader[3].ToString();
                    _asignatura.Sala_especial = reader[4].ToString();
                    _asignatura.Bloques = int.Parse(reader.GetString(5));
                    _asignatura.Vigente = reader[6].ToString();
                    //_asignatura.Sala_id = int.Parse(reader.GetString(7));


                    lista.Add(_asignatura);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }


        public bool insertar(Asignatura datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO asignatura (codigo, nombre, color, sala_especial, bloques, vigente)" +
                " VALUES ('" + datos.Codigo + "', '" + datos.Nombre + "', '" + datos.Color + "', '" + datos.Sala_especial + "'," +
                " '" + datos.Bloques + "', '" + '1' + "')";


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


        public bool actualizar(Asignatura datos)
        {
            bool bandera = false;

            string sql = "UPDATE asignatura SET codigo='" + datos.Codigo + "', nombre='"
                + datos.Nombre + "', color='" + datos.Color + "', sala_especial='" + datos.Sala_especial +
                "', bloques='" + datos.Bloques + "', vigente='" + '1' + "', sala_id='" + '1' + "' WHERE id='" + datos.Id + "'";

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

            string sql = "DELETE FROM asignatura WHERE id='" + id + "'";

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
