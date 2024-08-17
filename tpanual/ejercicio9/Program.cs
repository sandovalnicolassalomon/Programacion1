
namespace ejercicio9;
static class Program
{

    public static readonly MisVar misVar = new();
    public static void Main()
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