using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Tipodebloque
    {

        private int id;
        private string codigo;
        private string descripcion;
        private string vigente;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Vigente { get => vigente; set => vigente = value; }
    }
}
