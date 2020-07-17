using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Colegio
    {
        private int id;
        private string codigo;
        private string nombre;
        private string vigente;
        private int usuario_id;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Vigente { get => vigente; set => vigente = value; }
        public int Usuario_id { get => usuario_id; set => usuario_id = value; }
    }
}
