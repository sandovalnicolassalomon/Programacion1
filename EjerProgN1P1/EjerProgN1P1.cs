
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection.Metadata;

namespace EjerProgN1P1
{
    internal class EjerProgN1P1
    {
        public static readonly string INTENTE_NUEVAMENTE = "Intente Nuevamente o 'q' para salir y oprima enter";
        private static void Main(string[] args)
        {

            char opcion;


            do
            {

                Console.Clear();
                Console.WriteLine("Bienvenido");
                Utiles.MenuPrincipal();

                opcion = Console.ReadKey(true).KeyChar;
                Console.WriteLine("");
                switch (opcion)
                {
                    case '1': Ejercicio1(); break;
                    case '2': Ejercicio2(); break;
                    case '3': Ejercicio3(); break;
                    case '4': Ejercicio4(); break;
                    case '5': Ejercicio5(); break;
                    case '6': Ejercicio6(); break;
                    case '0': Console.WriteLine("Adios"); break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Opcion no valida.");

                            Utiles.OprimaTeclaContinuar();

                            break;
                        }
                }

            } while (opcion != '0');

        }



        private static void Ejercicio6()
        {
            Console.Clear();
            char letra;
            string msj;
            msj = "NO ES VOCAL";
            Console.WriteLine("Ingrese una letra para saber si es una vocal.");
            Console.WriteLine("Ingrese una letra y oprima enter");
            letra = Console.ReadKey().KeyChar;
            Console.WriteLine("");

            if (letra == 'A' || letra == 'a')
            {
                msj = "ES VOCAL";
            }
            if (letra == 'E' || letra == 'e')
            {
                msj = "ES VOCAL";
            }
            if (letra == 'I' || letra == 'i')
            {
                msj = "ES VOCAL";
            }
            if (letra == 'O' || letra == 'o')
            {
                msj = "ES VOCAL";
            }
            if (letra == 'U' || letra == 'u')
            {
                msj = "ES VOCAL";
            }

            Console.WriteLine(msj);

            Utiles.OprimaTeclaContinuar();
        }

        private static void Ejercicio5()
        {
            Console.Clear();
            int num1;
            int num2;
            int mayor = 0;
            Console.WriteLine("Ingrese dos numero para saber cual es el mayor.");
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 <= num2)
            {
                mayor = num2;
            }
            if (num1 > num2)
            {
                mayor = num1;
            }

            Console.WriteLine("El mayor es el numero " + mayor);

            Utiles.OprimaTeclaContinuar();


        }

        private static void Ejercicio4()
        {
            Console.Clear();
            byte cont = 0;
            const int DIA = 86400;
            const int HORA = 360;
            const int MINUTO = 60;
            int tiempo = 0;
            int dias;
            int horas;
            int minutos;
            int segundos;
            Console.WriteLine("Convertamos una cantidad de segundos en Hora, Minutos y segundos.");
            Console.WriteLine("Ingrese una cantidad de segundos y oprima enter");
            string ingreso;
            while (cont < 3)
            {
                cont++;
                ingreso = Console.ReadLine() ?? " ";
                if (ingreso == "q" || ingreso == "Q")
                    return;

                if (Utiles.ValidacionInt(ingreso.Trim()))
                {
                    tiempo = Convert.ToInt32(ingreso);
                    break;
                }

                if (cont == 3)
                {
                    Utiles.DemasiadosIntentos();
                    return;
                }
                Console.WriteLine(INTENTE_NUEVAMENTE);
            }
            dias = tiempo / DIA;
            horas = (tiempo % DIA) / HORA;
            tiempo = tiempo % HORA;
            minutos = tiempo / MINUTO;
            segundos = tiempo % MINUTO;
            Console.WriteLine("El tiempo es " + dias + " dias : " + horas + " horas : " + minutos + " minutos : " + segundos + " segundos.");

            Utiles.OprimaTeclaContinuar();
        }

        private static void Ejercicio3()
        {
            Console.Clear();
            byte cont = 0;
            double PI = Math.PI;
            double area;
            double radio = 0;
            Console.WriteLine("Obtengamos el area de un circulo mediante su radio");
            Console.WriteLine("Ingrese el valor del radio y oprima enter");
            string ingreso;
            while (cont < 3)
            {
                cont++;
                ingreso = Console.ReadLine() ?? " ";
                if (ingreso == "q" || ingreso == "Q")
                    return;

                if (Utiles.ValidacionDouble(ingreso.Trim()))
                {
                    radio = Convert.ToDouble(ingreso, CultureInfo.InvariantCulture);
                    break;
                }

                if (cont == 3)
                {
                    Utiles.DemasiadosIntentos();
                    return;
                }
                Console.WriteLine(INTENTE_NUEVAMENTE);
            }
            area = PI * Math.Pow(radio, 2);
            Console.WriteLine("El area del circulo es: " + area);

            Utiles.OprimaTeclaContinuar();


        }

        private static void Ejercicio2()
        {
            Console.Clear();
            byte cont = 0;
            double num1 = 0.0;
            double num2 = 0.0;
            double potencia;

            Console.WriteLine("\nHallemos la potencia de un numero.");
            Console.WriteLine("Ingrese el numero base o 'q' para salir y oprima enter");

            string ingreso;
            while (cont < 3)
            {
                cont++;
                ingreso = Console.ReadLine() ?? " ";
                if (ingreso == "q" || ingreso == "Q")
                    return;

                if (Utiles.ValidacionDouble(ingreso.Trim()))
                {
                    num1 = Convert.ToDouble(ingreso, CultureInfo.InvariantCulture);
                    break;
                }

                if (cont == 3)
                {
                    Utiles.DemasiadosIntentos();
                    return;
                }
                Console.WriteLine(INTENTE_NUEVAMENTE);
            }
//b

            Console.WriteLine("Ingrese el numero exponente o 'q' para salir y oprima enter");
            cont = 0;
            while (cont < 3)
            {
                cont++;
                ingreso = Console.ReadLine() ?? " ";
                if (ingreso == "q" || ingreso == "Q")
                    return;

                if (Utiles.ValidacionDouble(ingreso.Trim()))
                {
                    num2 = Convert.ToDouble(ingreso, CultureInfo.InvariantCulture);

                    break;
                }


                if (cont == 3)
                {
                    Utiles.DemasiadosIntentos();
                    return;
                }
                Console.WriteLine(INTENTE_NUEVAMENTE);
            }


            potencia = Math.Pow(num1, num2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tLa potencia de {0}^{1} es: {2}", num1, num2, potencia);
            Console.ForegroundColor = ConsoleColor.White;


            Utiles.OprimaTeclaContinuar();
        }


        private static void Ejercicio1()
        {
            Console.Clear();
            byte cont = 0;
            int cociente;
            int resto;
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Obtengamos el coeficiente y el resto entre dos numeros enteros.");
            Console.WriteLine("Ingrese el primer numero entero o 'q' para salir y oprima enter.");
            string ingreso;

            while (cont < 3)
            {
                cont++;
                ingreso = Console.ReadLine() ?? " ";
                if (ingreso == "q" || ingreso == "Q")
                    return;

                if (Utiles.ValidacionInt(ingreso.Trim()))
                {
                    num1 = Convert.ToInt32(ingreso);
                    break;
                }

                if (cont == 3)
                {
                    Utiles.DemasiadosIntentos();
                    return;
                }
                Console.WriteLine(INTENTE_NUEVAMENTE);
            }

            Console.WriteLine("\nIngrese el segundo numero entero o 'q' para salir y oprima enter");
            //n

            cont = 0;
            while (cont < 3)
            {
                cont++;
                ingreso = Console.ReadLine() ?? " ";
                if (ingreso == "q" || ingreso == "Q")
                    return;

                if (Utiles.ValidacionInt(ingreso.Trim()))
                {
                    num2 = Convert.ToInt32(ingreso);
                    if (num2 == 0)
                        Console.WriteLine("No se puede dividir por cero");
                    else break;
                }

                if (cont == 3)
                {
                    Utiles.DemasiadosIntentos();
                    return;
                }
                Console.WriteLine(INTENTE_NUEVAMENTE);

            }

            cociente = num1 / num2;
            resto = num1 % num2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tEl cociente de {0} / {1} es: {2}", num1, num2, cociente);
            Console.WriteLine("\tEl resto de {0} / {1} es: {2}", num1, num2, resto);
            Console.ForegroundColor = ConsoleColor.White;

            Utiles.OprimaTeclaContinuar();



        }
    }
}