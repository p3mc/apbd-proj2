using System.Security.AccessControl;

namespace sprzet;

public abstract class Sprzet
{
    public static int Count = 1;
    public static List<Sprzet> wyposazenie = new List<Sprzet>();
    
    public bool Dostepny { get; set; }
    public string Nazwa { get; set; }
    public int Id { get; set; }

    public Sprzet(string nazwa)
    {
        Id = Count++;
        Dostepny = true;
        Nazwa = nazwa;
        wyposazenie.Add(this);
    }

    public static void Pokaz()
    {
        Console.WriteLine();
        Console.WriteLine("Sprzet:");
        foreach (Sprzet s in wyposazenie)
        {
            Console.WriteLine(s.Nazwa + " " + s.Dostepny);
        }
    }

    public static void PokazDostepne()
    {
        Console.WriteLine();
        Console.WriteLine("Dostepny sprzet:");
        foreach (Sprzet s in wyposazenie)
            {
                if (s.Dostepny) Console.WriteLine(s.Nazwa + " " + s.Dostepny);
            }
    }
    
}