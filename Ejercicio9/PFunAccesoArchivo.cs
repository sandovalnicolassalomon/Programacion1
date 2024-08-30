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
            PAccesoArchivo.streamWriter.WriteLine("\n"+DateTime.Now +"\n"+ frase);
        }

        public static void CerrarTxt()
        {
            PAccesoArchivo.streamWriter.Close();
        }
    }
}
