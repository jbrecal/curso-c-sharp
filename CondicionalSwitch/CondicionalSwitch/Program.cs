
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Elige un medio de transporte (coche, tren, avion)");

        string medioTransporte = Console.ReadLine();

        switch (medioTransporte)
        {
            case "coche":
                Console.WriteLine("Velocidad media 100Km/h");
                break;

            case "tren":
                Console.WriteLine("Velocidad media 250Km/h");
                break;

            case "avion":
                Console.WriteLine("Velocidad media 800");
                break;
            default:
                Console.WriteLine("Transporte no contemplado");
                break;
        }
        Console.WriteLine("Ha terminado el programa");
    }
}