using System;
using System.Text;
namespace ejercicio7;

static class Program
{

    private static int[,] dados = new int[5, 5];
    private static int[] valor = new int[6];

    private static void Main(string[] args)
    {
        App();
    }

    public static void App()
    {
        string opcion;
        do
        {
            MenuPrincipal();
            opcion = Console.ReadLine() ?? "";
            SeleccionOpcion(opcion);
        } while (opcion != "0");
    }

    public static void SeleccionOpcion(string opcion)
    {
        Console.Clear();
        switch (opcion)
        {
            case "1":
                ResetValores();
                TirarDados();
                MostrarTiros();
                MostrarValores();
                break;

            case "0":
                return;

            default:
                OpcionInvalida("Opcion Invalida");
                break;
        }
    }
    public static void ResetValores()
    {
        for (int i = 0; i < 6; i++)
            valor[i] = 0;
    }

    private static void TirarDados()
    {

        Random random = new();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Presione una tecla para la jugada numero {i + 1}...");
            Console.ReadKey(true);
            for (int j = 0; j < 5; j++)
            {
                dados[i, j] = random.Next(1, 7);
                ContarValores(i, j);
            }
        }
    }

    private static void MostrarTiros()
    {
        Console.WriteLine($"");
        StringBuilder sb = new();
        sb.Append("\n***\n" + DateTime.Now.ToString());

        for (int i = 0; i < 5; i++)
        {
            sb.Append($"\nTiro {i + 1}: ");
            Console.Write($"Tiro {i + 1}: ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write($" {dados[i, j]} ");
                sb.Append($" {dados[i, j]} ");
            }
            Console.WriteLine($"\n");
        }
        EscribirTxt.Escritor(sb);
    }

    private static void MostrarValores()
    {
        StringBuilder sb = new();

        for (int i = 0; i < 6; i++)
        {

            Console.WriteLine($"{i + 1} = {valor[i]} veces");
            sb.Append($"\n{i + 1} = {valor[i]} veces");
        }
        EscribirTxt.Escritor(sb);
    }

    

    private static void ContarValores(int i, int j)
    {
        switch (dados[i, j])
        {
            case 1:
                valor[0]++;
                break;
            case 2:
                valor[1]++;
                break;
            case 3:
                valor[2]++;
                break;
            case 4:
                valor[3]++;
                break;
            case 5:
                valor[4]++;
                break;
            case 6:
                valor[5]++;
                break;
            default:
                break;
        }
    }

    public static void MenuPrincipal()
    {
        ConsolaLetraColorGreen();
        Console.WriteLine("\nIngrese una opcion segun su indice y oprima enter\n");

        ConsolaLetraColorWhite();
        Console.WriteLine($"1- Tirar Dados");
        Console.WriteLine($"0- Salir");
    }

    static void OpcionInvalida(string frase)
    {
        Console.Clear();
        ConsolaLetraColorRed();
        Console.WriteLine($"{frase}\n");
    }


    static void ConsolaLetraColorRed() => Console.ForegroundColor = ConsoleColor.Red;
    static void ConsolaLetraColorWhite() => Console.ForegroundColor = ConsoleColor.White;
    static void ConsolaLetraColorGreen() => Console.ForegroundColor = ConsoleColor.Green;


    public static class EscribirTxt
    {
        public static void Escritor(StringBuilder frase)
        {
            using StreamWriter escritor = new("historial.txt", true);
            escritor.WriteLine($"{frase}");
            escritor.Flush();
            escritor.Close();
        }
    }
}