
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Introduce la nota del primer parcial");

        int parcial1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Introduce la nota del segundo parcial");

        int parcial2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Introduce la nota del tercero parcial");

        int parcial3= Int32.Parse(Console.ReadLine());

        if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)

          Console.WriteLine("La nota media es " + (parcial1+parcial2+parcial3) / 3);

        else Console.WriteLine("Vuelve en septiembre");
    }
}
