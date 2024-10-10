internal class Program
{
    private static void Main(string[] args)
    {
        Coche coche1 = new Coche();  // creamos o instanciamos un objeto de tipo Coche y dar un estado incial a nuestro coche

        Coche coche2 = new Coche();

        Console.WriteLine(coche1.getRuedas());

        Console.WriteLine(coche2.getInfoCoche());

        Coche coche3 = new Coche(4500,1200); // le metemos los parametros del segundo constructor 

        Console.WriteLine(coche3.getInfoCoche());


    }
}

class Coche
{
    private int ruedas;
    private double longitud;
    private double ancho;
    private bool climatizador;
    private string tapiceria;

   public Coche() // creamos el constructor
    {
        ruedas = 4;
        longitud = 2300.5;
        ancho = 0.800;
    }
    public int getRuedas() // creamos el método para acceder a las ruedas a través de getter
    {
        return ruedas;
    }

    public string getInfoCoche()
    {
        return "Información del coche: \n" + "Ruedas " + ruedas + " longitud " + longitud + " ancho " + ancho;
    }

    // vamos a realizar una sobrecarga de constructor

    public Coche(double largoCoche, double anchoCoche)
    {
        ruedas = 4;
        ancho = anchoCoche;
        longitud = largoCoche;
    }
}