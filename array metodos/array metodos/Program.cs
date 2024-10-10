internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[4];

        numeros[0] = 7;
        numeros[1] = 8;
        numeros[2] = 9;
        numeros[3] = 10;
        
        ProcesaDatos(numeros);  // se almacena en datos y imprime desde el método procesa datos

        ProcesaDatos2(numeros);

        int[] arrayElementos = LeerDatos();

        Console.WriteLine("Imprimiento desde el main");

        foreach(int i in arrayElementos) Console.WriteLine(i);
    }

    static void ProcesaDatos(int[] datos)
    {
        foreach (int i in datos) {
            Console.WriteLine(i);
        }
    }
    static void ProcesaDatos2(int[] datos)
    {
        for (int i = 0; i < datos.Length; i++)
        {
            datos[i] += 10;  // le suma 10 a todos los valores del array numero
            Console.WriteLine(i);
        }
    }

    static int[] LeerDatos()
    {
        Console.WriteLine("¿Cuantos elementos quieres que tenga el array?");

        string respuesta = Console.ReadLine();

        int numElementos = int.Parse(respuesta);

        int[] datos = new int[numElementos];

        for(int i = 0;i < numElementos; i++)
        {
            Console.WriteLine($"Introduce el dato para la posición {i}");

            respuesta = Console.ReadLine();

            int datosElementos = int.Parse(respuesta);
        }

        return datos;
    }
}

