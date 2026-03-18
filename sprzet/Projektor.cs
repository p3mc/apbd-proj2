namespace sprzet;

public class Projektor : Sprzet
{
    public string Rozdzielczosc { get; set; }
    public int Lumens { get; set; }
    public Projektor(string nazwa, string rozdzielczosc, int lumens) :  base(nazwa)
    {
        Rozdzielczosc = rozdzielczosc;
        Lumens = lumens;
    }
}