using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Usuario
    {
        int id, rol_id;
        string alias, password, conpassword, email;


        public int Id { get => id; set => id = value; }
        public string Alias { get => alias; set => alias = value; }
        public string Password { get => password; set => password = value; }
        public string Conpassword { get => conpassword; set => conpassword = value; }
        public string Email { get => email; set => email = value; }
        public int Rol_id { get => rol_id; set => rol_id = value; }

    }
}
