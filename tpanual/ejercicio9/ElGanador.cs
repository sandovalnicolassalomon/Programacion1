using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ejercicio9
{
    public static class ElGanador
    {

        public static void MostrarGanador()
        {
            Console.Clear();
            Cartel.Ganador();

            MiGanador();

            ElTablero.TableroGanador();
            FunGl.PressTecla();
        }

        public static void MiGanador()
        {
            string frase = "El ganador es el jugador ";
            if (!Program.misVar.Turno)
            {
                ColorGl.ConsolaLetraColorGreen();
                Cartel.JuadorX();
                frase += "UNO X";
                Program.misVar.JugadorUno++;

            }
            else
            {
                ColorGl.ConsolaLetraColorCyan();
                frase += "DOS O";
                Cartel.JuadorO();
                Program.misVar.JugadorDos++;

            }

            FunAccesoArchivos.EscribirTxt(frase);

            // PFunAccesoArchivo.Escribir(frase);
            // PFunAccesoArchivo.CerrarTxt();
        }

        public static bool Ganador() => GanadorHorizontal() || GanadorVertical() || GanadorDiagonal();

        public static bool GanadorDiagonal()
        {
            if (ElTablero.posiciones[0, 0] == ElTablero.posiciones[1, 1] && ElTablero.posiciones[0, 0] == ElTablero.posiciones[2, 2])
                return true;


            if (ElTablero.posiciones[2, 0] == ElTablero.posiciones[1, 1] && ElTablero.posiciones[2, 0] == ElTablero.posiciones[0, 2])
                return true;

            return false;
        }

        public static bool GanadorVertical()
        {
            for (int i = 0; i < 3; i++)
            {
                if (ElTablero.posiciones[0, i] == ElTablero.posiciones[1, i] && ElTablero.posiciones[0, i] == ElTablero.posiciones[2, i])
                    return true;
            }
            return false;
        }

        public static bool GanadorHorizontal()
        {
            for (int i = 0; i < 3; i++)
            {
                if (ElTablero.posiciones[i, 0] == ElTablero.posiciones[i, 1] && ElTablero.posiciones[i, 0] == ElTablero.posiciones[i, 2])
                    return true;

            }
            return false;
        }

    }
}