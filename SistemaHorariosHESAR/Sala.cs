using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Sala
    {
        private int id;
        private int numero;
        private string ubicacion;
        private string vigente;
        private int sede_id;

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Vigente { get => vigente; set => vigente = value; }
        public int Sede_id { get => sede_id; set => sede_id = value; }
    }
}
