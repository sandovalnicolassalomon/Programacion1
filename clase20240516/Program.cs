namespace clase20240516
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }
            Console.Clear();
            //Ejercicio3();
            //Ejemplo1();
            //Ejemplo2();
            //Ejercicio4();
            WhileDoWhile();








        }
        public static void Ejercicio1()
        {
            int suma = 0;
            Console.WriteLine($"Ingrese 3 numeros enteros para sumarlos");
            for (var i = 0; i < 3; i++)
            {

                Console.WriteLine($"Ingrese un numero entero y oprima enter");

                suma += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"La suma de los 3 numeros es: {suma}");
        }

        public static void Ejercicio2()
        {
            /*
             desarrollar un programa que devuelva la suma de los numeros enteros compredidos entre dos valores. los valores desde hasta los debe ingresar el usuario. deberan usar solo un for para resolverlo, ademas de las dos variables para el desde y el hasta.
         */

            int suma = 0;
            Console.WriteLine($"sumemos dos valores enteros mediante limites marcados");

            Console.WriteLine($"Ingrese dos numeros para indicar los limites ");
            Console.WriteLine($"Ingrese el numero de desde donde quiera arrancar el limite");
            int desde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ingrese el numero de hasta donde quiera terminar el limite");
            int hasta = Convert.ToInt32(Console.ReadLine());

            for (var i = desde; i < hasta; i++)
            {
                Console.WriteLine($"{i}");
                suma += i;

            }
            Console.WriteLine($"La suma de los  numeros es: {suma}");

        }

        public static void Ejercicio3()
        {
            Console.WriteLine($"Obtengamos el area de un triangulo rectangulo\nIngrese la base del triangulo");
            float var_base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ingrese la altura del triangulo");
            float var_altura = Convert.ToInt32(Console.ReadLine());

            /*
            desarrollar un programa que devuelva el area de un trangulo rectangulo
            pidiendo al usuario la longitud de la base y la altura del mismo

            area de trangulo rectangulo: (base * altura)/2
            */
            float area = var_base * var_altura / 2;
            Console.WriteLine($"El area del triangulo rectangulo es: {area}");


        }

        public static void WhileDoWhile()
        {
            string salir = "S";
            while (salir != "S")
            {
                //* hacer
                Console.WriteLine($"Desea salir?");
                salir = Console.ReadLine() ?? " ";

                Console.WriteLine($"salir: {salir}");


            }
            do
            {
                //* hacer
                Console.WriteLine($"Desea salir?");
                salir = Console.ReadLine() ?? " ";


            } while (salir != "Si");
        }

        public static void Ejemplo1()
        {
            /*
            que se impriman por consola todos los numeros pares entre el 1 y el 10
            */
            int numero = 0;
            while (numero < 10)
            {
                numero += 2;
                Console.WriteLine($"{numero}");

            }

        }
        public static void Ejemplo2()
        {
            /*
                crear un menu recursivo en donde el usuario pueda elegir varias opciones y que una de ellas sea para terminar el programa
            */

            string opcion = "";
            do
            {
                Console.WriteLine($"Elija una opcion segun su indice y oprima enter");

                for (var i = 1; i < 5; i++)
                {
                    Console.WriteLine($"{i}- Opcion{i}");

                }
                Console.WriteLine($"0- Para salir");
                opcion = Console.ReadLine() ?? " ";

                Console.Clear();

            } while (opcion != "0");
            Console.WriteLine($"Adios");



        }

        public static void Ejercicio4()
        {

            /*
            usando bucles
            desarrollar una calculadora que cumpla con las siguientes especificaciones/ requisitos

            - debe tener un menu de opciones y el mismo debe ser recursivo
            -sean creativos con los colores y como organizan los mensajes en la consola
            */
            int opcion;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine($"Elija una opcion segun su indice y oprima enter");
                Console.ForegroundColor = ConsoleColor.White;


                Console.WriteLine($"\t1- Sumar dos numeros");
                Console.WriteLine($"\t2- Restar dos numeros");
                Console.WriteLine($"\t3- Multiplicar dos numeros");
                Console.WriteLine($"\t4- Dividir dos numeros");


                Console.WriteLine($"\t0- para salir");

                opcion = Convert.ToInt32(Console.ReadLine());


                int num1;
                int num2;
                if (opcion == 1)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($"Sumemos dos numeros");
                    Console.ForegroundColor = ConsoleColor.White;


                    Console.WriteLine($"Ingrese el primer numero y oprima enter");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ingrese el segundo numero y oprima enter");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"\n\n\tEl resultado de la suma es {num1 + num2}\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($"Oprima una tecla para continuar");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;


                }

                if (opcion == 2)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($"Restemos dos numeros");
                    Console.ForegroundColor = ConsoleColor.White;


                    Console.WriteLine($"Ingrese el primer numero y oprima enter");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ingrese el segundo numero y oprima enter");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"\n\n\tEl resultado de la resta es {num1 - num2}\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($"Oprima una tecla para continuar");
                    Console.ReadKey();

                    Console.ForegroundColor = ConsoleColor.White;


                }

                if (opcion == 3)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($"Multipliquemos dos numeros");
                    Console.ForegroundColor = ConsoleColor.White;


                    Console.WriteLine($"Ingrese el primer numero y oprima enter");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ingrese el segundo numero y oprima enter");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"\n\n\tEl resultado de la multiplicacion es {num1 * num2}\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($"Oprima una tecla para continuar");
                    Console.ReadKey();

                    Console.ForegroundColor = ConsoleColor.White;


                }

                if (opcion == 4)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Dividamos dos numeros");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"Ingrese el primer numero y oprima enter");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Ingrese el segundo numero y oprima enter");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"\n\n\tEl resultado de la division es {num1 / num2}\n");

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine($"Oprima una tecla para continuar");
                    Console.ReadKey();

                    Console.ForegroundColor = ConsoleColor.White;



                }
                Console.Clear();




            } while (opcion != 0);
            Console.WriteLine($"Adios");
            Thread.Sleep(3000);



        }
    }
}