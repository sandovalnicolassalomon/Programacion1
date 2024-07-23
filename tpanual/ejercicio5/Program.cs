using System;

namespace ejercicio5
{
    static class Program
    {
        private static void Main(string[] args)
        {
            int[] ints1 = CargarArrayUni("1");
            int[] ints2 = CargarArrayUni("2");

            Console.Write($"\nResultante: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ints1[i] *= ints2[j];
                }
                Console.Write($"{ints1[i]} ");
            }
            Console.WriteLine($"");
            Console.ReadKey();

        }

        static int[] CargarArrayUni(string nombre){
            int[] ints = new int[5];
            Random random = new();
            Console.Write($"\nArray {nombre}: ");

            for (int i = 0; i < 5; i++)
            {
                ints[i] = random.Next(1, 10);
                Console.Write($"{ints[i]} ");

            }
            
            Console.WriteLine($"");
            return ints;
        }
    }
}