
internal class Condicionales
{
    private static void Main(string[] args)
    {
        

        Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

        Console.WriteLine("Introduce tu edad, por favor");

        int edad = Int32.Parse(Console.ReadLine());  // pasamos a entero lo que el usuario introduzca en consola
        string carnet = "";

        if (edad >= 18)
        {
            Console.WriteLine("¿Tienes carnet?");

            carnet = Console.ReadLine();  // como lo almacenamos en una variable tipo texto no tenemos que parsearlo
        }

       

        if (edad >= 18 && carnet == "si")
        {
            Console.WriteLine("Puedes conducir vehiculos");
        }
        else
        {
            Console.WriteLine("No puedes conducir vehiculos");
        }










    }
}