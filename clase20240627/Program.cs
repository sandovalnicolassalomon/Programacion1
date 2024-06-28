using System;
namespace clase20240627
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // ejercicio 2 - 9 8 7 6 5 4 3 2 1
            // ejercicio 3 - 1 0 0 0 0 0 0 1
            // ejercicio 4 - 64 49 36 25 16 9 4 1 0
            // ejercicio 5 - 2 4 6 8 10 12 14 16 18
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();


        }

        public static void Ejercicio2()
        {
            Console.WriteLine($"Ejercicio 2");
            int[] array = new int[9];
            for (int i = 9; i > 0; i--)
            {
                array[i - 1] = i;
                Console.Write($"{array[i - 1]} ");
            }
            Console.WriteLine($"\n");
        }

        public static void Ejercicio3()
        {
            Console.WriteLine($"Ejercicio 3");
            int[] array = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (i == 0 || i == 8 - 1)
                {
                    Console.Write($"1 ");
                }
                else
                {
                    Console.Write($"0 ");
                }
            }
            Console.WriteLine($"\n");



        }
        public static void Ejercicio4()
        {
            Console.WriteLine($"Ejercicio 4");
            int[] array = new int[9];
            for (int i = 8; i > -1; i--)
            {
                array[i] = i * i;
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine($"\n");



        }
        public static void Ejercicio5()
        {
            Console.WriteLine($"Ejercicio 5");
            int[] array = new int[10];
            for (int i = 1; i < 10; i++)
            {
                array[i] = i + i;
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine($"\n");



        }
        public static void Ejercicio6()
        {
            Console.WriteLine($"Ejercicio 6");
            string[] array = new string[10];
           
            Console.WriteLine($"\n");



        }

        public static void Ejemplos()
        {
            // declaracion e instanciacion de array unidimensional
            int[] array1 = new int[100];

            // carga de array
            for (int i = 0; i < 100; i++)
            {
                array1[i] = i * 2;
                Console.Write($"{array1[i]} ");
            }

            Console.WriteLine($"\n");

            // declaracion e instanciacion de array bidimensional
            int[,] array2 = new int[10, 10];

            // carga y muestra de array bidimensional filas/columnas
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    array2[f, c] = (f + 1) * c;
                    Console.Write($"{array2[f, c]} ");
                }
                Console.WriteLine($"");
            }

            Console.WriteLine($"\n");

            // muestra de array bidimensional columnas/filas
            for (int c = 0; c < 10; c++)
            {
                for (int f = 0; f < 5; f++)
                {
                    Console.Write($"{array2[f, c]} ");
                }
                Console.WriteLine($"");
            }
            Console.WriteLine($"\n");


        }

        public static void Ejercicio1()
        {
            // Ejercicio 1

            // 0 1 0 1 0 1 0 1 0 1 0

            int[] array1 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    array1[i] = 0;
                else
                    array1[i] = 1;

                Console.Write($"{array1[i]} ");
            }

        }
    }
}