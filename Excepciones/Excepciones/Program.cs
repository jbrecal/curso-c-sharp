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
            } catch (FormatException ex)   // con esta excepcion capturamos si hay una interrupcion por meter un string
            {
                Console.WriteLine("No has introducido un valor númerico válido " + ex.Message);
                Console.WriteLine("Se toma como número introducido el 0");
                miNumero = 0;

            } catch(OverflowException ex) // aqui capturamos si introducimos un valor demasiado alto
            {
                Console.WriteLine("Has introducido un valor numerico demasiado alto" + ex.Message);
                miNumero = 0;

            } catch (Exception ex)  // esta es una excepción genéraica que ponemos como ejemplo que está por encima de las otras dos ya que es el padre por gerarquía
            {
                miNumero = 0;
            }
            if (numeroAleatorio < miNumero) Console.WriteLine("El numero es más bajo");

            if (numeroAleatorio > miNumero) Console.WriteLine("El numero es mas alto");



        } while (numeroAleatorio != miNumero);
            Console.WriteLine($"El numero es correcto has consumido {intentos} intentos");

        Console.WriteLine("A partir de esta linea de código el programa continuaría");
        
    }
}