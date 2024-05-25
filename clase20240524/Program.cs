
namespace clase20240524
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                FUNCIONES
                TIPOS:
                EJECUTAN_  Console.Clear() // Saludar()
                RECIBEN VALOR Y EJECUTAN_ Console.WriteLine() // Pares()
                EJECUTAN Y DEVUELVEN_ Console.ReadLine()
                RECIBE, EJECUTA Y DEVUELVE_ // PedirValores()
            */

            Saludar();
            Pares(0, 10);
            InPares(0, 10);
            int valor = Pedirvalores(1);
            Console.WriteLine($"{valor}");
            

        }

        static int Pedirvalores(int id)
        {
           Console.WriteLine($"Ingrese valor {id}:");
            int valor = Convert.ToInt32(Console.ReadLine());
            return valor;
           
        }

        static void Pares(int valor1, int valor2)
        {
            Console.WriteLine($"\n\nValores PARES");
            for (var i = valor1; i < valor2; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{i} ");

            }

        }

        static void InPares(int valor1, int valor2)
        {
            Console.WriteLine($"\n\nValores INPARES");
            for (var i = valor1; i < valor2; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine($"{i} ");

            }

        }

        static void Saludar()
        {
            Console.WriteLine($"Hola!!!!!!");

        }
    }
}