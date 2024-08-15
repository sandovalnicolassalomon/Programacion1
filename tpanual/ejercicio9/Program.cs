using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
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
    public static void Main(string[] args)
    {
        App();
    }

    public static void App()
    {
        string opcion;
        do
        {
            CargarPosiciones();
            VistaNormal();
            MenuPrincipal();
            opcion = Console.ReadLine() ?? "";
            Console.Beep();
            SeleccionOpcion(opcion);
        } while (opcion != "0");
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

    public static void CartelTateti()
    {
        string[] tateti = [ "  _____  _           _____ _____         _____ ___ " ,
                            " |_   _|/ \\         |_   _| ____|       |_   _|_ _|" ,
                            "   | | / _ \\   ____   | | |  _|    ____   | |  | | " ,
                            "   | |/ ___ \\ |____|  | | | |___  |____|  | |  | | " ,
                            "   |_/_/   \\_\\        |_| |_____|         |_| |___|\n" ];

        ColorRandom();
        foreach (var item in tateti)
        {
            Console.WriteLine(item);
        }
    }

    public static void MostrarPuntaje()
    {
        ConsolaLetraColorYellow();
        Console.WriteLine($"\t\t\tPUNTAJE");
        ConsolaLetraColorGreen();
        Console.Write($"  \"Jugador Uno X\": {jugadorUno}");
        ConsolaLetraColorCyan();
        Console.WriteLine($"\t\t  \"Jugador Dos O\": {jugadorDos}");
    }

    public static void Tablero()
    {
        ConsolaLetraColorWhite();
        Console.WriteLine($"");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\t\t       {posiciones[i, 0]} | {posiciones[i, 1]} | {posiciones[i, 2]}");
            if (i < 2)
                Console.WriteLine($"\t\t       ---------");
        }
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

    public static void Juego()
    {
        do
        {
            VistaNormal();
            TurnoJugador();

            string eleccion = EleccionPosicion();
            Console.Beep();
            if (eleccion == "0")
            {
                Console.Clear();
                CartelTateti();
                TeRendiste();
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

    public static void TeRendiste()
    {
        if (turno)
            Console.WriteLine($"Jugador UNO X Te rendiste...");
        else
            Console.WriteLine($"Jugador DOS O Te rendiste...");

    }

    public static bool Empate(bool ganador)
    {
        if (jagadas == 9 && !ganador)
        {
            Console.Clear();
            CartelTateti();
            ConsolaLetraColorRed();
            Console.WriteLine($"\t\t\tEMPATE");
            TableroGanador();
            PressTecla();
            return true;
        }
        return false;
    }

    public static void MostrarGanador()
    {
        Console.Clear();
        CartelTateti();
        ConsolaLetraColorMagenta();
        ElGanador();
        TableroGanador();
        PressTecla();
    }

    public static void PressTecla()
    {
        Console.WriteLine($"\nPresiona una tecla para continuar");
        Console.ReadKey();
    }

    public static void ElGanador()
    {
        string frase = "El ganador es el jugador ";
        if (!turno)
        {
            ConsolaLetraColorGreen();
            frase += "UNO X";
            jugadorUno++;

        }
        else
        {
            ConsolaLetraColorCyan();
            frase += "DOS O";

            jugadorDos++;

        }
        Console.Write(frase);

        EscribirTxt(frase);
    }

    public static bool Ganador() => GanadorHorizontal() || GanadorVertical() || GanadorDiagonal();

    public static bool GanadorDiagonal()
    {
        if (posiciones[0, 0] == posiciones[1, 1] && posiciones[0, 0] == posiciones[2, 2])
            return true;


        if (posiciones[2, 0] == posiciones[1, 1] && posiciones[2, 0] == posiciones[0, 2])
            return true;

        return false;
    }

    public static bool GanadorVertical()
    {
        for (int i = 0; i < 3; i++)
        {
            if (posiciones[0, i] == posiciones[1, i] && posiciones[0, i] == posiciones[2, i])
                return true;
        }
        return false;
    }

    public static bool GanadorHorizontal()
    {
        for (int i = 0; i < 3; i++)
        {
            if (posiciones[i, 0] == posiciones[i, 1] && posiciones[i, 0] == posiciones[i, 2])
                return true;

        }
        return false;
    }

    public static bool MarcarPosicion(string eleccion)
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
                OpcionInvalida($"Opcion Invalida {fails}");
            }
        }
        else
        {
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
        Console.WriteLine($"\nElija la posicion del tablero disponible y oprima enter");
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






    public static void TableroGanador()
    {
        Console.WriteLine($"\n");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\t\t       ");
            for (int j = 0; j < 3; j++)
            {
                LetraColor(posiciones[i, j]);
                Console.Write($"{posiciones[i, j]} ");

                if (j < 2)
                {
                    ConsolaLetraColorWhite();
                    Console.Write("| ");
                }
            }
            if (i < 2)
            {
                ConsolaLetraColorWhite();
                Console.WriteLine($"\n\t\t       ---------");
            }
        }
        Console.WriteLine("");
    }





    public static void MostrarJuagador(string jugador)
    {
        Console.ForegroundColor = turno ? ConsoleColor.Green : ConsoleColor.Cyan;
        Console.WriteLine($"\nTurno de jugador {jugador}".ToUpper());
    }

    public static void OpcionInvalida(string frase)
    {
        fails++;
        Console.Clear();
        CartelTateti();
        ConsolaLetraColorRed();
        Console.WriteLine($"{frase}\n Presione una tecla para continuar");
        Console.ReadKey(true);
    }

    public static void ResetPuntaje()
    {
        jugadorDos = 0;
        jugadorUno = 0;
    }

    public static void LetraColor(char pos)
    {
        if (ganador && !turno && pos == 'X')
            ConsolaLetraColorGreen();
        else if (ganador && turno && pos == 'O')
            ConsolaLetraColorCyan();
        else
            ConsolaLetraColorWhite();

    }

    public static void ColorRandom()
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

    public static void ConsolaLetraColorGreen() => Console.ForegroundColor = ConsoleColor.Green;
    public static void ConsolaLetraColorCyan() => Console.ForegroundColor = ConsoleColor.Cyan;
    public static void ConsolaLetraColorRed() => Console.ForegroundColor = ConsoleColor.Red;
    public static void ConsolaLetraColorMagenta() => Console.ForegroundColor = ConsoleColor.Magenta;
    public static void ConsolaLetraColorYellow() => Console.ForegroundColor = ConsoleColor.Yellow;
    public static void ConsolaLetraColorWhite() => Console.ForegroundColor = ConsoleColor.White;

    public static void EscribirTxt(string frase)
    {
        using StreamWriter st = new("historial.txt", true);
        st.WriteLine($"\n {DateTime.Now} \n {frase}");
        st.Flush();
        st.Close();
    }



    public static void VistaNormal()
    {
        Console.Clear();
        CartelTateti();
        MostrarPuntaje();
        Tablero();
    }


}