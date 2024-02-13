namespace Projekt_w66072;

public class Pojazdy
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string NumerRejestracyjny { get; set; }
    public double PojemnoscSilnika { get; set; }
    public string RodzajPaliwa { get; set; }

    public Pojazdy(string marka, string model, string numerRejestracyjny, double pojemnoscSilnika, string rodzajPaliwa)
    {
        Marka = marka;
        Model = model;
        NumerRejestracyjny = numerRejestracyjny;
        PojemnoscSilnika = pojemnoscSilnika;
        RodzajPaliwa = rodzajPaliwa;
    }
}