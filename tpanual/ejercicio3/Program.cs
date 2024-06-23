using System;

namespace ejercicio3
{
    static class Program
    {
        private static void Main(string[] args)
        {
            int[,] ints = { { 0, 0, 2, 5, 4 }, { 5, 0, 6, 2, 2 }, { 5, 2, 3, 6, 4 } };
            
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    Console.Write($"{ints[i,j]} ");
                }
                Console.WriteLine($"");
            }
            Console.WriteLine($"");

            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write($"{ints[j,i]} ");
                }
                Console.WriteLine($"");
            }
        }
    }
}