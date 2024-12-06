using System.Linq.Expressions;

namespace Tasca_0;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new Banker();

        Console.WriteLine("¿Que quieres hacer?");
        Console.WriteLine("Crear (1), Mover (2) o Eliminar (3)");
        string Leer = Console.ReadLine();

        switch (Leer)
        {
            case "1":
                Console.WriteLine("Ingrese el nuevo nombre del usuario");
                string crearnom = Console.ReadLine();
                banquer.CreaClient(crearnom);
                break;
            case "2":
                Console.WriteLine("Ingrese el nombre del usuario existente");
                string nomexistent = Console.ReadLine();
                banquer.CreaClient(nomexistent);
                Console.WriteLine(banquer.VeureDiners());
                Console.WriteLine("¿Quieres Ingresar (1) o Retirar (2)");
                string IoR = Console.ReadLine();
                switch (IoR)
                {
                    case "1":
                        Console.WriteLine("¿Quanto quieres Ingresar?");
                        int Ingresar = int.Parse(Console.ReadLine());
                        Console.WriteLine(banquer.PosarDiners(nomexistent, Ingresar));
                        Console.WriteLine(banquer.TreureDiners("Frederic", 200));
                        break;
                    case "2":
                        Console.WriteLine("¿Quanto quieres Retirar?");
                        int Retirar = int.Parse(Console.ReadLine());
                        break;
                }
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Ingresa una opción valida");
                break;
        }
    }
}