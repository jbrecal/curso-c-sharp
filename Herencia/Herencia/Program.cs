using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {

        Caballo Babieca = new Caballo();

        Humano Juan = new Humano(); 

        Gorilla Copito = new Gorilla();

        Copito.trepar();
       
    }
}

class Mamiferos
{
    public void respirar()
    {
        Console.WriteLine("Soy capaz de respirar");
    }

    public void cuidarCrias()
    {
        Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
    }
}

class Caballo: Mamiferos  // aquí estamos haciendo una herencia, la clase Caballo hereda de Mamifero
{
    public void Galopar()
    {
        Console.WriteLine("Soy capaz de galopar");
    }
}

class Humano : Mamiferos
{
    public void pensar()
    {
        Console.WriteLine("Soy capaz de pensar");
    }
}

class Gorilla : Mamiferos
{

    public void trepar()
    {
        Console.WriteLine("Soy capaz de trepar");
    }
}