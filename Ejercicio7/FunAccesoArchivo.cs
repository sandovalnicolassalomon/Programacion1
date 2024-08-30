using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio7
{
    public static class FunAccesoArchivo
    {
        public static void Escribir(StringBuilder frase)
        {
            AccesoArchivos.streamWriter.WriteLine(frase);
        }

        public static void CerrarTxt()
        {
            AccesoArchivos.streamWriter.Close();
        }
    }
}
