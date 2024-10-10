using System.Reflection.Metadata.Ecma335;

internal class Punto
{
    public Punto(int x, int y)
    {
        this.y = y;
        this.x = x;
        contadorDeObjetos++;
    }

    public Punto() 
    {
        this.x=0;
        this.y=0;

        contadorDeObjetos++;
    }

    public double DistanciaHasta(Punto otroPunto)  // un metodo que recibe por parametro un objeto
    {
        int xDif=this.x - otroPunto.x;
        int yDif=this.y - otroPunto.y;

        double distanciaPuntos = Math.Sqrt(Math.Pow(xDif,2) + Math.Pow(yDif,2));
        return distanciaPuntos;
    }
    private int x, y;

    private static int contadorDeObjetos = 0;  // contador general de objetos

    public static int getContadorDeObjetos() => contadorDeObjetos;
}