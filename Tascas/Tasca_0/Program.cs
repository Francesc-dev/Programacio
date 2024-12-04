namespace Tasca_0;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new Banker();
        
        banquer.CreaClient("Frederic");
        
        Console.WriteLine(banquer.PosarDiners("Frederic", 100));
        Console.WriteLine(banquer.TreureDiners("Frederic", 200));
        Console.WriteLine(banquer.TreureDiners("Frederic", 10));
        
        Console.WriteLine(banquer.TreureDiners("Manel", 50));
        banquer.CreaClient("Manel");
        Console.WriteLine(banquer.PosarDiners("Manel", 5));
    }
}