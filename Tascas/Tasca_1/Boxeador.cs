namespace Tasca_1;

public class Boxeador
{
    public string Golpe(string golpe)  
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
    public string NoBloq(string nobloq)
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