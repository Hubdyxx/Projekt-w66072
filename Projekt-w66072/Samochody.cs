namespace Projekt_w66072;

class Samochody : Pojazdy
{
    public Samochody(string marka, string model, string numerRejestracyjny, double pojemnoscSilnika, string rodzajPaliwa)
        : base(marka, model, numerRejestracyjny, pojemnoscSilnika, rodzajPaliwa)
    {
    }

    public override void Informacje()
    {
        base.Informacje();
        Console.WriteLine("Rodzaj pojazdu: Samochód");
    }
}