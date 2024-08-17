using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio9
{
    public static class Cartel
    {
        public static void Tateti()
        {
            string[] tateti = [ "  _____  _           _____ _____         _____ ___ " ,
                            " |_   _|/ \\         |_   _| ____|       |_   _|_ _|" ,
                            "   | | / _ \\   ____   | | |  _|    ____   | |  | | " ,
                            "   | |/ ___ \\ |____|  | | | |___  |____|  | |  | | " ,
                            "   |_/_/   \\_\\        |_| |_____|         |_| |___|\n" ];

            ColorGl.ColorRandom();
            foreach (var item in tateti)
            {
                Console.WriteLine(item);
            }
        }

        public static void Empate()
        {
            string[] empate = [ "  _____  " ,
                                " |  ___|" ,
                                " | |_ " ,
                                " |  _| " ,
                                " | |___| " ,
                                " | ____|\n" ];

            ColorGl.ColorRandom();
            foreach (var item in empate)
            {
                Console.WriteLine(item);
            }
        }

        public static void Ganador()
        {
            string[] empate = [ "  _____  " ,
                                " / ____|" ,
                                " | |  __" ,
                                " | | |_ \\ " ,
                                " | |__/ |" ,
                                " \\____/\n" ];

            ColorGl.ColorRandom();
            foreach (var item in empate)
            {
                Console.WriteLine(item);
            }
        }

        public static void JuadorX()
        {
            string[] empate = [ 
                "" ,
                " \\ \\  / /" ,
                "  _  | | | | |/ _` |/ _` |/ _` |/ _ \\| '__|  \\  / " ,
                " | |_| | |_| | (_| | (_| | (_| | (_) | |     /  \\ " ,
                "  \\___/ \\__,_|\\__, |\\__,_|\\__,_|\\___/|_|    /_/\\_\\" ,
                "              |___/                               \n" ];

            ColorGl.ColorRandom();
            foreach (var item in empate)
            {
                Console.WriteLine(item);
            }
        }

        public static void JuadorO()
        {
            string[] empate = [ "  " ,
                                "  " ,
                                "  " ,
                                "  " ,
                                "  " ,
                                "  \n" ];

            ColorGl.ColorRandom();
            foreach (var item in empate)
            {
                Console.WriteLine(item);
            }
        }
    }
}