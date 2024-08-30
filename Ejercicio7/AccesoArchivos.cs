using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ejercicio7
{
    public static class AccesoArchivos
    {
        public static StreamWriter streamWriter = File.AppendText(Vars.archivo);

    }
}
