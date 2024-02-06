Menu();
void Menu()
{
    Console.WriteLine("Witamy w wypożyczalni samochodowej!");
    Console.WriteLine("Jaką operację chcesz wykonać?");
    Console.WriteLine("1.Dodaj pojazd");
    Console.WriteLine("2.Usuń pojazd");
    Console.WriteLine("3.Wyświetl listę pojazdów");
    Console.WriteLine("4.Wyjdź z aplikacji");
    int wybor = (int)InputDouble();

    switch (wybor)
    {
        case 1: Console.WriteLine("he"); break;
        case 2: Console.WriteLine("he"); break;
        case 3: Console.WriteLine("he"); break;
        case 4: Console.WriteLine("he"); break;
    }
    
}

double InputDouble()
{
    Console.WriteLine("Podaj wartosc: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}






















