internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Introduce numero de mes");

        int numeroDeMes = Int32.Parse(Console.ReadLine());

        Console.WriteLine(NombreDelMes(numeroDeMes));

        Console.WriteLine("Aquí continuaria la ejecion del resto del programa");

    }

    public static string NombreDelMes(int mes)
    {
        switch (mes)
        {
            case 1:
                return "Enero";
                
            case 2:
                return "Febrero";
                
            case 3:
                return "Marzo";

            case 4:
                return "Abril";

            case 5:
                return "Mayo";

            case 6:
                return "Junio";

            case 7:
                return "Julio";

            case 8:
                return "Agosto";

            case 9:
                return "Septiembre";

            case 10:
                return "Octubre";

            case 11:
                return "Noviembre";

            case 12:
                return "Diciembre";

            default:

                throw new ArgumentOutOfRangeException();

        }
    }
}