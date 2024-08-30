using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio9
{
    public static class PAccesoArchivo
    {
        public static StreamWriter streamWriter = File.AppendText(Program.misVar.ArchivoHistorial);
    }
}