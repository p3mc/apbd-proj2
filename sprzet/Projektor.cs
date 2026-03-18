namespace sprzet;

public class Projektor : Sprzet
{
    public Projektor(string nazwa)
    {
        Id = Count++;
        Dostepnosc = true;
        Nazwa = nazwa;
    }
}