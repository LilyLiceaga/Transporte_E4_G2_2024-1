namespace Ejercicio4_G2_2024_1
{
    internal class Automovil : Transporte
    {
        public Automovil() 
        {
            int velocidad = 50;
            Console.WriteLine("Tu AUTOMOVIL se encuentra a una velocidad de {0} km/h", velocidad);
            string elegir = MostrarOpciones();
            Opcion(elegir);
            Console.ReadLine();
        }
            
    }
}
