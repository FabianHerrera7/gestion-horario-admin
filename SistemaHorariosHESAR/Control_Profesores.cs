    using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Control_Profesores
    {

        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT id, rut, nombre, apellido_paterno, apellido_materno, fecha_nacimiento, vigente, horas_contrato, " +
                    "horas_aula_maxima, horas_aula_efectiva FROM profesor ORDER BY nombre ASC";
            }
            else
            {
                sql = "SELECT id, rut, nombre, apellido_paterno, apellido_materno, fecha_nacimiento, vigente, horas_contrato, " +
                    "horas_aula_maxima, horas_aula_efectiva FROM profesor WHERE rut LIKE '%" + dato + "%' OR nombre LIKE" +
                    " '%" + dato + "%' OR apellido_paterno LIKE '%" + dato + "%' OR apellido_materno LIKE '%" + dato + "%'" +
                    " OR fecha_nacimiento LIKE '%" + dato + "%' OR vigente LIKE '%" + dato + "%' OR horas_contrato LIKE '%" + dato + "%' OR horas_aula_maxima LIKE '%"
                    + dato + "%' OR horas_aula_efectiva LIKE '%" + dato + "%' ORDER BY nombre ASC";

            }
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Profesor _profesor = new Profesor();
                    _profesor.Id = int.Parse(reader.GetString(0));
                    _profesor.Rut = reader[1].ToString();
                    _profesor.Nombre = reader[2].ToString();
                    _profesor.Apellido_paterno = reader[3].ToString();
                    _profesor.Apellido_materno = reader[4].ToString();
                    _profesor.Fecha_nacimiento = reader[5].ToString();
                    _profesor.Vigente = reader[6].ToString();
                    _profesor.Horas_contrato = reader[7].ToString();
                    _profesor.Horas_aula_maxima = reader[8].ToString();
                    _profesor.Horas_aula_efectiva = reader[9].ToString();



                    lista.Add(_profesor);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
        public bool insertar(Profesor datos)
        {
            bool bandera = false;

            string sql = "INSERT INTO profesor (rut, nombre, apellido_paterno, apellido_materno," +
                " fecha_nacimiento, vigente, horas_contrato, horas_aula_maxima, horas_aula_efectiva)" +
                " VALUES ('" + datos.Rut + "', '" + datos.Nombre + "', '" + datos.Apellido_paterno + "', '" + datos.Apellido_materno + "'," +
                " '" + datos.Fecha_nacimiento + "', '" + '1' + "', '" + datos.Horas_contrato + "', '" + datos.Horas_aula_maxima + "', '" + datos.Horas_aula_efectiva +"')";

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

        public bool actualizar(Profesor datos)
        {
            bool bandera = false;

            string sql = "UPDATE profesor SET rut='" + datos.Rut + "', nombre='"
                + datos.Nombre + "', apellido_paterno='" + datos.Apellido_paterno + "', apellido_materno='" + datos.Apellido_materno +
                 "', fecha_nacimiento='" + datos.Fecha_nacimiento + "',  horas_contrato='" + datos.Horas_contrato + "', horas_aula_maxima='" + datos.Horas_aula_maxima + "', horas_aula_efectiva='" + datos.Horas_aula_efectiva + "' WHERE id='" + datos.Id + "'";

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

            string sql = "DELETE FROM profesor WHERE id='" + id + "'";

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
