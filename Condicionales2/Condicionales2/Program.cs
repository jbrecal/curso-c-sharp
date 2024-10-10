
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

        Console.WriteLine("Introduce tu edad, por favor");

        int edad = Int32.Parse(Console.ReadLine());

        if (edad < 18)
        {
            Console.WriteLine("No puedes conducir vehiculos");

        }
        else
        {
            Console.WriteLine("¿Tienes carnet?");
            string carnet = Console.ReadLine();

            int compara = String.Compare(carnet, "si", true); // el tercer parametro no tiene en cuenta si tiene mayusculas o minusculas

            if (compara == 0)
            {
                Console.WriteLine("Puedes conducir vehiculos");
            }
            else
            {
                Console.WriteLine("No puedes conducir vehiculos");
            }
        }
    }
}