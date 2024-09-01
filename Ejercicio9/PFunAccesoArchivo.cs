using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ejercicio9
{
    public static class PFunAccesoArchivo
    {
        public static void Escribir(string frase)
        {
            PAccesoArchivo.sw.WriteLine("\n"+DateTime.Now +"\n"+ frase);
            PAccesoArchivo.sw.Flush();
        }

        public static void CerrarTxt()
        {
            PAccesoArchivo.sw.Close();
        }
    }
}
