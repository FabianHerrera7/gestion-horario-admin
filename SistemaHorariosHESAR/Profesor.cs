using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorariosHESAR
{
    class Profesor
    {
        private int id;
        private string rut;
        private string nombre;
        private string apellido_paterno;
        private string apellido_materno;
        private string fecha_nacimiento;
        private string horas_contrato;
        //private int horas_aula_maxima;
        //private int horas_aula_efectiva;
        private string vigente;
        //private DateTime horas_contrato;
        private string horas_aula_maxima;
        private string horas_aula_efectiva;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Vigente { get => vigente; set => vigente = value; }
        public string Horas_contrato { get => horas_contrato; set => horas_contrato = value; }
        public string  Horas_aula_maxima { get => horas_aula_maxima; set => horas_aula_maxima = value; }
        public string Horas_aula_efectiva { get => horas_aula_efectiva; set => horas_aula_efectiva = value; }
        //public DateTime Horas_contrato { get => horas_contrato; set => horas_contrato = value; }
        //public DateTime Horas_aula_maxima { get => horas_aula_maxima; set => horas_aula_maxima = value; }
        //public DateTime Horas_aula_efectiva { get => horas_aula_efectiva; set => horas_aula_efectiva = value; }
    }
}
