namespace Tasca_1;

class Program
{
    static void Main(string[] args)
    {
        var boxeador = new Boxeador();
        
        int Jugador1 = 10;
        int Jugador2 = 10;
        string jugador1 = ("");
        string jugador2 = ("");

        while(Jugador1 != 0 && Jugador2 != 0)
        {
            boxeador.Golpe(jugador1);
            boxeador.NoBloq(jugador2);
            if (jugador1 == jugador2)
            {
                Jugador2 -= 1;
                Console.WriteLine($"Jugador 2: Te quedan {Jugador2} vidas");
            }
            boxeador.Golpe(jugador1);
            boxeador.NoBloq(jugador2);
            if (jugador1 == jugador2)
            {
                Jugador1 -= 1;
                Console.WriteLine($"Jugador 1: Te quedan {Jugador1} vidas");
            }
        }
    }
}