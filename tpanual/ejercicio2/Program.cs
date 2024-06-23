using System;

namespace ejercicio2
{

    static class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];

            int suma = 0;

            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    matriz[i, j] = i + j;
                    suma += matriz[i, j];
                    Console.Write($"{matriz[i,j]} ");
                    
                }
                Console.WriteLine($"= {suma}");
                suma = 0;
            }
        }
    }
}