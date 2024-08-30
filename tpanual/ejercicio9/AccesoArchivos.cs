using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio9
{
    public class AccesoArchivos
    {
        public  StreamWriter sw = File.AppendText(Program.misVar.ArchivoHistorial);

        public void CerrarTxt(){
            sw.Close();
        }
    }
}