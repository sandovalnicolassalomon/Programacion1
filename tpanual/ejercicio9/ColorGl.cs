using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio9
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
                ConsolaLetraColorGreen();
            else if (Program.misVar.Ganador && Program.misVar.Turno && pos == 'O')
                ConsolaLetraColorCyan();
            else
                ConsolaLetraColorWhite();

        }

        public static void ColorRandom()
        {
            Random random = new();
            switch (random.Next(0, 5))
            {
                case 0:
                    ConsolaLetraColorGreen();
                    break;
                case 1:
                    ConsolaLetraColorCyan();
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

        public static void ConsolaLetraColorGreen() => Console.ForegroundColor = ConsoleColor.DarkGreen;
        public static void ConsolaLetraColorCyan() => Console.ForegroundColor = ConsoleColor.DarkCyan;
        public static void ConsolaLetraColorRed() => Console.ForegroundColor = ConsoleColor.DarkRed;
        public static void ConsolaLetraColorMagenta() => Console.ForegroundColor = ConsoleColor.DarkMagenta;
        public static void ConsolaLetraColorYellow() => Console.ForegroundColor = ConsoleColor.DarkYellow;
        public static void ConsolaLetraColorWhite() {
            if(Program.misVar.Tema) Console.ForegroundColor = ConsoleColor.White;
            else Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}