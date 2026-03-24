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
        if ((uzytkownik.GetWypozyczenia().Count >= 2 && (int)uzytkownik.GetUserType() == 0) ||
            ((int)uzytkownik.GetUserType() == 1 && uzytkownik.GetWypozyczenia().Count >= 5))
        {
            throw new Exception("Nie mozna wypozyczyc danemu uzytkownikowi.");
        }
        this.uzytkownik = uzytkownik;
        this.sprzet = sprzet;
        this.odData = odData;
        this.period = period;
        ZwrotNaCzas = false;
        uzytkownik.NoweWypozyczenie(this);
            
    }

    override public string ToString()
    {
        return uzytkownik.ToString() + " " + sprzet.Nazwa + " " + ZwrotNaCzas;
    }
}