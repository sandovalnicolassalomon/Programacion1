using System;

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
                if (Program.misVar.Sonido) Console.Beep();

                if (eleccion == "0")
                {
                    Console.Clear();
                    TeRendiste();
                   
                    return;
                }

                bool marca = OpcionesJuego.MarcarPosicion(eleccion);

                if (marca && Program.misVar.Jagadas > 4) { Program.misVar.Ganador = ElGanador.Ganador(); }

                if (Program.misVar.Ganador)
                {

                    ElGanador.MostrarGanador();
                }

                if (!Program.misVar.Ganador)
                    Program.misVar.Ganador = Empate(Program.misVar.Ganador);



            } while (!Program.misVar.Ganador);
            Program.misVar.Ganador = false;
        }

        public static void ResetPuntaje()
        {
            Program.misVar.JugadorDos = 0;
            Program.misVar.JugadorUno = 0;
        }

        public static void TeRendiste()
        {

            if (Program.misVar.Turno)
                Console.WriteLine($"Jugador UNO X Te rendiste...");
            else
                Console.WriteLine($"Jugador DOS O Te rendiste...");
            ColorGl.ColorJugador();
            Cartel.Ganador();
            ElGanador.MiGanador();
            ElTablero.TableroGanador();
            FunGl.PressTecla();
        }

        public static bool Empate(bool ganador)
        {
            if (Program.misVar.Jagadas == 9 && !ganador)
            {
                Console.Clear();
                Cartel.Tateti();
                ColorGl.ConsolaLetraColorRed();
                Cartel.Empate();
                ElTablero.Tablero();
                FunGl.PressTecla();
                return true;
            }
            return false;
        }
    }
}