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
            Ejercicio4();
            //WhileDoWhile();








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
                opcion = MenuPrincipal();


                Operaciones(opcion);


            } while (opcion != 0);
            Console.WriteLine($"Adios");



        }

        /**
         * <summary>
         * metodo que se utiliza para ingresar a las operaciones aritmeticas
         * </summary>
         * <param name="opcion"> indica a cual operadcion va a entrar de los if</param>
         */
        private static void Operaciones(int opcion)
        {
            Console.Clear();

            int num1 = 0, num2 = 0;

            if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4)
            {
                num1 = Ingresarvalor("primer");
                num2 = Ingresarvalor("segundo");
            }


            if (opcion == 1)
            {
                Resultado(Suma(num1, num2), "suma");
            }

            if (opcion == 2)
            {
                Resultado(Resta(num1, num2), "Resta");
            }

            if (opcion == 3)
            {
                Resultado(Multiplicacion(num1, num2), "Multiplicacion");
            }

            if (opcion == 4)
            {
                Resultado(Division(num1, num2), "Division");
            }
            
        }

        private static void Resultado(int resultado, string operacion)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"\tEl resultado de la {operacion} es {resultado}\n");
        }

        /**
         * <summary>
         * metodo que suma dos numeros
         * </summary>
         * <param name="num1">primer numero</param>
         * <param name="num2">segundo numero</param>
         * <returns>devuelve el resultado de la suma</returns>
         */
        private static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        private static int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        private static int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        private static int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        private static void Titulooperacion(string valor)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{valor}");
        }

        private static int Ingresarvalor(string pos)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Ingrese el {pos} numero y oprima enter");
            return Convert.ToInt32(Console.ReadLine());

        }

        static void PresioneContinuar()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Oprima una tecla para continuar");
            Console.ReadKey();
            Console.Clear();


        }


        private static int MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine($"Elija una opcion segun su indice y oprima enter");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine($"\t1- Sumar dos numeros");
            Console.WriteLine($"\t2- Restar dos numeros");
            Console.WriteLine($"\t3- Multiplicar dos numeros");
            Console.WriteLine($"\t4- Dividir dos numeros");


            Console.WriteLine($"\t0- para salir");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}