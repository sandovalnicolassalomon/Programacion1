internal class Program
{
    private static void Main(string[] args)
    {
        App();
    }

    // funcion que hace algo
    public static void MenuPrincipal(){

        Console.WriteLine($"ingrese una opcion segun su indice y oprima enter");
        
        Console.WriteLine($"1- Calcular el area");
        Console.WriteLine($"2- Calcular la circunferencia");
        Console.WriteLine($"0- Salir");

        
    }
    //funcion que recibe y devuelve algo
    public static decimal CalcularArea(decimal b, decimal altura){
        return b * altura / 2;
    }
    //funcion que recibe y devuelve algo
    public static decimal CalcularCircunferencia(decimal radio){
        const decimal PI = (decimal)3.141692F;
        return 2 * PI * radio;
    }


    public static void App(){ // solo hace algo

        string opcion = "";
        do
        {
            MenuPrincipal();
            opcion = Console.ReadLine() ?? " ";
            SeleccionOpcion(opcion);

        } while (opcion != "0");
    }

// recibe y hace algo
    public static void SeleccionOpcion(string opcion)
    {
        Console.Clear();
        
        decimal resultado = 0;
        if(opcion == "1"){
            Console.WriteLine($"Ingrese el valor de la base del triangulo");
            decimal b = PedirValores();
            Console.WriteLine($"Ingrese el valor de la altura del triangulo");
            decimal altura = PedirValores();
             resultado = CalcularArea(b, altura);

        }

        if(opcion == "2"){
            Console.WriteLine($"ingrese el valor del Radio");
            decimal radio = PedirValores();
            resultado = CalcularCircunferencia(radio);
        }
        if( opcion == "1" || opcion == "2")    
            MostrarResultado(resultado);


    }
    // devuelve algo
    public static decimal PedirValores(){
        return Convert.ToDecimal(Console.ReadLine());
    }
    // recibe y hace algo
    public static void MostrarResultado(decimal resultado){
        Console.WriteLine($"El Resultado es {resultado}");

    }
}