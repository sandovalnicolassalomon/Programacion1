using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EjerProgN1P1
{
    public partial class Utiles
    {
        public static void OprimaTeclaContinuar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nOprima una tecla para continuar");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }

        public static void MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Mediante el teclado elija un Ejercicio por su indice.");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("\t" + i + "- Ejercicio " + i);

            }

            Console.WriteLine("\t0- Salir.");
        }




        public static void DemasiadosIntentos()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDemasiados Intentos Fallidos");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

        }

        public static bool ValidacionInt(string valor)
        {
            try
            {
                if (MyRegexInt().IsMatch(valor))
                {
                    int numero = Convert.ToInt32(valor);
                    if (numero >= int.MinValue && numero <= int.MaxValue)
                        return true;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingreso invalido.");
                Console.ForegroundColor = ConsoleColor.White;


            }
            catch (Exception)
            {
                // TODO
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El numero debe ser mayor o igual a {0} y menor o igual a {1}", int.MinValue, int.MaxValue);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return false;
        }
        public static bool ValidacionDouble(string valor)
        {
            try
            {
                if (MyRegexDouble().IsMatch(valor))
                {
                    double numero = Convert.ToDouble(valor, CultureInfo.InvariantCulture);
                    return true;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingreso invalido.");
                Console.ForegroundColor = ConsoleColor.White;


            }
            catch (Exception)
            {
                // TODO
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El numero debe ser un decimal");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return false;
        }

        #region Expresiones Regulares
        [GeneratedRegex(@"^(\-\d|\d)+$")]
        private static partial Regex MyRegexInt();

        [GeneratedRegex(@"^(\-(\d)|\-(\d)+(\.)(\d)+|(\d)+|(\d)+(\.)(\d))+$")]
        private static partial Regex MyRegexDouble();
        #endregion
    }


}