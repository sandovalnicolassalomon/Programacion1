using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio9
{
    public static class FunAccesoArchivos
    {
        public static void EscribirTxt(string frase)
        {

            AccesoArchivos sw = new();

            sw.sw.WriteLine($"\n {DateTime.Now} \n " + frase);

            sw.CerrarTxt();

        }


    }
}