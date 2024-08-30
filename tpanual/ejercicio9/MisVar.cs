using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    public  class MisVar
    {
        public  int Fails { get; set; } = 0;
        public  int JugadorUno { get; set; } = 0;
        public int JugadorDos { get; set; } = 0;
        public  bool Turno { get; set; } = true;
        public int Jagadas { get; set; } = 0;
        public  bool Ganador { get; set; } = false;
        public bool Sonido { get; set; } = false;
        public bool Tema { get; set; } = true;

        public string ArchivoHistorial { get; set; } = "historial.txt";

    }
}
