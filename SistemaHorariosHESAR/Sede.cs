using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Sede
    {
        private int id;     
        private string codigo;
        private string direccion;
        private string vigente;
        private int colegio_id;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Vigente { get => vigente; set => vigente = value; }
        public int Colegio_id { get => colegio_id; set => colegio_id = value; }
    }
}
