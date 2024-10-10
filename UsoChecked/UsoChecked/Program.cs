internal class Program
{
    private static void Main(string[] args)


    {
        checked   // con el cheked obligamos a que se genere una excepción y no se pase por alto el error
        {
            int numero = int.MaxValue;  // así podemos saber el valor máximo de la variable int
            Console.WriteLine(numero + 20);  // debería de haber un desbordamiento pero nos da un resultado erroneo en negativo
                                             // esto en ocasiones no nos vendrá bien porque necesitaremos que nos genere una excepcion
        }
    }
}