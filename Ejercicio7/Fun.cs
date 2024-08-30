using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ejercicio7
{
    public static class Fun
    {

        public static void App()
        {
            string opcion;
            do
            {
                Fun.MenuPrincipal();
                opcion = Console.ReadLine() ?? "";
                Fun.SeleccionOpcion(opcion);
            } while (opcion != "0");
        }
        public static void SeleccionOpcion(string opcion)
        {
            Console.Clear();
            switch (opcion)
            {
                case "1":
                    ResetValores();
                    TirarDados();
                    MostrarTiros();
                    MostrarValores();
                    break;

                case "0":
                    return;

                default:
                    OpcionInvalida("Opcion Invalida");
                    break;
            }
        }


        public static void ResetValores()
        {
            for (int i = 0; i < 6; i++)
                Vars.valor[i] = 0;
        }

        private static void TirarDados()
        {

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Presione una tecla para la jugada numero " + (i + 1) + "...");
                Console.ReadKey(true);
                for (int j = 0; j < 5; j++)
                {
                    Vars.dados[i, j] = random.Next(1, 7);
                    ContarValores(i, j);
                }
            }
        }

        private static void MostrarTiros()
        {
            Console.WriteLine("");
            StringBuilder sb = new StringBuilder();
            sb.Append("\n***\n" + DateTime.Now.ToString());

            for (int i = 0; i < 5; i++)
            {
                sb.Append("\nTiro " + (i + 1) + ": ");
                Console.Write("Tiro " + (i + 1) + ": ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" " + Vars.dados[i, j] + " ");
                    sb.Append(" " + Vars.dados[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
        }

        private static void MostrarValores()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine(i + 1 + " = " + Vars.valor[i] + " veces");
                sb.Append("\n" + i + 1 + " = " + Vars.valor[i] + " veces");
            }
           
            FunAccesoArchivo.Escribir(sb);
            
        }



        private static void ContarValores(int i, int j)
        {
            switch (Vars.dados[i, j])
            {
                case 1:
                    Vars.valor[0]++;
                    break;
                case 2:
                    Vars.valor[1]++;
                    break;
                case 3:
                    Vars.valor[2]++;
                    break;
                case 4:
                    Vars.valor[3]++;
                    break;
                case 5:
                    Vars.valor[4]++;
                    break;
                case 6:
                    Vars.valor[5]++;
                    break;
                default:
                    break;
            }
        }

        public static void MenuPrincipal()
        {
            ConsolaLetraColorGreen();
            Console.WriteLine("\nIngrese una opcion segun su indice y oprima enter\n");

            ConsolaLetraColorWhite();
            Console.WriteLine("1- Tirar Dados");
            Console.WriteLine("0- Salir");
        }

        static void OpcionInvalida(string frase)
        {
            Console.Clear();
            ConsolaLetraColorRed();
            Console.WriteLine(frase + "\n");
        }


        static void ConsolaLetraColorRed() { Console.ForegroundColor = ConsoleColor.Red; }
        static void ConsolaLetraColorWhite() { Console.ForegroundColor = ConsoleColor.White; }
        static void ConsolaLetraColorGreen() { Console.ForegroundColor = ConsoleColor.Green; }


    }
}
