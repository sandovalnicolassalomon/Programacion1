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

        public static void SeleccionPuntaje()
        {
            switch (Program.misVar.Jagadas)
            {
                case 5:    // puntos 6
                    SeleccionJugadorPuntaje(6);
                    break;
                case 6:     // puntos 5
                    SeleccionJugadorPuntaje(5);
                    break;
                case 7:     // puntos 4
                    SeleccionJugadorPuntaje(4);
                    break;
                case 8:     // puntos 3
                    SeleccionJugadorPuntaje(3);
                    break;
                case 9:     // puntos 2
                    SeleccionJugadorPuntaje(2);
                    break;
            }
        }

        public static void SeleccionJugadorPuntaje(int puntaje)
        {
            if (!Program.misVar.Turno)
            {
                Program.misVar.PuntoJugadorUno += puntaje;
            }
            else
            {
                Program.misVar.PutnoJugadorDos += puntaje;
            }
        }

        
public static void PuntajeTiempo()
{
    if (Program.misVar.RelojUno.ElapsedMilliseconds < Program.misVar.RelojDos.ElapsedMilliseconds && Program.misVar.Turno)
    {
        Program.misVar.PuntoJugadorUno++;
    }
    
   
}
					
       
        public static void TurnoJugador()
        {
            if (Program.misVar.Turno)
            {
                MostrarJuagador("Uno X");
                Program.misVar.RelojDos.Stop();
                Program.misVar.RelojUno.Start();
            }
            else
            {
                MostrarJuagador("Dos O");
                Program.misVar.RelojUno.Stop();
                Program.misVar.RelojDos.Start();
            }
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
            Console.Write("\t     \"Jugador Uno X\": "+Program.misVar.PuntoJugadorUno);
            ColorGl.ConsolaLetraCyan();
            Console.WriteLine("\t\t     \"Jugador Dos O\": "+Program.misVar.PutnoJugadorDos);
        }

        public static void PressTecla()
        {
            Console.WriteLine("\nPresiona una tecla para continuar");
            Console.ReadKey();
        }

       
    }
}
