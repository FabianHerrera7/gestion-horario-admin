using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Curso
    {
        private int id;
        private string codigo;
        private Nivel nivel { get; set; }
        //private int nivel_id;
        private int plantilla_id;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        //public int Nivel_id { get => nivel_id; set => nivel_id = value; }
        public int Plantilla_id { get => plantilla_id; set => plantilla_id = value; }

        public string codigoCurso
        {
            get
            {
                return nivel.Codigo + codigo;
            }
        }

    }
}
