using InterfacesOtroEjemplo;

internal class Program
{
    private static void Main(string[] args)
    {
       AvisosTrafico av1 = new AvisosTrafico();

        av1.mostrarAviso();

        // vamos a crear otro objeto de la clase AvisosTrafico pero añadiendo los parametros del otro constructor

        AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial de Málaga","Sanción de velocidad: 300€","02-02-2024"); 
        
        av2.mostrarAviso();

        Console.WriteLine(av2.getFecha());  // el método getFecha es void así que tiene que ir en un cw
    }
}

