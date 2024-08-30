using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ejercicio5
{
       static class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n***\n" + DateTime.Now.ToString());
            EscribirTxt.Escritor(sb);
            sb.Clear();
            
            int[] ints1 = CargarArrayUni("1");
            int[] ints2 = CargarArrayUni("2");
            sb.Append("\nResultante: ");
            Console.Write("\nResultante: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ints1[i] *= ints2[j];
                }
                Console.Write(ints1[i]+" ");
                sb.Append(ints1[i]+" ");
            }
            Console.WriteLine("");
            EscribirTxt.Escritor(sb);

            Console.ReadKey();
        }

        static int[] CargarArrayUni(string nombre)
        {
            int[] ints = new int[5];
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            sb.Append("\nArray "+nombre+": ");
            Console.Write("\nArray "+nombre+": ");

            for (int i = 0; i < 5; i++)
            {
                ints[i] = random.Next(1, 10);
                Console.Write(ints[i]+" ");
                sb.Append(ints[i]+" ");
            }
            EscribirTxt.Escritor(sb);
            Console.WriteLine("");
            return ints;
        }
    }

    public static class EscribirTxt
    {
        public static void Escritor(StringBuilder frase)
        {
            using (StreamWriter escritor = new StreamWriter("historial.txt", true)){
            escritor.WriteLine(frase);
            escritor.Flush();
            escritor.Close();
            }
        }
    }
}
