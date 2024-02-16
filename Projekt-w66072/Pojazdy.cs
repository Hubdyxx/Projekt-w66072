using CsvHelper.Configuration.Attributes;

namespace Projekt_w66072;

class Pojazdy
{
    public string Marka { get; }
    public string Model { get; }
    public string NumerRejestracyjny { get; }
    public double PojemnoscSilnika { get; }
    public string RodzajPaliwa { get; }

    public Pojazdy([Name("Marka")]string marka, [Name("Model")]string model, [Name("NumerRejestracyjny")]string numerRejestracyjny, [Name("PojemnoscSilnika")]double pojemnoscSilnika, [Name("RodzajPaliwa")]string rodzajPaliwa)
    {
        Marka = marka;
        Model = model;
        NumerRejestracyjny = numerRejestracyjny;
        PojemnoscSilnika = pojemnoscSilnika;
        RodzajPaliwa = rodzajPaliwa;
    }

    public virtual void Informacje()
    {
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Numer rejestracyjny: {NumerRejestracyjny}");
        Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika}");
        Console.WriteLine($"Rodzaj paliwa: {RodzajPaliwa}");
    }
}
