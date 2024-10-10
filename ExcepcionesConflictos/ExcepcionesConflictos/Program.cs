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

            try
            {
                miNumero = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex) when (ex.GetType()!= typeof(FormatException))  // captura generica menos FormatEception
            {
                Console.WriteLine("Ha habido un error ");
                Console.WriteLine("Se toma como número introducido el 0");
                miNumero = 0;

            } 
            catch(FormatException ex)
            {
                Console.WriteLine("Has introducido texto");
                miNumero = 0;
            }
            
           
            if (numeroAleatorio < miNumero) Console.WriteLine("El numero es más bajo");

            if (numeroAleatorio > miNumero) Console.WriteLine("El numero es mas alto");



        } while (numeroAleatorio != miNumero);
        Console.WriteLine($"El numero es correcto has consumido {intentos} intentos");

        Console.WriteLine("A partir de esta linea de código el programa continuaría");

    }
}