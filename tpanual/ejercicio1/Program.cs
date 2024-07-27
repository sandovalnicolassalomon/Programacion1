using System;

namespace ejercicio1
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int suma = 0;

            Random random = new();

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(1, 7);
                    Console.Write($"{matriz[i, j]} ");
                    suma += matriz[i, j];
                }
                Console.WriteLine($"");
            }
            Console.WriteLine($"La suma de todo los valores de la matriz es: {suma}");
            Console.ReadKey();
        }
    }
}