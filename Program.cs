using Ejercicio4_G2_2024_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("¿Que vehiculo deseas usar? \n(1) automóvil \n(2) tractor");
        string tipoVehiculo = Console.ReadLine();

        switch (tipoVehiculo)
        {
            case "1":
                var miAutomovil = new Automovil();
                break;
            case "2":
                var miTractor = new Tractor();
                break;
            default:
                Console.WriteLine("Opción invalida");
                break;
        }
    }
}