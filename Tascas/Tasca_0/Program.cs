using System.Linq.Expressions;

namespace Tasca_0;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new Banker();
        while(true)
        {
            Thread.Sleep(1000);
            Console.WriteLine("¿Què vols fer?");
            Thread.Sleep(1000);
            Console.WriteLine("(1) Crear, (2) Moure, (3) Eliminar o (4) Sortir");
            string Opciones = Console.ReadLine();

            switch (Opciones)
            {
                case "1":
                    Console.WriteLine("Introduïu el nom nou de l'usuari");
                    string crearclient = Console.ReadLine();
                    banquer.CreaClient(crearclient);
                    Console.WriteLine("Usuari creat correctament");
                    break;
                case "2":
                    Console.WriteLine("Introduïu el nom de l'usuari existent");
                    string nomexistent = Console.ReadLine();
                    if (banquer.ClientExisteix(nomexistent))
                    {
                        Console.WriteLine("¿Que moviment vols fer?");
                        Thread.Sleep(1000);
                        Console.WriteLine(
                            "(1) Ingressar, (2) Retirar, (3) Veure els diners, (4) Tornar o (5) Sortir");
                        string IoR = Console.ReadLine();
                        switch (IoR)
                        {
                            case "1":
                                Console.WriteLine("¿Quant vols Ingressar?");
                                int Ingresar = int.Parse(Console.ReadLine());
                                Console.WriteLine(banquer.PosarDiners(nomexistent, Ingresar));
                                break;
                            case "2":
                                Console.WriteLine("¿Quant vols Retirar?");
                                int Retirar = int.Parse(Console.ReadLine());
                                Console.WriteLine(banquer.TreureDiners(nomexistent, Retirar));
                                break;
                            case "3":
                                Console.WriteLine(banquer.VeureDiners(nomexistent));
                                break;
                            case "4":
                                break;
                            case "5":
                                return;
                            default:
                                Console.WriteLine("Introduïu una opció vàlida");
                                break;
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Introduïu el nom del compte que voleu suprimir");
                    string eliminaclient = Console.ReadLine();
                    banquer.EliminaClient(eliminaclient);
                    Console.WriteLine("Client suprimit correctament");
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Introduïu una opció vàlida");
                    break;
            }
        }
    }
}