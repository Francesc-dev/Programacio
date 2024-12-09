namespace Tasca_1;

class Program
{
    static void Main(string[] args)
    {
        int Jugador1 = 10;
        int Jugador2 = 10;
        string jugador1 = ("");
        string jugador2 = ("");

        while(Jugador1 != 0 && Jugador2 != 0)
        {
            jugador1 = Golpe(golpe: null);
            jugador2 = NoBloq(nobloq: null);
            if (jugador1 == jugador2)
            {
                Jugador2 -= 1;
                Console.WriteLine($"Jugador 2: Te quedan {Jugador2} vidas");
            }
            jugador2 = Golpe(golpe: null);
            jugador1 = NoBloq(nobloq: null);
            if (jugador1 == jugador2)
            {
                Jugador1 -= 1;
                Console.WriteLine($"Jugador 1: Te quedan {Jugador1} vidas");
            }
        }
    }

        public static string Golpe(string golpe)  
        {
            Random randompunch = new Random();
            int numero = randompunch.Next(0, 3);
            golpe = numero switch
            {
                0 => "cabeza",
                1 => "hombro derecho",
                2 => "hombro izquierdo",
                3 => "abdomen",
            };
            return golpe;
        }
        public static string NoBloq(string nobloq)
        {
            Random randomnobloq = new Random();
            int numero = randomnobloq.Next(0, 3);
            nobloq = numero switch
            {
                0 => "cabeza",
                1 => "hombro derecho",
                2 => "hombro izquierdo",
                3 => "abdomen",
            };
            return nobloq;
        }
}