namespace sprzet;

public enum UserType
{
    Student = 0,
    Employee = 1
}

public class Uzytkownik
{
    public static int Count = 1;
    UserType userType;
    private string name, surname;
    List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();
    private List<Wypozyczenie> expiredWypozyczenia = new List<Wypozyczenie>();
    public double Kary { get; set; } = 0;
    
    public int Id { get; set; }
    
    public Uzytkownik(UserType userType, string name, string surname)
    {
        this.userType = userType;
        this.name = name;
        this.surname = surname;
        Id = Count++;
    }

    public UserType GetUserType()
    {
        return userType;
    }

    public List<Wypozyczenie> GetWypozyczenia()
    {
        return wypozyczenia;
    }

    public void NoweWypozyczenie(Wypozyczenie w)
    {
        wypozyczenia.Add(w);
    }

    public void ExpiredWypozyczenie(Wypozyczenie w)
    {
        expiredWypozyczenia.Add(w);
    }

    public void ListaExpiredWypozyczen()
    {
        Console.WriteLine();
        Console.WriteLine($"Wygasle wypozyczenia uzytkownika {Id}:");
        foreach (var w in expiredWypozyczenia)
        {
            Console.WriteLine(w);
        }
    }

    public void ListaWypozyczen()
    {
        Console.WriteLine();
        Console.WriteLine($"Wypozyczenia uzytkownika {Id}:");
        foreach (var w in wypozyczenia)
            {
            Console.WriteLine(w);
            }
    }

    override public string ToString()
    {
        return name + " " + surname + "(" + Id + ")";
    }

    public void DodajKare(double kara)
    {
        Kary += kara;
    }

    public void UsunKare()
    {
        Kary = 0;
    }
}