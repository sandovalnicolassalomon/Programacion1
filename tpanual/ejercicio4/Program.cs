using System;

namespace ejercicio4
{
    static class Program
    {
        private static void Main(string[] args)
        {
            int[,] ints = new int[6, 6];
            int[] ints1 = new int[6];

            Random random = new();

            for (var i = 0; i < 6; i++)
            {
                for (var j = 0; j < 6; j++)
                {
                    ints[i, j] = random.Next(2, 9);
                    Console.Write($"{ints[i, j]} ");
                    if (i == j)
                        ints1[i] = ints[i, j];

                }
                Console.WriteLine($"");
            }

            Console.WriteLine($"");

            foreach (int Item in ints1)
            {
                Console.Write($"{Item} ");
            }
            Console.WriteLine($"");
            Console.ReadKey();
        }
    }
}