using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Ejercicio9
{
    public struct MisVar
    {
        public int Fails { get; set; }
        public int PuntoJugadorUno { get; set; }
        public int PutnoJugadorDos { get; set; }
        public Stopwatch RelojUno { get; set; }
        public Stopwatch RelojDos { get; set; }

        public bool Turno { get; set; }
        public int Jagadas { get; set; }
        public bool Ganador { get; set; }
        public bool Sonido { get; set; }
        public bool Tema { get; set; }
        public Random NRandom { get; set; }

        public string ArchivoHistorial { get; set; }

    }
}
