using System;

Console.Write("Ile ocen? ");
int n = int.Parse(Console.ReadLine());
double suma = 0;

for (int i = 0; i < n; i++)
{
    Console.Write("Podaj ocenę: ");
    suma += double.Parse(Console.ReadLine());
}

double srednia = suma / n;
Console.WriteLine($"Średnia: {srednia:F1}");

if (srednia >= 3.0) 
    Console.WriteLine("Zaliczone!");
else 
    Console.WriteLine("Niezaliczone.");
