using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Cursos
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                //sql = "SELECT id, codigo, nivel_id, plantilla_id FROM curso";

                sql = "SELECT c.id, c.codigo, c.plantilla_id, n.id as id_nivel, n.codigo, " +
                    "n.descripcion, n.nivel_mueve_sala, n.requier_co_educadora " +
                    "FROM CURSO C INNER JOIN NIVEL N ON N.ID = C.NIVEL_ID, N ON N.CODIGO = C.CODIGO";

                
            }
            else
            {
                sql = "SELECT id, codigo, nivel_id, plantilla_id FROM curso WHERE codigo LIKE '%" + dato + "%' OR nivel_id LIKE '%" + dato + "%' OR plantilla_id LIKE '%" + dato + "%' ORDER BY codigo ASC";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                   
                    Curso _curso = new Curso();
                    _curso.Id = int.Parse(reader.GetString(0));
                    _curso.Codigo = reader[1].ToString();
                    //_curso.Nivel_id = int.Parse(reader.GetString(2));
                    _curso.Plantilla_id= int.Parse(reader.GetString(2));
                    

                    Nivel _nivel = new Nivel();
                    _nivel.Id = int.Parse(reader.GetString(3));
                    _nivel.Codigo = reader[4].ToString();
                    _nivel.Descripcion = reader[5].ToString();
                    _nivel.Nivel_mueve_sala= reader[6].ToString();
                    _nivel.Requier_co_educadora= reader[7].ToString();

                    


                    lista.Add(_curso);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public bool insertar(Curso datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO curso (codigo, nivel_id, plantilla_id)" +
                " VALUES ('" + datos.Codigo + "', '" + '1' + "', '" + '1' + "')";


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

        public bool actualizar(Curso datos)
        {
            bool bandera = false;

            string sql = "UPDATE curso SET codigo='" + datos.Codigo + "', nivel_id='"
                + datos.Nivel_id + "', plantilla_id='" + datos.Plantilla_id + "' WHERE id='" + datos.Id + "'";

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

            string sql = "DELETE FROM curso WHERE id='" + id + "'";

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
