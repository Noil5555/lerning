namespace Holz;

class arten
{
    public string Eiche { get; private set; }
    public string Fichte { get; private set; }
    public string Buche { get; private set; }
    public string Lärche { get; private set; }
    public string Birke { get; private set; }
    public string Tanne { get; private set; }

    public arten(string eiche, string fichte, string buche, string tanne, string birke, string lärche)
    {
        Eiche = eiche;
        Fichte = fichte;
        Buche = buche;
        Tanne = tanne;
        Birke = birke;
        Lärche = lärche;
    }

    public void eichenvergleich(string eiche)
    {
        bool richtigeich = false;
        Console.WriteLine("Welches Holz ist das?");
        string userimput = Console.ReadLine().ToLower();

        if (userimput == "eiche")
        {
            richtigeich = true;
        }
    }

    public void fichtevergleich(string fichte)
    {
        bool richtigfich = false;
        Console.WriteLine("Welches Holz ist das?");
        string userimput = Console.ReadLine().ToLower();

        if (userimput == "fichte")
        {
            richtigfich = true;
        }
    }


    public void birkevergleich(string birke)
    {
        bool richtigbirk = false;
        Console.WriteLine("Welches Holz ist das?");
        string userimput = Console.ReadLine().ToLower();

        if (userimput == "birke")
        {
            richtigbirk = true;
        }
    }
    //lärche und tanne fehlen
    public void lärchevergleich()
    {
        bool richtiglärch = false;
        Console.WriteLine("Welches Holz ist das?");
        string userimput = Console.ReadLine().ToLower();

        if (userimput == "lärche")
        {
            richtiglärch = true;
        }
    }

    public void tennenverleich()
    {
        bool richtigtann = false;
        Console.WriteLine("Welches Holz ist das?");
        string userimput = Console.ReadLine().ToLower();

        if (userimput == "tanne")
        {
            richtigtann = true;
        }
    }
}