namespace sprzet;

public class Laptop : Sprzet
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public Laptop(string nazwa, string cpu, string gpu) : base(nazwa)
    {
        GPU = gpu;
        CPU = cpu;
    }
}