using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class ModeloUsuario
    {

       
        public int registro(Usuario usuario)
        {
            

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO usuario (alias, password, email, vigente, rol_id) VALUES (@alias, @password, @email, 1, 1)";
            //string sql = "INSERT INTO usuario (alias, password, email, vigente, rol_id) VALUES (@alias, @password, @email, 1, @rol_id)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@alias", usuario.Alias);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@email", usuario.Email);
            comando.Parameters.AddWithValue("@rol_id", usuario.Rol_id);


            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public bool existeusuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id FROM usuario WHERE alias = @alias";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@alias", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        public Usuario porusuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id, alias, password, email, rol_id FROM usuario WHERE alias = @alias";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@alias", usuario);

            reader = comando.ExecuteReader();

            Usuario usr = null;

            while (reader.Read())
            {
                usr = new Usuario();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Email = reader["email"].ToString();
                usr.Rol_id = int.Parse(reader["rol_id"].ToString());
            }
            return usr;


        }
        
    }
}

