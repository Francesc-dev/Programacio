namespace Tasca_1;

public class Boxeador
{
    public Boxeador(string nomBoxeador)
    {
        Nom = nomBoxeador;
        Vidas = 10;
    }
    
    public string Nom { get; }
    public int Vidas { get; set; }

    public string Pelea ()
    {
        Random random = new Random();
        int numero = random.Next(0, 3);
        string golpe = numero switch
        {
            0 => "cabeza",
            1 => "hombro derecho",
            2 => "hombro izquierdo",
            3 => "abdomen",
        };
        return golpe;
    }
    
    public void PierdeVida ()
    {
        Vidas -= 1;
    }
    
    public bool KO () {
        if (Vidas == 0)
        {
            return true;
        }
        return false;
    }
}