using System;

namespace ExcepcionesTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Jugar cancha = new Jugar() { Nombre = "Michael", NumeroDeJugadores = 1 };
                cancha.NumeroDeJugadores = 11;
                if (cancha.NumeroDeJugadores >= 10)
                {
                    throw new DiversionException("Si esta cansado");
                }
            }
            catch (DiversionException)
            {
                Console.WriteLine("Sientate y descansa");
            }
            catch (Exception)
            {
                Console.WriteLine("El jugador salio de la cancha");
            }
        }
        public class DiversionException : Exception
        {
            public DiversionException(string message): base(message)
            {

            }
        }
        public class Jugar
        {
            public string Nombre { get; set; }
            public int NumeroDeJugadores { get; set; }
        }
    }
}
