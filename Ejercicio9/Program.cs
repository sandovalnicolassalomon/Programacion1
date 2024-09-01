using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Ejercicio9
{
    static class Program
    {

        /// <summary>
        /// instancia de struct para usar como datos del juego
        /// </summary>
        /// 
        public static MisVar misVar = new MisVar()
        {
            Fails = 0,
            PuntoJugadorUno = 0,
            PutnoJugadorDos = 0,
            RelojUno = new Stopwatch(),
            RelojDos = new Stopwatch(),
            Jagadas = 0,
            Turno = true,
            Tema = true,
            Ganador = false,
            Sonido = false,
            ArchivoHistorial = "historial.txt",
            NRandom = new Random()
        };

        // esto es um comentario
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
         
            FunGl.App();
            PFunAccesoArchivo.CerrarTxt();

        }

       


    

    }
}
