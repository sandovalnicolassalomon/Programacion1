using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
       public static class ColorGl
    {

        public static void ColorJugador()
        {
            Console.ForegroundColor = Program.misVar.Turno ? ConsoleColor.DarkGreen : ConsoleColor.DarkCyan;
        }
        public static void LetraColor(char pos)
        {
            if (Program.misVar.Ganador && !Program.misVar.Turno && pos == 'X')
                ConsolaLetraGreen();
            else if (Program.misVar.Ganador && Program.misVar.Turno && pos == 'O')
                ConsolaLetraCyan();
            else
                ConsolaLetraColorWhite();

        }

        public static void ColorRandom()
        {
            switch (Program.misVar.NRandom.Next(0, 5))
            {
                case 0:
                    ConsolaLetraGreen();
                    break;
                case 1:
                    ConsolaLetraCyan();
                    break;
                case 2:
                    ConsolaLetraColorRed();
                    break;
                case 3:
                    ConsolaLetraColorMagenta();
                    break;
                case 4:
                    ConsolaLetraColorYellow();
                    break;
                default:
                    ConsolaLetraColorWhite();
                    break;
            }
        }

        public static void ConsolaLetraGreen() { Console.ForegroundColor = ConsoleColor.DarkGreen;}
        public static void ConsolaLetraCyan() { Console.ForegroundColor = ConsoleColor.DarkCyan;}
        public static void ConsolaLetraColorRed() { Console.ForegroundColor = ConsoleColor.DarkRed;}
        public static void ConsolaLetraColorMagenta() { Console.ForegroundColor = ConsoleColor.DarkMagenta;}
        public static void ConsolaLetraColorYellow() { Console.ForegroundColor = ConsoleColor.DarkYellow; }
        public static void ConsolaLetraColorWhite() {
            if(Program.misVar.Tema) Console.ForegroundColor = ConsoleColor.White;
            else Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
