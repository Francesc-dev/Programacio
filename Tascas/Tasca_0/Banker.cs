namespace Tasca_0;

public class Banker
{
    private Dictionary<string, Client> clients;

    public Banker()
    {
        clients = new Dictionary<string, Client>();
    }

    public void CreaClient(string nomNouClient)
    {
        clients.Add(nomNouClient, new Client(nomNouClient));
    }

    public void EliminaClient(string nomClient)
    {
        clients.Remove(nomClient);
    }
    
    public string VeureDiners(string nomClient)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            return $"{nomClient}: Téns actualment {client.Saldo} €";
        }
        return $"Tu no ets client {nomClient}"; 
    }
    
    public bool ClientExisteix(string nomClient)
    {
        if (clients.ContainsKey(nomClient))
        {
            return true;
        }
        Console.WriteLine($"Tu no ets client {nomClient}");
        return false; 
    }
    
    public string PosarDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            client.Saldo += quantitat;
            return $"{nomClient}: {quantitat} € ingressats correctament";
        }
        return $"Tu no ets client {nomClient}";
    }

    public string TreureDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            var comissio = (int)quantitat / 100;
            if (quantitat + comissio > client.Saldo)
            {
                return $"{nomClient}: No tens {quantitat + comissio} € prou diners";
            }

            client.Saldo -= quantitat + comissio;
            return $"{nomClient}: Té {quantitat} € et queden {client.Saldo} €";
        }

        return $"Tu no ets client {nomClient}";
    }
}