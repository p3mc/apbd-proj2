namespace sprzet;

public class Wypozyczenie
{
    public static int Count = 0;
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

        if (sprzet.Dostepny == false)
        {
            throw new Exception("Sprzet niedostepny.");
        }
        
        this.uzytkownik = uzytkownik;
        this.sprzet = sprzet;
        sprzet.Dostepny = false;
        this.odData = odData;
        this.period = period;
        ZwrotNaCzas = true;
        uzytkownik.NoweWypozyczenie(this);
        Count++;
            
    }

    public void Zwroc(bool CzyNaCzas)
    {
        sprzet.Dostepny = true;
        uzytkownik.ExpiredWypozyczenie(this);
        uzytkownik.GetWypozyczenia().Remove(this);
        ZwrotNaCzas = CzyNaCzas;
        if (!CzyNaCzas) uzytkownik.DodajKare(5.0);
        Count--;
    }

    override public string ToString()
    {
        return uzytkownik.ToString() + " " + sprzet.Nazwa + " " + ZwrotNaCzas;
    }
}