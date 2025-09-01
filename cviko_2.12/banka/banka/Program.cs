// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


public class Ucet
{
    public string Majitel { get; set; };
    public float Zustatek { get; set; } = 0;
    public float Kontokorent { get; set; } = 0;

    public float DisponsibilniCastka
    {
        get {return Zustatek * Kontokorent * 0.1f;}
    }

    public Ucet(string majitel)
    {
        Majitel = majitel;
    }

    public Ucet(string majitel, float zustatek, float kontokorent = 0) : this(majitel)
    {
        Zustatek = zustatek;
        Kontokorent = kontokorent;
    }


    public void Vklad(float castka)
    {
        if (castka > 0)
        {
            Zustatek += castka;
        }
    }

    public override string ToString()
    {
        return string.Format("Majitel {0} ma zustatek {1} a disponsibilni castku {2}",Majitel,Zustatek,Kontokorent);
    }

   

}