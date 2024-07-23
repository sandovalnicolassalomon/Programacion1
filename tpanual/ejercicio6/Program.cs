using System;
using System.Text.RegularExpressions;

namespace ejercicio6
{
    static class Program
    {

        private static string[,] personas = new string[5, 3];
        private static void Main(string[] args)
        {


            App();


        }

        public static void MenuPrincipal()
        {
            ConsolaLetraColorGreen();
            Console.WriteLine("\nIngrese una opcion segun su indice y oprima enter\n");

            ConsolaLetraColorWhite();
            Console.WriteLine($"1- Ingresar personas");
            Console.WriteLine($"2- Ver Personas");
            Console.WriteLine($"0- Salir");
        }

        public static void App()
        {

            string opcion = "";
            do
            {
                MenuPrincipal();
                opcion = Console.ReadLine() ?? " ";
                SeleccionOpcion(opcion);

            } while (opcion != "0");
        }

        public static void SeleccionOpcion(string opcion)
        {
            Console.Clear();


            switch (opcion)
            {

                case "1":
                    IngresarPersonas();
                    break;

                case "2":
                    VerPersonas();
                    break;
                case "0": return;

                default:
                    OpcionInvalida("Opcion Invalida");
                    break;



            }
        }

        public static void VerPersonas()
        {
            Titulo("PERSONAS\n");
            ConsolaLetraColorGray();
            Ordenamiento();
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"{i+1}) {personas[i, 1]}, {personas[i, 0]} {personas[i, 2]}");

            }

        }

        public static void Ordenamiento()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5-i-1; j++)
                {
                    if (Convert.ToInt32(personas[j, 2] ) > Convert.ToInt32(personas[j + 1, 2]))
                    {
                        (personas[j+1, 2], personas[j , 2]) = (personas[j, 2], personas[j +1, 2]);
                        (personas[j+1, 1], personas[j , 1]) = (personas[j, 1], personas[j +1, 1]);
                        (personas[j+1, 0], personas[j , 0]) = (personas[j, 0], personas[j +1, 0]);

                    }
                }
            }
        }

        public static void IngresarPersonas()
        {
            for (int f = 0; f < 5; f++)
            {
                Console.Clear();
                Titulo("INGRESO DE PERSONAS\n");
                string[] temp = new string[3];

                temp[0] = IngresoPalabra("Nombre", f + 1) ?? " ";
                if (temp[0] == " ") return;



                temp[1] = IngresoPalabra("Apellido", f + 1) ?? " ";
                if (temp[1] == " ") return;



                temp[2] = IngresoEdad(f + 1) ?? " ";
                if (temp[2] == " ") return;

                for (int c = 0; c < 3; c++)
                {
                    personas[f, c] = temp[c];
                }
            }



        }

        public static string? IngresoPalabra(string titulo, int f)
        {
            int fails = 0;
            do
            {
                ConsolaLetraColorYellow();
                Console.Write($"\nIngrese el {titulo} N°{f}: ");
                ConsolaLetraColorWhite();
                string nombre = (Console.ReadLine() ?? " ").Trim().ToLower();
                if (Regex.IsMatch(nombre, @"^([a-z]){3,20}$"))
                {
                    return nombre;
                }
                else
                {
                    OpcionInvalida($"Ingreso Invalido {++fails}");
                }
                if (fails == 3)
                {
                    OpcionInvalida("Demasiados intentos fallidos");
                    return null;
                }
            } while (fails < 3);
            return null;
        }



        public static string IngresoEdad(int f)
        {
            int fails = 0;
            do
            {

                ConsolaLetraColorYellow();
                Console.Write($"\nIngrese la Edad N°{f}: ");
                ConsolaLetraColorWhite();
                string edad = (Console.ReadLine() ?? " ").Trim().ToLower();
                if (Regex.IsMatch(edad, @"^(\d){1,2}$"))
                {
                    return edad;
                }
                else
                {
                    OpcionInvalida($"Ingreso Invalido {++fails}");
                }
                if (fails == 3)
                {
                    OpcionInvalida("Demasiados intentos fallidos");
                    return " ";
                }
            } while (fails < 3);

            return " ";
        }

        static void PresioneContinuar()
        {
            ConsolaLetraColorGray();
            Console.WriteLine($"Oprima una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        static void OpcionInvalida(string frase)
        {
            Console.Clear();
            ConsolaLetraColorRed();
            Console.WriteLine($"{frase}\n");
        }

        static void ConsolaLetraColorRed() => Console.ForegroundColor = ConsoleColor.Red;
        static void ConsolaLetraColorWhite() => Console.ForegroundColor = ConsoleColor.White;
        static void ConsolaLetraColorMagenta() => Console.ForegroundColor = ConsoleColor.Magenta;
        static void ConsolaLetraColorGreen() => Console.ForegroundColor = ConsoleColor.Green;
        static void ConsolaLetraColorYellow() => Console.ForegroundColor = ConsoleColor.Yellow;
        static void ConsolaLetraColorGray() => Console.ForegroundColor = ConsoleColor.Gray;



        public static void Titulo(string fraseIn)
        {
            ConsolaLetraColorMagenta();
            Console.WriteLine(fraseIn);

        }

    }
}