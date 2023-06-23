using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę elementów ciągu Fibonacciego do wygenerowania:");
        string input = Console.ReadLine();
        int n;

        while (!int.TryParse(input, out n) || n < 1)
        {
            Console.WriteLine("Nieprawidłowa liczba. Podaj liczbę większą od zera:");
            input = Console.ReadLine();
        }

        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);

            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.ReadKey();
    }
}