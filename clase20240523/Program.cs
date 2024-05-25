namespace clase20240523
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Ejercicio1();
        }

        public static void Ejercicio1()
        {
            /*
                usando bucles
                 ej1:
                 - debe tener un menu principal que muestre
                 - "1 - numeros pares"
                 - "2 - numeros impares"
                 - usar el for para imprimir los valores pares entre dos limites
                 - los valores inicio y fin deben ser ingresados por el usuario
            */
            Console.Clear();

            int inicio = 0, fin = 0, opcion;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Bienvenido");



            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Obtengamos los numeros pares o impares en un cierto rango ");

                Console.WriteLine($"Elija un opcion segun su indice y oprima enter");
                Console.ForegroundColor = ConsoleColor.White;


                Console.WriteLine($"\t1 - Numeros Pares");
                Console.WriteLine($"\t2 - Numeros Impares");
                Console.WriteLine($"\t0 - salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1 || opcion == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Ingrese un numero entero de inicio y oprima enter");

                    Console.ForegroundColor = ConsoleColor.White;
                    inicio = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Ingrese un numero entero para finalizar y oprima enter");

                    Console.ForegroundColor = ConsoleColor.White;
                    fin = Convert.ToInt32(Console.ReadLine());

                }




                if (opcion == 1)
                {


                    if (fin < inicio)
                    {
                        Console.WriteLine($"El numero final es mayor al de incio");
                        Oprimacontinuar();

                    }
                    else
                    {


                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\tNumeros Pares");

                        Console.ForegroundColor = ConsoleColor.Green;

                        for (var i = inicio; i <= fin; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write($"{i} ");

                            }
                        }
                        Oprimacontinuar();

                    }


                }

                if (opcion == 2)
                {


                    if (fin < inicio)
                    {
                        Console.WriteLine($"El numero final es mayor al de incio");
                        Oprimacontinuar();

                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"\n\tNumeros Impares");


                        Console.ForegroundColor = ConsoleColor.Green;

                        for (var i = inicio; i <= fin; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write($"{i} ");

                            }
                        }
                        Oprimacontinuar();
                    }
                }
                if (opcion == 0)
                {
                    Console.WriteLine($"Hasta la proxima");
                    Espera();

                }
                else if (opcion != 1 && opcion != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Opcion no valida");
                    Oprimacontinuar();

                }


                Console.Clear();


            } while (opcion != 0);
        }

        public static void Oprimacontinuar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n\n\tPresione una tecla para continuar");

            Console.ReadKey();

        }

        public static void Espera()
        {
            for (var i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write($".");

            }
        }
    }
}