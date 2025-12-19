

using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();

        Console.Write("Sisesta kuuse suurus (nt 5 - 15): ");
        int size = int.Parse(Console.ReadLine());

        Console.Clear();

        Ilutulestik();

        Joulupuu(size);

        Joulupere();

        Console.ReadKey();
    }

    static void Ilutulestik()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        string[] fireworks = { "*", "✸", "✹", "✺", "❉" };

        for (int i = 0; i < 10; i++)
        {
            Console.SetCursorPosition(new Random().Next(0, 40), new Random().Next(0, 5));
            Console.Write(fireworks[new Random().Next(fireworks.Length)]);
            Thread.Sleep(100);
        }

        Console.WriteLine("\n");
    }

    static void Joulupuu(int height)
    {
        // Täht
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(new string(' ', height) + "★");

        // Kuusk
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i < height; i++)
        {
            Console.Write(new string(' ', height - i));
            for (int j = 0; j < i * 2 + 1; j++)
            {
                if (i > 2 && j % 4 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("o");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }

        // Tüvi
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(new string(' ', height) + "|||");
        }

        Console.WriteLine();
    }

    static void Joulupere()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("   👦     👧");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("  🎁🎁   🎁🎁");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n        🎅");
        Console.WriteLine("      JÕULUVANA");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n❄ ❄ ❄ ❄ ❄ ❄ ❄ ❄ ❄ ❄");
        Console.WriteLine("  Häid Jõule! 🎄🎁🎆");

        Console.ResetColor();
    }
}
    


