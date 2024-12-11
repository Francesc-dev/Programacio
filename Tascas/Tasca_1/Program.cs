namespace Tasca_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el nombre del boxeador 1");
        string Jugador1 = Console.ReadLine();
        var boxeador1 = new Boxeador(Jugador1);
        Console.WriteLine("Introduce el nombre del boxeador 2");
        string Jugador2 = Console.ReadLine();
        var boxeador2 = new Boxeador(Jugador2);
        
        int ronda = 0;
        
        while (!boxeador1.KO() && !boxeador2.KO())
        {
            ronda++;
            string Golpe = boxeador1.Pelea();
            string NoBloq = boxeador2.Pelea();
            if (Golpe == NoBloq)
            {
                if (ronda % 2 == 0)
                {
                    boxeador2.PierdeVida();
                    Console.WriteLine($"Ronda {ronda}: {boxeador1.Nom} da un golpe en {Golpe} a {boxeador2.Nom} y pierde una vida le quedan {boxeador2.Vidas} vidas.");
                }
                else
                {
                    boxeador1.PierdeVida();
                    Console.WriteLine($"Ronda {ronda}: {boxeador2.Nom} da un golpe en {NoBloq} a {boxeador1.Nom} y pierde una vida le quedan {boxeador1.Vidas} vidas.");
                }
            }
        }
    }
}