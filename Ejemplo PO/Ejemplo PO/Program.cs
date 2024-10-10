internal class Program
{
    private static void Main(string[] args)
    {
        Circulo miCirculo;  // creación de un objeto tipo Circulo (la clase Circulo)

        miCirculo = new Circulo();  // Iniciación de la variable/objeto de tipo Circulo. Instanciamos una clase

        Console.WriteLine(miCirculo.calculoArea(5));  // hemos tenido que poner publico el metodo calculoArea para que lo podamos instanciar

        Circulo miCirculo2 = new Circulo();  // creamos el objeto e instanciamos desde una misma linea

        Console.WriteLine(miCirculo2.calculoArea(9));

    }
}

class Circulo
{
    const double pi = 3.1416;  // una propiedad de la clase Circulo o campo de clase

    public double calculoArea(int radio)  // método de clase
    {
        return pi * radio * radio;
    }
}