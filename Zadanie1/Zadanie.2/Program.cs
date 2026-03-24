using System;

Console.Write("Wybierz kierunek (C - Celsjusza na Fahrenheita, F - Fahrenheita na Celsjusza): ");
string wybor = Console.ReadLine().ToUpper();

Console.Write("Podaj wartość temperatury: ");
double temp = double.Parse(Console.ReadLine());

if (wybor == "C")
{
    double wynik = (temp * 9 / 5) + 32;
    Console.WriteLine($"{temp}°C to {wynik}°F");
}
else if (wybor == "F")
{
    double wynik = (temp - 32) * 5 / 9;
    Console.WriteLine($"{temp}°F to {wynik}°C");
}
else
{
    Console.WriteLine("Nieprawidłowy wybór.");
}
