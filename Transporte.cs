
namespace Ejercicio4_G2_2024_1
{
    internal abstract class Transporte
    {
        internal int velocidad = 50;


        #region Property
        public int Velocidad 
        { 
            get => velocidad; 
            set
            {    if (value < 0)
                {
                    velocidad = 20;
                }
                else
                {
                    velocidad = value;
                }
            }
        }
        #endregion

        #region Métodos
        public virtual void Acelerar()
        {
            Console.WriteLine("Tu AUTOMOVIL está acelerando ...");
            Console.WriteLine("Velocidad: {0} km/h", velocidad);
            for (int i = 0; i <= 10 ; i++)
            {
                Console.WriteLine("{0} km/h",velocidad = velocidad + 5);
                Thread.Sleep(500);
            }
            Console.WriteLine("Tu velocidad es de {0} km/h", velocidad);
        }
        public virtual void Frenar()
        {
            velocidad = 55;
            Console.WriteLine("Tu AUTOMOVIL está frenando ...");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} km/h", velocidad = velocidad - 5);
                Thread.Sleep(500);
            }
            Console.WriteLine("Tu velocidad es de {0} km/h", velocidad);
        }
        public virtual string MostrarOpciones()
        {
            string elegir = "";
            Console.WriteLine("¿Te gustaría acelerar (1) o frenar (2)?");
            elegir = Console.ReadLine();

            return elegir;
        }
        public void Opcion(string elegir)
        {  

            switch (elegir) 
            {
                case "1":
                    Acelerar();
                    break;
                case "2":
                    Frenar();
                    break;
                default:
                    Console.WriteLine("Opción invalida");
                    break;
            }
        }
        #endregion
    }
}
