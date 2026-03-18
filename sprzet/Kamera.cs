namespace sprzet;

public class Kamera : Sprzet
{
    public int MPX { get; set; }
    public bool HasOpticalZoom { get; set; }
    
    public Kamera(string nazwa, int mpx, bool hasOpticalZoom) : base(nazwa)
    {
        MPX = mpx;
        HasOpticalZoom = hasOpticalZoom;
    }
}