using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ejercicio9
{
    public static class PAccesoArchivo
    {

        public static StreamWriter sw = File.AppendText(Program.misVar.ArchivoHistorial);
             
    }
}
