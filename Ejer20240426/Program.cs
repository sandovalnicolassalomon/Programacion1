using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        string nombre1;
        string nombre2;
        string nombre3; 
        string apellido1;
        string apellido2;
        string apellido3;
        Console.Write("Ingrese nombre: ");
        nombre1 = Console.ReadLine() ?? " ";
        Console.Write("Ingrese apellido: ");
        apellido1 = Console.ReadLine() ?? " ";
        Console.WriteLine("");
                Console.Write("Ingrese nombre: ");
        nombre2 = Console.ReadLine() ?? " ";
        Console.Write("Ingrese apellido: ");
        apellido2 = Console.ReadLine() ?? " ";
        Console.WriteLine("");

                Console.Write("Ingrese nombre: ");
        nombre3 = Console.ReadLine() ?? " ";
        Console.Write("Ingrese apellido: ");
        apellido3 = Console.ReadLine() ?? " ";
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Los datos ingresados son: " );
        Console.WriteLine("");
        Console.WriteLine(apellido1+ ", "+ nombre1);
        Console.WriteLine(apellido2+ ", "+ nombre2);
        Console.WriteLine(apellido3+ ", "+ nombre3);

        Console.ReadKey();
        

    }
}