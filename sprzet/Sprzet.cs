namespace sprzet;

public abstract class Sprzet
{
    public static int Count = 1;
    
    public bool Dostepnosc { get; set; }
    public string Nazwa { get; set; }
    public int Id { get; set; }

    public Sprzet(string nazwa)
    {
        Id = Count++;
        Dostepnosc = true;
        Nazwa = nazwa;
    }
}