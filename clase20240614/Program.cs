internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        App();


    }

    public static void App()
    {

        do
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Ingrese un numero impar positivo mayor a 1 y oprima enter");

            int numero = PedirNumero();

            if (numero % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine($"No es un numero impar, intente nuevamente");
            }
            else if (numero <= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine($"no es un numero mayor a 1");
            }
            else
            {

                Ejercicio1(numero);
                Ejercicio2(numero);
                Ejercicio3(numero);
                Ejercicio4(numero);
            }

            PresioneContinuar();
        } while (true);
    }

    public static void PresioneContinuar()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"\nPresione una tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }

    public static int PedirNumero()
    {
        Console.ForegroundColor = ConsoleColor.White;

        return Convert.ToInt32(Console.ReadLine());
    }
    public static void Ejercicio1(int numero)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine($"\nEjercicio 1");
        Console.ForegroundColor = ConsoleColor.White;

        for (var i = 0; i < numero; i++)
        {
            if (numero / 2 == i)
            {
                Console.Write($"0 ");
            }
            else
            {
                Console.Write($"1 ");

            }
        }
        Console.WriteLine($"");
    }
    public static void Ejercicio2(int numero)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine($"\nEjercicio 2");
        Console.ForegroundColor = ConsoleColor.White;

        for (var i = 0; i < numero; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write($"0 ");

            }
            else
            {
                Console.Write($"1 ");

            }
        }
        Console.WriteLine($"");

    }
    public static void Ejercicio3(int numero)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine($"\nEjercicio 3");
        Console.ForegroundColor = ConsoleColor.White;

        int medio = numero / 2;
        for (var i = 0; i < numero; i++)
        {
            if (i <= numero / 2 - 1)
            {
                Console.Write($"{medio--} ");
            }
            else
            {
                Console.Write($"{medio++} ");
            }
        }
        Console.WriteLine($"");

    }
    public static void Ejercicio4(int numero)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine($"\nEjercicio 4");
        Console.ForegroundColor = ConsoleColor.White;
        for (var i = 0; i < numero; i++)
        {
            for (var j = 0; j < numero; j++)
            {
                if (j == i)
                {
                    Console.Write($"1 ");
                }
                else
                {
                    Console.Write($"0 ");

                }

            }
            Console.WriteLine($" ");

        }
        Console.WriteLine($"");
    }


}