using System;
namespace clase20240627
{
    static class Program
    {
        private static void Main(string[] args)
        {
            // Ejercicio a 2 - 9 8 7 6 5 4 3 2 1
            // ejercicio 3 - 1 0 0 0 0 0 0 1
            // ejercicio 4 - 64 49 36 25 16 9 4 1 0
            // ejercicio 5 - 2 4 6 8 10 12 14 16 18
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();


        }

        public static void Ejercicio2()
        {
            Titulo($"Ejercicio 2");
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
            Titulo($"Ejercicio 3");
            int[] array = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (i == 0 || i == 8 - 1)
                {
                    array[i] = 1;
                    Console.Write($"1 ");
                }
                else
                {
                    array[i] = 0;

                    Console.Write($"0 ");
                }
            }
            Console.WriteLine($"\n");



        }
        public static void Ejercicio4()
        {
            Titulo($"Ejercicio 4");
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
            Titulo($"Ejercicio 5");
            int[] array = new int[10];
            for (int i = 1; i < 10; i++)
            {
                array[i] = i + i;
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine($"\n");



        }
        public static void Titulo(string titulo){
            LetraVerde();
            Console.WriteLine($"\n{titulo}");
            LetraBlanca();
        }
        public static void Ejercicio6()
        {
            Titulo($"\nEjercicio 6");

            Console.WriteLine($"¿Cuantos nombres desea ingresar?");
            Console.WriteLine($"Ingrese un numero entero positivo y oprima enter");
            int cant = Convert.ToInt32(Console.ReadLine());

            string[] nombres = new string[cant];

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine($"\nIngrese el nombre Nº{i + 1} y oprima enter");
                nombres[i] = Console.ReadLine() ?? "123";

            }

            Console.WriteLine($"");
            for (int i = 0; i < cant; i++)
            {
                Console.Write($"{nombres[i]}; ");

            }
        }
        public static void Ejercicio7()
        {
            
            Titulo($"\nEjercicio 7");
            Console.WriteLine($"¿Cuantos personas desea ingresar?");
            Console.WriteLine($"Ingrese un numero entero positivo y oprima enter");
            int cant = Convert.ToInt32(Console.ReadLine());

            string[] nombres = new string[cant];
            int[] edades = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine($"\nIngrese el nombre Nº{i + 1} y oprima enter");
                nombres[i] = Console.ReadLine() ?? "";
                Console.WriteLine($"\nIngrese la edad Nº{i + 1} y oprima enter");
                edades[i] = Convert.ToInt32(Console.ReadLine());


            }

            Console.WriteLine($"");
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine($"{nombres[i]} {edades[i]} ");

            }
        }
        public static void Ejercicio8()
        {
            Titulo($"\nEjercicio 8");
            Console.WriteLine($"¿Cuantos numeros desea ingresar?");
            Console.WriteLine($"Ingrese un numero entero positivo y oprima enter");
            int cant = Convert.ToInt32(Console.ReadLine());


            int[] numeros = new int[cant];
            int mayor10 = 0, menor10 = 0, sumaMayor10 = 0, sumaMenor10 = 0;

            for (int i = 0; i < cant; i++)
            {

                Console.WriteLine($"\nIngrese el valor Nº{i + 1} y oprima enter");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (numeros[i] >= 10)
                {
                    mayor10++;
                    sumaMayor10 += numeros[i];
                }
                else
                {
                    menor10++;
                    sumaMenor10 += numeros[i];
                }

            }

            Console.WriteLine($"\tCantidad mayores o iguales a 10: {mayor10}");
            Console.WriteLine($"\tCantidad menores a 10: {menor10}");
            Console.WriteLine($"\tSuma de mayores o iguales a 10: {sumaMayor10}");
            Console.WriteLine($"\tSuma de menores a 10: {sumaMenor10}");


        }

        

        public static void Ejercicio9()
        {
            Titulo($"\nEjercicio 9");
            int sumaLong = 0;
            string[] frases = new string[6];
            Console.WriteLine($"Ingrese 5 frases");
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"\nIngrese la frese Nº{i + 1}");
                frases[i] = Console.ReadLine() ?? "";
                sumaLong += frases[i].Length;

            }

            frases[5] = sumaLong.ToString();
            Console.WriteLine($"");
            for (int i = 0; i < 6; i++)
            {
                if (i < 5)
                    Console.WriteLine($"Frase Nº{i+1}: {frases[i]}");
                else
                    Console.WriteLine($"Cantidad de caracteres: {frases[i]}");
            }
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
        public static void LetraVerde() => Console.ForegroundColor = ConsoleColor.Green;
        public static void LetraBlanca() => Console.ForegroundColor = ConsoleColor.White;
    }
}