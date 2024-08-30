using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AccesoArchiovos
{
    public static class AccesoDato
    {
        public static StreamWriter writer = File.AppendText(Declaraciones.FileName);

    }
}
