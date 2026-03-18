namespace sprzet;

public class Kamera : Sprzet
{
    public Kamera(string nazwa)
    {
        Id = Count++;
        Dostepnosc = true;
        Nazwa = nazwa;
    }
}