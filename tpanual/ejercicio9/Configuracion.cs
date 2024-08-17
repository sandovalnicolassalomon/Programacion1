using System;



namespace ejercicio9
{
    public static class Configuracion
    {
        public static void MenuConfiguracion()
        {
            string opcion;
            do
            {
                ElTablero.CargarPosiciones();
                FunGl.VistaNormal();
                Menu();
                opcion = Console.ReadLine() ?? "";
                if (Program.misVar.Sonido) Console.Beep();

                SeleccionOpcion(opcion);
            } while (opcion != "0");
        }

        private static void Menu()
        {
            ColorGl.ConsolaLetraColorYellow();

            Console.WriteLine("\nIngrese una opcion segun su indice y oprima enter\n");

            ColorGl.ConsolaLetraColorWhite();
            Console.WriteLine($"1- Menú Sonido");



            Console.WriteLine($"0- Salir");
        }

        private static void SeleccionOpcion(string opcion)
        {
            Console.Clear();
            switch (opcion)
            {
                case "1":
                    MenuSonido();
                    break;
                case "0":
                    return;
                default:
                    OpcionesJuego.OpcionInvalida("Opcion Invalida");
                    break;
            }
        }

        private static void MenuSonido()
        {
            ColorGl.ConsolaLetraColorYellow();
            Console.WriteLine("\nSONIDO\n");

            Console.WriteLine("\nIngrese una opcion segun su indice y oprima enter\n");

            ColorGl.ConsolaLetraColorWhite();
            Console.WriteLine($"1- ON");
            Console.WriteLine($"2- OFF");

            Console.WriteLine($"0- Salir");
            SeleccionSonido();
        
            }

        private static void SeleccionSonido()
        {
            string opcion = Console.ReadLine() ?? "2";
            if (opcion != "1" && opcion != "2" && opcion != "0")
            {
                OpcionesJuego.OpcionInvalida("Opcion Invalidad");
            }

            else
            {
                Program.misVar.Sonido = opcion == "1" ;
                if(Program.misVar.Sonido) Console.Beep();
            }
        }

    }
}