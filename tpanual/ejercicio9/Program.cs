using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
namespace ejercicio9;
static class Program
{


    public static void Main(string[] args)
    {
        App();
    }

    public static void App()
    {
        string opcion;
        do
        {
            ElTablero.CargarPosiciones();
            FunGl.VistaNormal();
            FunGl.MenuPrincipal();
            opcion = Console.ReadLine() ?? "";
            Console.Beep();
            OpcionesJuego.SeleccionOpcion(opcion);
        } while (opcion != "0");
    }

}