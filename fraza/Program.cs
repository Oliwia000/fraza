using System;
using System.IO;

class Program
{
    static void Main()
    {
        string nazwaPliku = @"C:\Users\teren\source\repos\fraza\fraza\dane.txt";
        string tekst = File.ReadAllText(nazwaPliku).ToLower(); 

        Console.WriteLine("Podaj frazę do wyszukania:");
        string fraza = Console.ReadLine().ToLower();

        int licznik = 0;
        int start = 0;

        while (start < tekst.Length)
        {
            int index = tekst.IndexOf(fraza, start);
            if (index == -1) break;
            licznik++;
            start = index + fraza.Length;
        }
        if (licznik > 0)
            Console.WriteLine($"Fraza występuje {licznik} razy.");
        else
            Console.WriteLine("Fraza nie występuje w pliku.");
            Console.ReadKey();
    }}
