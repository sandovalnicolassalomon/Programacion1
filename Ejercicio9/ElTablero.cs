using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
    public static class ElTablero
    {

        public static readonly char[,] posiciones = new char[3, 3];


        public static void Tablero()
        {
            ColorGl.ConsolaLetraColorWhite();
            Console.WriteLine("");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\t\t\t\t  "+posiciones[i, 0]+" | "+posiciones[i, 1]+" | "+posiciones[i, 2]+"");
                if (i < 2)
                    Console.WriteLine("\t\t\t\t  ---------");
            }
        }
        public static void TableroGanador()
        {
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t\t\t\t\t  ");
                for (int j = 0; j < 3; j++)
                {
                    ColorGl.LetraColor(posiciones[i, j]);
                    Console.Write(posiciones[i, j]+" ");

                    if (j < 2)
                    {
                        ColorGl.ConsolaLetraColorWhite();
                        Console.Write("| ");
                    }
                }
                if (i < 2)
                {
                    ColorGl.ConsolaLetraColorWhite();
                    Console.WriteLine("\n\t\t\t\t\t  ---------");
                }
            }
            Console.WriteLine("");
        }

        public static void CargarPosiciones()
        {
            Program.misVar.Jagadas = 0;
            int pos = 49;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    posiciones[i, j] = (char)(j + pos);

                pos += 3;
            }
        }
    }
}
