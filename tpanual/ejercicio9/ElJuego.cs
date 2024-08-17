using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio9
{
    public static class ElJuego
    {
        public static void Juego()
        {
            do
            {
                FunGl.VistaNormal();
                FunGl.TurnoJugador();

                string eleccion = FunGl.EleccionPosicion();
                Console.Beep();
                if (eleccion == "0")
                {
                    Console.Clear();
                    Cartel.Tateti();
                    TeRendiste();
                    ElGanador.MiGanador();
                    Cartel.Ganador();
                    ElTablero.TableroGanador();
                    FunGl.PressTecla();
                    return;
                }

                bool marca = OpcionesJuego.MarcarPosicion(eleccion);

                if (marca && Var.jagadas > 4) { Var.ganador = ElGanador.Ganador(); }

                if (Var.ganador)
                {

                    ElGanador.MostrarGanador();
                }

                if (!Var.ganador)
                    Var.ganador = Empate(Var.ganador);



            } while (!Var.ganador);
            Var.ganador = false;
        }

        public static void ResetPuntaje()
        {
            Var.jugadorDos = 0;
            Var.jugadorUno = 0;
        }

        public static void TeRendiste()
        {
            if (Var.turno)
                Console.WriteLine($"Jugador UNO X Te rendiste...");
            else
                Console.WriteLine($"Jugador DOS O Te rendiste...");

        }

        public static bool Empate(bool ganador)
        {
            if (Var.jagadas == 9 && !ganador)
            {
                Console.Clear();
                Cartel.Tateti();
                ColorGl.ConsolaLetraColorRed();
                Cartel.Empate();
                ElTablero.TableroGanador();
                FunGl.PressTecla();
                return true;
            }
            return false;
        }
    }
}