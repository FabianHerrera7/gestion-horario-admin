using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Asignatura
    {
        private int id;
        private string codigo;
        private string nombre;
        private string color;
        private string sala_especial;
        private int bloques;
        private string vigente;
        private int sala_id;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Color { get => color; set => color = value; }
        public string Sala_especial { get => sala_especial; set => sala_especial = value; }
        public int Bloques { get => bloques; set => bloques = value; }
        public string Vigente { get => vigente; set => vigente = value; }
        public int Sala_id { get => sala_id; set => sala_id = value; }
    }
}
