

internal class MetodoVoid
{
    int numero1 = 5;
    int numero2 = 6;

    private static void Main(string[] args)
    {
        mensajeEnPantalla();

        Console.WriteLine("Mensaje desde el main");

        sumaNumeros(9,5); // le añadimos los parametros que hemos definidos en el método

        Console.WriteLine(sumaNumeros2(7,9));  // para invocar el método con un return tenemos que usar un Consolo.WriteLine para invocarlo
        Console.WriteLine(divisionNumeors(18,3));

        //Ahora imprimimos los métodos sobrecargados ya definidos 

        Console.WriteLine(Suma(10,10));
        Console.WriteLine(Suma(8,9,6));

        Console.WriteLine(Multi(8,8));
    }

    private static int Multi(int v1, int v2)
    {
        return v1 * v2;
    }

    static void mensajeEnPantalla()   // le ponemos static para que pueda ser llamado desde el main
    {
        Console.WriteLine("Mensaje desde el método MensajeEnPantalla");
    }

    static void sumaNumeros(int num1, int num2)  // todos los métodos void no retornan valor
    {
        Console.WriteLine($"La suma de los numeros es {num1 + num2}");
    }

    static int sumaNumeros2(int num1, int num2)  // método con return

    {
        return num1 + num2;
    }

    static double divisionNumeors(double num1, int num2) => num1 / num2;  // con la flecha simplificamos el return 

    static double divisionNumero2(double num1, int num2)   // otra menera de realizar el método como hay varias lineas no podemos simplificar con la flecha
    {
        double resultado;
        resultado = num1 / num2;

        return resultado;
    }

    void primerMetodo()
    {
     
        Console.WriteLine(numero1+numero2);  // hemos declarado las variables al principio de la clase
    }

    //vamos a realizar sobrecarga de métodos

    static int Suma(int operador1, int operador2) => operador1 + operador2;

    static int Suma(int operador1, int operador2, int operador3) => operador1 + operador2 + operador3;

    // tenemos dos métodos con el mismo nombre pero reciben un numero diferente de parametros


}