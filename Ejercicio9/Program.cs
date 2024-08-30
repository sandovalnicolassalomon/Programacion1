using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
    static class Program
    {


        /// <summary>
        /// instancia de la structura para usar de datos rapidos
        /// </summary>
        /// 
        public static MisVar misVar = new MisVar()
        {
            Fails = 0,
            JugadorUno = 0,
            JugadorDos = 0,
            Jagadas = 0,
            Turno = true,
            Tema = true,
            Ganador = false,
            Sonido = false,
            ArchivoHistorial = "historial.txt"
        };
        // esto es um momentario
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            FunGl.App();
            PFunAccesoArchivo.CerrarTxt();

        }

    

    }
}
