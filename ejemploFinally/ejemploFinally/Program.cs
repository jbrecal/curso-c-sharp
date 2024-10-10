internal class Program
{
    private static void Main(string[] args)
    {
        System.IO.StreamReader archivo = null;

        try
        {
            string linea;
            int contador = 0;
            string patch = @"C:\\Users\\brene\\Desktop\\Curso C#\\ejemploFinally\\prueba.txt";

            archivo = new System.IO.StreamReader(patch);

            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);

                contador++;
            }
            

        }
        catch (Exception e)
        {
            Console.WriteLine("Error con la lectura del archivo");
        }
    }
}