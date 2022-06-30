using Pokemon.Modelos.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Modelos.Clases
{
    public class Movimiento
    {
        public string Nombre { get; set; }
        public string Clase { get; set; }
        public string Concurso { get; set; }
        public string Generacion { get; set; }
        public string Ingles { get; set; }
        public int Potencia { get; set; }
        public Tipo Tipo { get; set; }
    }
}
