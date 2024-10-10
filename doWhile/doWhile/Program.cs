internal class Program
{
    private static void Main(string[] args)
    {
        Random numero = new Random();  //primero tenemos que crear un objeto tipo Random

        int numeroAleatorio = numero.Next(0, 100);

        int miNumero;
        int intentos = 0;

        Console.WriteLine("Intorduce un numero entre 0 y 100");

        do
        {
            intentos++;

            miNumero = Int32.Parse(Console.ReadLine());

            if (numeroAleatorio < miNumero) Console.WriteLine("El numero es más bajo");

            if (numeroAleatorio > miNumero) Console.WriteLine("El numero es mas alto");



        } while (numeroAleatorio != miNumero);
        Console.WriteLine("El numero es correcto");
        Console.WriteLine($"Has consumido {intentos} intentos");
    }
}