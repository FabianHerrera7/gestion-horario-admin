using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Nivel
    {
        private int id;
        private string codigo;
        private string descripcion;
        private string nivel_mueve_sala;
        private string requier_co_educadora;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nivel_mueve_sala { get => nivel_mueve_sala; set => nivel_mueve_sala = value; }
        public string Requier_co_educadora { get => requier_co_educadora; set => requier_co_educadora = value; }
    }
}
