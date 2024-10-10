using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {

        Caballo Babieca = new Caballo("Babieca");

        Humano Juan = new Humano("Juan");

        Gorilla Copito = new Gorilla("Copito");

        Copito.trepar();

    }
}

class Mamiferos
{
    public Mamiferos(String nombre)  // constructor
    {
        nombreSerVivo = nombre;
    }
    public void respirar()
    {
        Console.WriteLine("Soy capaz de respirar");
    }

    public void cuidarCrias()
    {
        Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
    }

    public void getNombre()  // creado en la superclase pero podemos utilizarlo de las demas clases herencia gracias al base
    {
        Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
    }

    private String nombreSerVivo;  
}

class Caballo : Mamiferos  // aquí estamos haciendo una herencia, la clase Caballo hereda de Mamifero
{

    public Caballo(String nombreCaballo):base(nombreCaballo) // con la instrucción base llamamos al constructor de la clase padre
    {

    }
    public void Galopar()
    {
        Console.WriteLine("Soy capaz de galopar");
    }
}

class Humano : Mamiferos

{
    public Humano(String nombreHumano):base(nombreHumano)
    {

    }
    public void pensar()
    {
        Console.WriteLine("Soy capaz de pensar");
    }
}

class Gorilla : Mamiferos
{

    public Gorilla (String nombreGorilla) : base(nombreGorilla)
    {

    }

    public void trepar()
    {
        Console.WriteLine("Soy capaz de trepar");
    }
}