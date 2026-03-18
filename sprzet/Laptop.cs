namespace sprzet;

public class Laptop : Sprzet
{
    public Laptop(string nazwa)
    {
        Id = Count++;
        Dostepnosc = true;
        Nazwa = nazwa;
    }
}