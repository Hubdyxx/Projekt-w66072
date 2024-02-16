using System;
using System.IO;
using Projekt_w66072;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu();
        }
    }

    static void Menu()
    {
        Console.WriteLine("Witamy w wypożyczalni samochodowej!");
        Console.WriteLine("Jaką operację chcesz wykonać?");
        Console.WriteLine("1. Dodaj pojazd");
        Console.WriteLine("2. Usuń dane pojazdów");
        Console.WriteLine("3. Wyświetl listę pojazdów");
        Console.WriteLine("4. Wyjdź z aplikacji");

        int wybor = InputInt();

        switch (wybor)
        {
            case 1:
                DodajPojazd();
                break;
            case 2:
                UsunPojazd();
                break;
            case 3:
                WyswietlListePojazdow();
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Nieprawidłowy wybór.");
                break;
        }
    }

    static int InputInt()
    {
        Console.WriteLine("Podaj wartość: ");
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Nieprawidłowe dane. Podaj ponownie:");
        }
        return value;
    }

    static void DodajPojazd()
    {
        var conf = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ",",
            HasHeaderRecord = true,
            TrimOptions = TrimOptions.Trim,
            MissingFieldFound = null,
        };
        using var reader = new StreamReader("/Users/hubdyxx/RiderProjects/Projekt-w660722/Projekt-w66072/projekt.txt");
            using var csvR = new CsvReader(reader, conf); 
            var records = csvR.GetRecords<Pojazdy>().ToList();
        
        
        Console.WriteLine("Podaj dane nowego pojazdu:");

        Console.WriteLine("Rodzaj pojazdu (1 - Samochód, 2 - Motocykl):");
        int rodzaj = InputInt();

        Console.WriteLine("Marka:");
        string marka = Console.ReadLine();

        Console.WriteLine("Model:");
        string model = Console.ReadLine();

        Console.WriteLine("Numer rejestracyjny:");
        string numerRejestracyjny = Console.ReadLine();

        Console.WriteLine("Pojemność silnika:");
        double pojemnoscSilnika;
        while (!double.TryParse(Console.ReadLine(), out pojemnoscSilnika))
        {
            Console.WriteLine("Nieprawidłowe dane. Podaj ponownie:");
        }

        Console.WriteLine("Rodzaj paliwa:");
        
        string rodzajPaliwa = Console.ReadLine();

        var pojazd = new Pojazdy(marka, model, numerRejestracyjny, pojemnoscSilnika, rodzajPaliwa);
        records.Add(pojazd);
        using (var writer = new StreamWriter("/Users/hubdyxx/RiderProjects/Projekt-w660722/Projekt-w66072/projekt.txt"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(records);
            writer.Flush();
            
        }

        Console.WriteLine("Pojazd został dodany.");
    }

    static void UsunPojazd()
    {
        File.WriteAllText("/Users/hubdyxx/RiderProjects/Projekt-w660722/Projekt-w66072/projekt.txt", "");
        Console.WriteLine("Dane pojazdów zostały usunięte.");
    }

    static void WyswietlListePojazdow()
    {
       
       var conf = new CsvConfiguration(CultureInfo.InvariantCulture)
       {
           Delimiter = ",",
           HasHeaderRecord = true,
           TrimOptions = TrimOptions.Trim,
           MissingFieldFound = null,
           
       };
       using (var reader = new StreamReader("/Users/hubdyxx/RiderProjects/Projekt-w660722/Projekt-w66072/projekt.txt"))
        using (var csv = new CsvReader(reader, conf))
        {
            var records = csv.GetRecords<Pojazdy>();
            foreach (var pojazd in records)
            {
                Console.WriteLine($"Marka: {pojazd.Marka}");
                Console.WriteLine($"Model: {pojazd.Model}");
                Console.WriteLine($"Numer rejestracyjny: {pojazd.NumerRejestracyjny}");
                Console.WriteLine($"Pojemność silnika: {pojazd.PojemnoscSilnika}");
                Console.WriteLine($"Rodzaj paliwa: {pojazd.RodzajPaliwa}");
                Console.WriteLine(); 
            }
        }
       
    }
}
