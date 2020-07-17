using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "184.175.93.196";
            string puerto = "3306";
            string usuario = "consulta_gestion_horario";
            string password = "q#khKRu*U5.z";
            string bd = "consulta_gestion_horario";

            string cadenaconexion = "server=" + servidor + "; port=" + puerto + "; user id =" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaconexion);

            return conexion;


        }
    }
}

