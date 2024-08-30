using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
    public struct MisVar
    {
        public int Fails { get; set; }
        public int JugadorUno { get; set; }
        public int JugadorDos { get; set; }
        public bool Turno { get; set; }
        public int Jagadas { get; set; }
        public bool Ganador { get; set; }
        public bool Sonido { get; set; }
        public bool Tema { get; set; }
        public Random Random { get; set; }

        public string ArchivoHistorial { get; set; }

    }
}
