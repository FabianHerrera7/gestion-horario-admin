using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Periodo
    {
        private int id;
        private int ano_escolar;
        private int colegio_id;

        public int Id { get => id; set => id = value; }
        public int Ano_escolar { get => ano_escolar; set => ano_escolar = value; }
        public int Colegio_id { get => colegio_id; set => colegio_id = value; }
    }
}
