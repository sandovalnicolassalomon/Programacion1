using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AccesoArchiovos
{
    public static class Funciones
    {
        public static void Escribir()
        {
            AccesoDato.writer.WriteLine("Este es el texto adicionado");

        }

        public static void Cerrar()
        {
            AccesoDato.writer.Close();
        }
    }
}
