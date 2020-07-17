using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Bloque
    {
        private int id;
        private int numero_bloque;
        private int dia;
        private string hora_inicio;
        private string hora_fin;
        private string vigente;
        private int plantilla_id;
        private int tipo_bloque_id;

        public int Id { get => id; set => id = value; }
        public int Numero_bloque { get => numero_bloque; set => numero_bloque = value; }
        public int Dia { get => dia; set => dia = value; }
        public string Hora_inicio { get => hora_inicio; set => hora_inicio = value; }
        public string Hora_fin { get => hora_fin; set => hora_fin = value; }
        public string Vigente { get => vigente; set => vigente = value; }
        public int Plantilla_id { get => plantilla_id; set => plantilla_id = value; }
        public int Tipo_bloque_id { get => tipo_bloque_id; set => tipo_bloque_id = value; }
    }
}
