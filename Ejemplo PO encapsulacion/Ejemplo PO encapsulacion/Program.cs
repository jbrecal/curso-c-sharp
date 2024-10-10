internal class Program
{
    private static void Main(string[] args)
    {
        Circulo miCirculo;  // creación de un objeto tipo Circulo (la clase Circulo)

        miCirculo = new Circulo();  // Iniciación de la variable/objeto de tipo Circulo. Instanciamos una clase

        Console.WriteLine(miCirculo.CalculoArea(5));  // hemos tenido que poner publico el metodo calculoArea para que lo podamos instanciar

        Circulo miCirculo2 = new Circulo();  // creamos el objeto e instanciamos desde una misma linea

        Console.WriteLine(miCirculo2.CalculoArea(9));

        ConversorEuroDolar miConversor = new ConversorEuroDolar();

        Console.WriteLine(miConversor.convierte(50));

        miConversor.cambiarValorEuror(1.90);

        Console.WriteLine(miConversor.convierte(50));

    }
}

class Circulo
{
    private const double pi = 3.1416;  // una propiedad de la clase Circulo o campo de clase, hemos encapsulado con private

    public double CalculoArea(int radio)  // método de clase que debe de ser public para que tengamos acceso
    {
        return pi * radio * radio;
    }
}

class ConversorEuroDolar
{
    private double euro = 1.15;  // encapsulamos
    public double convierte(double cantidad)
    {
        return euro * cantidad;
    }
    public void cambiarValorEuror(double nuevoValor)  // creamos un método dentro de la clase para poder modificar el valor encapsulado
    {
        euro = nuevoValor;
    }
}