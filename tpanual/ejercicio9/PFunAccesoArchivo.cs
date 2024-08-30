using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio9
{
    public static class PFunAccesoArchivo
    {
        public static void Escribir(string frase){
            PAccesoArchivo.streamWriter.WriteLine(frase);
        }

        public static void CerrarTxt(){
            PAccesoArchivo.streamWriter.Close();
        }
    }
}