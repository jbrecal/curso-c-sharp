using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {

        Caballo miBabieca = new Caballo("Babieca");

        IMamiferosTerrestres ImiBabieca = miBabieca;  // así podremos llamar a la interfaz numero de patas de la interfaz mamifero terrestre

        Console.WriteLine("Numero de patas " + ImiBabieca.numeroPatas());

        ISaltoConPatas ImiBabieca2 = miBabieca;

        Console.WriteLine("Numero de patas para saltar " + ImiBabieca2.numeroPatas());




    }
}

interface IMamiferosTerrestres  // creamos la interfaz
{
    int numeroPatas();  // no se desarrollan
}

interface IAnimalesYDeportes  // toda interfaz ha de ser implementada en la clase que sea necesaria
{
    string tipoDeporte();
    Boolean esOlimpico();
}

interface ISaltoConPatas
{
    int numeroPatas();
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
    public virtual void pensar()
    {
        Console.WriteLine("Pensamiento básico instintivo");
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


class Ballena : Mamiferos
{
    public Ballena(String nombreBallena) : base(nombreBallena)
    {

    }
    public void nadar() 
    {
        Console.WriteLine("Soy capaz de nadar"); 
    }
}

class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas  // implementamos la interfaz separado por coma
{

    public Caballo(String nombreCaballo) : base(nombreCaballo) // con la instrucción base llamamos al constructor de la clase padre
    {

    }
    public void Galopar()
    {
        Console.WriteLine("Soy capaz de galopar");
    }

    int IMamiferosTerrestres.numeroPatas()  // desarrollamos la interfaz
    {
        return 4;
    }
    int ISaltoConPatas.numeroPatas()  // si existe ambiguedad ponemos la interfaz e instanciamos su método
    {
        return 2;
    }
    public string tipoDeporte() // implementamos el método de la interfaz
    {
        return "Hipica";
    }
    public Boolean esOlimpico()  // otra interfaz implementada
    {
        return true;
    }

}

class Humano : Mamiferos

{
    public Humano(String nombreHumano) : base(nombreHumano)
    {

    }
    public override void pensar()  // sobreescritura o modificación del método pensar, es obligado declarar el metodo virtual de la clase Object 
    {
        Console.WriteLine("Soy capaz de pensar");
    }
}

class Gorilla : Mamiferos
{

    public Gorilla(String nombreGorilla) : base(nombreGorilla)
    {

    }
    public void pensar()
    {
        Console.WriteLine("Pensamiento instintivo avanzado");
    }

    public void trepar()
    {
        Console.WriteLine("Soy capaz de trepar");
    }
}