
internal class Program
{
    private static void Main(string[] args)
    {
        int[] edades;
        edades = new int[4];

        edades[0] = 1;
        edades[1] = 2;
        edades[2] = 3;
        edades[3] = 4;

        Console.WriteLine(edades[2]);

        int[] edades2 = { 1, 2, 3, 4 };
        // int [] edades2 = new int [4] // tb es válido

        Console.WriteLine(edades2[2]);

        // array implicito

        var datos = new[] { "Juan", "Brenes", "Marbella" };

        var valores = new[] { 18, 28, 75.5, 30.30, 58 };  // le dará a la variable valor tipo double

        // bucle for

        for (int i = 0; i < 5; i++)
        // for(int i = 0; i<=4;i++)    otra manera de decir lo mismo
        // for(int y= 0; y<valores.Length; y++)  //otra manera con el método lenght
        {
            Console.WriteLine(valores[i]);
        }
        // array de objetos

        Empleados[] arrayEmpleados = new Empleados[2]; // creamos el array de objeto

        arrayEmpleados[0] = new Empleados("Pedro", 45);  //creamos el objeto y almacenamos los datos

        Empleados Ana = new Empleados("Ana", 27);   // creamos otro objeto llamado Ana

        arrayEmpleados[1] = Ana;  // almacenamos el objeto Ana en la posicion numero 1 del array



        // array de tipos o clases anónimas

        var personas = new[]
        {
            new{Nombre="Juan", Edad= 45},
            new{Nombre="Maria", Edad= 35},
            new{Nombre="Antonio", Edad=12},
            new{Nombre="Julia",Edad=28}
        };

        for (int i = 0; i < arrayEmpleados.Length; i++)
        {
            Console.WriteLine(arrayEmpleados[i].getInfo());
        }


        // bucle for-each

        foreach(Empleados variable in arrayEmpleados)
        {
            Console.WriteLine(variable.getInfo());
        }

        //otro ejemplo del array valores

        foreach(double variable in valores)
        {
            Console.WriteLine(variable);
        }
    }
    class Empleados   //clase
    {
        public Empleados(String nombre, int edad)  // constructor
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public String getInfo()
        {
            return "Nombre " + nombre + " Edad " + edad;
        }
        String nombre;
        int edad;
    }
}
