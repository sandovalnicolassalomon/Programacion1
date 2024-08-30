using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Ejercicio9
{
    public static class OpcionesJuego
    {
        public static bool MarcarPosicion(string eleccion)
        {
            if (Regex.IsMatch(eleccion, @"^\d$"))
            {
                if (ValidarPosicion(eleccion))
                {
                    Program.misVar.Turno = !Program.misVar.Turno;
                    Program.misVar.Fails = 0;
                    Program.misVar.Jagadas++;
                    return true;
                }
                else
                {
                    OpcionInvalida("Opcion Invalida "+Program.misVar.Fails);
                }
            }
            else
            {
                OpcionInvalida("Opcion Invalida "+Program.misVar.Fails);
            }
            return false;
        }

        public static bool ValidarPosicion(string eleccion)
        {
            char miEleccion = Convert.ToChar(eleccion);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (ElTablero.posiciones[i, j] == miEleccion)
                    {
                        if (Program.misVar.Turno)
                            ElTablero.posiciones[i, j] = 'X';
                        else
                            ElTablero.posiciones[i, j] = 'O';

                        return true;
                    }
                }
            }
            return false;
        }

        public static void SeleccionOpcion(string opcion)
        {
            Console.Clear();
            switch (opcion)
            {
                case "1":
                    ElJuego.Juego();
                    break;
                case "2":
                    ElJuego.ResetPuntaje();
                    break;

                case "3":
                    Configuracion.MenuConfiguracion();
                    break;

                case "0":
                    return;

                default:
                    OpcionInvalida("Opcion Invalida");
                    break;
            }
        }

        public static void OpcionInvalida(string frase)
        {
            Program.misVar.Fails++;
            Console.Clear();
            Cartel.Tateti();
            ColorGl.ConsolaLetraColorRed();
            Console.WriteLine(frase+"\n Presione una tecla para continuar");
            Console.ReadKey(true);
        }
    }
}
