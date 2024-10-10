internal class Program
{
    private static void Main(string[] args)
    {
        Coche coche1 = new Coche();  // creamos o instanciamos un objeto de tipo Coche y dar un estado incial a nuestro coche

        Coche coche2 = new Coche();

        Console.WriteLine(coche1.getRuedas());

        Console.WriteLine(coche2.getInfoCoche());

        Console.WriteLine(coche2.getExtras());  // no nos da ningún valor porque aun no hemos usado el set para establecer los parametros

        coche2.setExtras(true, "cuero");

        Console.WriteLine(coche2.getExtras());



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
    public void setExtras(bool climatizador, string tapiceria)  // setter para establecer el climatizador y la tapiceria
    {
        this.climatizador = climatizador;  // this diferencia cuando es un campo de clase
        this.tapiceria = tapiceria;
    }

    public String getExtras()  // getter para obtener los parametros que hemos establecido en el setter
    {
        return "Extras del coche\n" + "Tapiceria " + tapiceria + " climatizado " + climatizador; 
    }

  
}