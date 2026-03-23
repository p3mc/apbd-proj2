namespace sprzet;

public class Wypozyczenie
{
    Uzytkownik uzytkownik;
    Sprzet sprzet;
    private bool ZwrotNaCzas { get; set; }
    DateTime odData { get; set; }
    int period { get; set; }

    public Wypozyczenie(Uzytkownik uzytkownik, Sprzet sprzet, DateTime odData, int period)
    {
        this.uzytkownik = uzytkownik;
        this.sprzet = sprzet;
        this.odData = odData;
        this.period = period;
        ZwrotNaCzas = false;
    }
}