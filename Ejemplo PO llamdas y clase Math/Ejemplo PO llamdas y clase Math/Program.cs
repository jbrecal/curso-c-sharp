internal class Program
{
    private static void Main(string[] args)
    {
        Punto origen = new Punto();  // aqui será 0 y 0 porque esta llamando al constructor sin parametros

        Punto destino = new Punto(128,80);

        double distancia = origen.DistanciaHasta(destino);

        Console.WriteLine($"La distancia entre los puntos es de {distancia}");

        Console.WriteLine($"Numero de objetos creados: {Punto.getContadorDeObjetos()}");
    }
}