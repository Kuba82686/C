using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        string operacja = Console.ReadLine();

        double wynik = 0;
        bool blad = false;

        if (operacja == "+")
        {
            wynik = a + b;
        }
        else if (operacja == "-")
        {
            wynik = a - b;
        }
        else if (operacja == "*")
        {
            wynik = a * b;
        }
        else if (operacja == "/")
        {
            if (b != 0)
                wynik = a / b;
            else
            {
                Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                blad = true;
            }
        }
        else
        {
            Console.WriteLine("Nieznana operacja.");
            blad = true;
        }

        if (!blad)
        {
            Console.WriteLine($"Wynik: {wynik}");
        }
    }
}
