using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
    public static class FunGl
    {

        public static void App()
        {
            string opcion;
            do
            {
                ElTablero.CargarPosiciones();
                FunGl.VistaNormal();
                FunGl.MenuPrincipal();
                opcion = Console.ReadLine() ?? "";
                if (Program.misVar.Sonido) Console.Beep();

                OpcionesJuego.SeleccionOpcion(opcion);
            } while (opcion != "0");
        }
       
        public static void TurnoJugador()
        {
            if (Program.misVar.Turno)
                MostrarJuagador("Uno X");
            else
                MostrarJuagador("Dos O");
        }

        public static void MostrarJuagador(string jugador)
        {
            ColorGl.ColorJugador();
            Console.WriteLine(("\nTurno de jugador "+jugador).ToUpper());
        }

       

        public static void VistaNormal()
        {
            Console.Clear();
            Cartel.Tateti();
            MostrarPuntaje();
            ElTablero.Tablero();
        }




        public static void MenuPrincipal()
        {
            ColorGl.ConsolaLetraColorYellow();

            Console.WriteLine("\nIngrese una opcion segun su indice y oprima enter\n");

            ColorGl.ConsolaLetraColorWhite();
            Console.WriteLine("1- Jugar");
            Console.WriteLine("2- Resetear Puntajes");
            Console.WriteLine("3- Configuracion");


            Console.WriteLine("0- Salir");
        }

        public static string EleccionPosicion()
        {
            ColorGl.ConsolaLetraColorWhite();
            Console.WriteLine("\nElija la posicion del tablero disponible y oprima enter");
            ColorGl.ConsolaLetraColorYellow();
            Console.WriteLine("Presione 0 para Rendirse");
            return Console.ReadLine() ?? " ";
        }





        public static void MostrarPuntaje()
        {
            ColorGl.ConsolaLetraColorYellow();
            Console.WriteLine("\t\t\t\t   PUNTAJE");
            ColorGl.ConsolaLetraGreen();
            Console.Write("\t     \"Jugador Uno X\": "+Program.misVar.JugadorUno);
            ColorGl.ConsolaLetraCyan();
            Console.WriteLine("\t\t     \"Jugador Dos O\": "+Program.misVar.JugadorDos);
        }

        public static void PressTecla()
        {
            Console.WriteLine("\nPresiona una tecla para continuar");
            Console.ReadKey();
        }

       
    }
}
