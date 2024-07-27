using System;
using System.Text.RegularExpressions;
namespace ejercicio9;
static class Program
{
    private static char[,] posiciones = new char[3, 3];
    private static int fails = 0;
    private static int jugadorUno = 0;
    private static int jugadorDos = 0;
    private static bool turno = true;
    private static int jagadas = 0;

    private static bool ganador = false;
    delegate void MiLetraColor(char pos);
    private static void Main(string[] args)
    {

        App();
    }

    public static void App()
    {
        string opcion;
        do
        {
            Console.Clear();
            CargarPosiciones();
            Tateti();
            MostrarPuntaje();
            Tablero();
            MenuPrincipal();
            opcion = Console.ReadLine() ?? "";
            SeleccionOpcion(opcion);
        } while (opcion != "0");
    }
    public static void MenuPrincipal()
    {
        ConsolaLetraColorYellow();

        Console.WriteLine("\nIngrese una opcion segun su indice y oprima enter\n");

        ConsolaLetraColorWhite();
        Console.WriteLine($"1- Jugar");
        Console.WriteLine($"2- Resetear Puntajes");

        Console.WriteLine($"0- Salir");
    }

    public static void SeleccionOpcion(string opcion)
    {
        Console.Clear();
        switch (opcion)
        {
            case "1":
                Juego();
                break;
            case "2":
                ResetPuntaje();
                break;

            case "0":
                return;

            default:
                OpcionInvalida("Opcion Invalida");
                break;
        }
    }

    private static void Juego()
    {
        do
        {
            Console.Clear();
            Tateti();
            MostrarPuntaje();
            Tablero();
            TurnoJugador();

            string eleccion = EleccionPosicion();
            if (eleccion == "0")
            {

                Console.Clear();
                Console.WriteLine($"Te rendiste...");
                ElGanador();
                TableroGanador();
                PressTecla();
                return;
            }

            bool marca = MarcarPosicion(eleccion);

            if (marca && jagadas > 4) { ganador = Ganador(); }

            if (ganador)
            {
                MostrarGanador();
            }

            if (!ganador)
                ganador = Empate(ganador);



        } while (!ganador);
        ganador = false;
    }

    public static bool Empate(bool ganador)
    {
        if (jagadas == 9 && !ganador)
        {
            Console.Clear();
            Tateti();
            ConsolaLetraColorRed();
            Console.WriteLine($"\t\t  EMPATE");
            Tablero();
            PressTecla();
            return true;
        }
        return false;
    }

    private static void MostrarGanador()
    {
        Console.Clear();
        Tateti();
        ConsolaLetraColorMagenta();
        ElGanador();
        TableroGanador();
        PressTecla();
    }

    public static void PressTecla()
    {
        Console.WriteLine($"Presiona una tecla para continuar");
        Console.ReadKey();
    }

    public static void ElGanador()
    {
        if (!turno)
        {
            ConsolaLetraColorGreen();
            Console.WriteLine("El ganador es el jugador Uno X");
            jugadorUno++;
        }
        else
        {
            ConsolaLetraColorCyan();
            Console.WriteLine("El ganador es el jugador Dos O");
            jugadorDos++;

        }
    }

    private static bool Ganador()
    {
        for (int i = 0; i < 3; i++)
            if (posiciones[i, 0] == posiciones[i, 1] && posiciones[i, 0] == posiciones[i, 2])
                return true;

        for (int i = 0; i < 3; i++)
            if (posiciones[0, i] == posiciones[1, i] && posiciones[0, i] == posiciones[2, i])
                return true;

        if (posiciones[0, 0] == posiciones[1, 1] && posiciones[0, 0] == posiciones[2, 2])
            return true;

        if (posiciones[2, 0] == posiciones[1, 1] && posiciones[2, 0] == posiciones[0, 2])
            return true;

        return false;
    }

    private static bool MarcarPosicion(string eleccion)
    {
        if (Regex.IsMatch(eleccion, @"^\d$"))
        {
            if (ValidarPosicion(eleccion))
            {
                turno = !turno;
                fails = 0;
                jagadas++;
                return true;
            }
            else
            {
                fails++;
                OpcionInvalida($"Opcion Invalida {fails}");
            }
        }
        else
        {
            fails++;
            OpcionInvalida($"Opcion Invalida {fails}");
        }
        return false;
    }

    public static void TurnoJugador()
    {
        if (turno)
            MostrarJuagador("Uno X");
        else
            MostrarJuagador("Dos O");
    }


    public static string EleccionPosicion()
    {
        ConsolaLetraColorWhite();
        Console.WriteLine($"Elija la posicion del tablero disponible y oprima enter");
        ConsolaLetraColorYellow();
        Console.WriteLine("Presione 0 para Rendirse");
        return Console.ReadLine() ?? " ";
    }

    public static bool ValidarPosicion(string eleccion)
    {
        char miEleccion = Convert.ToChar(eleccion);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (posiciones[i, j] == miEleccion)
                {
                    if (turno)
                        posiciones[i, j] = 'X';
                    else
                        posiciones[i, j] = 'O';

                    return true;
                }
            }
        }
        return false;
    }

    public static void CargarPosiciones()
    {
        jagadas = 0;
        int pos = 49;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                posiciones[i, j] = (char)(j + pos);

            pos += 3;
        }
    }


    public static void Tablero()
    {


        ConsolaLetraColorWhite();
        Console.WriteLine($"\n\t\t{posiciones[0, 0]} | {posiciones[0, 1]} | {posiciones[0, 2]}");
        Console.WriteLine($"\t\t---------");
        Console.WriteLine($"\t\t{posiciones[1, 0]} | {posiciones[1, 1]} | {posiciones[1, 2]}");
        Console.WriteLine($"\t\t---------");
        Console.WriteLine($"\t\t{posiciones[2, 0]} | {posiciones[2, 1]} | {posiciones[2, 2]}\n");
    }

    public static void TableroGanador()
    {
        MiLetraColor Color = new((pos) =>
        {
            if (ganador && !turno && pos == 'X')
                ConsolaLetraColorGreen();
            else if (ganador && turno && pos == 'O')
                ConsolaLetraColorCyan();
            else
                ConsolaLetraColorWhite();
        });

        ConsolaLetraColorWhite();
        Color(posiciones[0, 0]);
        Console.Write($"\n\t\t{posiciones[0, 0]} ");
        ConsolaLetraColorWhite();
        Console.Write("| ");
        Color(posiciones[0, 1]);

        Console.Write($"{posiciones[0, 1]} ");
        ConsolaLetraColorWhite();

        Console.Write("| ");
        Color(posiciones[0, 2]);

        Console.WriteLine($"{posiciones[0, 2]}");
        ConsolaLetraColorWhite();

        Console.Write($"\t\t---------");
        Color(posiciones[1, 0]);

        Console.Write($"\n\t\t{posiciones[1, 0]} ");
        ConsolaLetraColorWhite();

        Console.Write("| ");
        Color(posiciones[1, 1]);

        Console.Write($"{posiciones[1, 1]} ");
        ConsolaLetraColorWhite();

        Console.Write("| ");
        Color(posiciones[1, 2]);

        Console.WriteLine($"{posiciones[1, 2]}");
        ConsolaLetraColorWhite();

        Console.Write($"\t\t---------");
        Color(posiciones[2, 0]);

        Console.Write($"\n\t\t{posiciones[2, 0]} ");
        ConsolaLetraColorWhite();

        Console.Write("| ");
        Color(posiciones[2, 1]);

        Console.Write($"{posiciones[2, 1]} ");
        ConsolaLetraColorWhite();

        Console.Write("| ");
        Color(posiciones[2, 2]);

        Console.WriteLine($"{posiciones[2, 2]}\n");
    }

    public static void Tateti()
    {

        ColorTateti();
        Console.WriteLine("  _____  _         _____ _____       _____ ___ ");
        Console.WriteLine(" |_   _|/ \\       |_   _| ____|     |_   _|_ _|");
        Console.WriteLine("   | | / _ \\   __   | | |  _|    __   | |  | | ");
        Console.WriteLine("   | |/ ___ \\ |__|  | | | |___  |__|  | |  | | ");
        Console.WriteLine("   |_/_/   \\_\\      |_| |_____|       |_| |___|\n");


    }

    public static void MostrarPuntaje()
    {
        ConsolaLetraColorYellow();
        Console.WriteLine($"\t\t PUNTAJE");
        ConsolaLetraColorGreen();
        Console.Write($"Jugador Uno X: {jugadorUno}");
        ConsolaLetraColorCyan();
        Console.WriteLine($"\t Jugador Dos O: {jugadorDos}");
    }


    public static void MostrarJuagador(string jugador)
    {
        Console.ForegroundColor = turno ? ConsoleColor.Green : ConsoleColor.Cyan;
        Console.WriteLine($"Turno de jugador {jugador}".ToUpper());
    }



    static void OpcionInvalida(string frase)
    {
        Console.Clear();
        Tateti();
        ConsolaLetraColorRed();
        Console.WriteLine($"{frase}\n Presione una tecla para continuar");
        Console.ReadKey(true);
    }
    public static void ResetPuntaje()
    {
        jugadorDos = 0;
        jugadorUno = 0;
    }

    public static void ColorTateti()
    {
        Random random = new();
        switch (random.Next(0, 5))
        {
            case 0:
                ConsolaLetraColorGreen();
                break;
            case 1:
                ConsolaLetraColorCyan();
                break;
            case 2:
                ConsolaLetraColorRed();
                break;
            case 3:
                ConsolaLetraColorMagenta();
                break;
            case 4:
                ConsolaLetraColorYellow();
                break;
            default:
                ConsolaLetraColorWhite();
                break;
        }
    }

    static void ConsolaLetraColorGreen() => Console.ForegroundColor = ConsoleColor.Green;
    static void ConsolaLetraColorCyan() => Console.ForegroundColor = ConsoleColor.Cyan;
    static void ConsolaLetraColorRed() => Console.ForegroundColor = ConsoleColor.Red;
    static void ConsolaLetraColorMagenta() => Console.ForegroundColor = ConsoleColor.Magenta;
    static void ConsolaLetraColorYellow() => Console.ForegroundColor = ConsoleColor.Yellow;
    static void ConsolaLetraColorWhite() => Console.ForegroundColor = ConsoleColor.White;
}