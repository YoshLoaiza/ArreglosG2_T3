using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");
        MiArreglo oMiArreglo = new MiArreglo(5);
        try
        {
            oMiArreglo.Agregar(10);
            oMiArreglo.Agregar(5);
            oMiArreglo.Agregar(-4);
            Console.WriteLine(oMiArreglo);
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine(oMiArreglo);

        Console.ReadKey();
    }
}
