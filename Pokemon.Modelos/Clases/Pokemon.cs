using Pokemon.Modelos.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Modelos.Clases
{
    public class Pokemon
    {
        public int NumeroEnPokedex { get; set; }
        public string Nombre { get; set; }
        public string Naturaleza { get; set; }
        public Tipo[] Tipos { get; set; }
        public string Habilidad { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
    }
}
