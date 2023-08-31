
namespace Ejercicio4_G2_2024_1
{
    internal class Tractor : Transporte
    {
        int velocidad = 35;
        public override void Acelerar()
        {
            Console.WriteLine("Tu TRACTOR está acelerando ...");
            Console.WriteLine("Velocidad: {0} km/h", velocidad);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} km/h", velocidad = velocidad + 5);
                Thread.Sleep(500);
            }
            Console.WriteLine("Tu velocidad es de {0} km/h", velocidad);
        }
        public override void Frenar()
        {
            Console.WriteLine("Tu TRACTOR está frenando ...");
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("{0} km/h", velocidad = velocidad - 5);
                Thread.Sleep(500);
            }
            Console.WriteLine("Tu velocidad es de {0} km/h", velocidad);
        }
        public Tractor()
        {
            Console.WriteLine("Tu TRACTOR se encuentra a una velocidad de {0} km/h", velocidad);
            string elegir = MostrarOpciones();
            Opcion(elegir);
            Console.ReadLine();
        }
    }
}
