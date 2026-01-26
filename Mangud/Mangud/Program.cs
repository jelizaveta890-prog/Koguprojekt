
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Mangud
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "🎮 MEGA MÄNGUDE KOGUMIK 2026";
            while (true)
            {
                ShowMenu();
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.D1:
                        SnakeGame();
                        break;
                    case ConsoleKey.D2:
                        SpaceAdventureGame();
                        break;
                    case ConsoleKey.D3:
                        GuessNumberGame();
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Head aega! 👋");
                        Thread.Sleep(1000);
                        return;
                }
            }
        }

        static void ShowMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("══════════════════════════════════════════════════");
            Console.WriteLine("║          TERE TULEMAST MÄNGUKESKUSSE           ║");
            Console.WriteLine("══════════════════════════════════════════════════");
            Console.WriteLine("║                                                ║");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("║  1)   Madu (Snake) - Klassikaline väljakutse   ║");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("║  2)   Kosmose seiklus - Väldi asteroide        ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  3)   Arva number - Kas oled selgeltnägija?    ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║                                                ║");
            Console.WriteLine("║  Esc) Välju programmist                        ║");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("══════════════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nSisesta valik klaviatuuril...");
        }

        // =========================================================
        // 🐍 SNAKE
        // =========================================================
        static void SnakeGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vali raskusaste: [1] Algaja | [2] Keskmine | [3] Ninja");
            string input = Console.ReadLine();
            int speed = input switch { "1" => 120, "3" => 40, _ => 80 };

            int width = 40; // Fikseeritud suurus parema vaate jaoks
            int height = 20;
            Console.Clear();

            // Joonista piirid
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= width; i++) { Console.SetCursorPosition(i, 0); Console.Write("═"); Console.SetCursorPosition(i, height); Console.Write("═"); }
            for (int i = 0; i <= height; i++) { Console.SetCursorPosition(0, i); Console.Write("║"); Console.SetCursorPosition(width, i); Console.Write("║"); }

            Tile[,] map = new Tile[width + 1, height + 1];
            Queue<(int X, int Y)> snake = new();
            Direction currentDir = Direction.Right;
            int x = width / 2, y = height / 2;
            int score = 0;

            snake.Enqueue((x, y));
            PlaceFood();

            void PlaceFood()
            {
                int fx, fy;
                do
                {
                    fx = Random.Shared.Next(1, width);
                    fy = Random.Shared.Next(1, height);
                } while (map[fx, fy] != Tile.Open);
                map[fx, fy] = Tile.Food;
                Console.SetCursorPosition(fx, fy);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("🍎");
            }

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    currentDir = key switch
                    {
                        ConsoleKey.UpArrow when currentDir != Direction.Down => Direction.Up,
                        ConsoleKey.DownArrow when currentDir != Direction.Up => Direction.Down,
                        ConsoleKey.LeftArrow when currentDir != Direction.Right => Direction.Left,
                        ConsoleKey.RightArrow when currentDir != Direction.Left => Direction.Right,
                        _ => currentDir
                    };
                }

                x += currentDir switch { Direction.Up => 0, Direction.Down => 0, Direction.Left => -1, Direction.Right => 1, _ => 0 };
                y += currentDir switch { Direction.Up => -1, Direction.Down => 1, Direction.Left => 0, Direction.Right => 0, _ => 0 };

                if (x <= 0 || x >= width || y <= 0 || y >= height || map[x, y] == Tile.Snake) break;

                if (map[x, y] == Tile.Food)
                {
                    score++;
                    map[x, y] = Tile.Open;
                    PlaceFood();
                }
                else
                {
                    var tail = snake.Dequeue();
                    map[tail.X, tail.Y] = Tile.Open;
                    Console.SetCursorPosition(tail.X, tail.Y);
                    Console.Write(" ");
                }

                snake.Enqueue((x, y));
                map[x, y] = Tile.Snake;
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("■");

                Thread.Sleep(speed);
            }
            GameOverScreen(score);
        }

        // =========================================================
        // 🚀 KOSMOSE SEIKLUS (UUS MÄNG)
        // =========================================================
        static void SpaceAdventureGame()
        {
            Console.Clear();
            int playerPos = Console.WindowWidth / 2;
            int score = 0;
            List<(int X, int Y)> asteroids = new();
            bool alive = true;

            while (alive)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.LeftArrow && playerPos > 1) playerPos -= 2;
                    if (key == ConsoleKey.RightArrow && playerPos < Console.WindowWidth - 2) playerPos += 2;
                    if (key == ConsoleKey.Escape) return;
                }

                // Tekita asteroide
                if (Random.Shared.Next(0, 5) == 0) asteroids.Add((Random.Shared.Next(1, Console.WindowWidth - 1), 0));

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" Punktid: {score}  |  Liiguta: ← →  |  Välju: Esc");

                // Uuenda asteroide
                for (int i = asteroids.Count - 1; i >= 0; i--)
                {
                    var a = asteroids[i];
                    if (a.Y >= Console.WindowHeight - 2)
                    {
                        asteroids.RemoveAt(i);
                        score++;
                    }
                    else
                    {
                        asteroids[i] = (a.X, a.Y + 1);
                        Console.SetCursorPosition(a.X, a.Y + 1);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("O");
                        if (a.Y + 1 == Console.WindowHeight - 2 && Math.Abs(a.X - playerPos) < 2) alive = false;
                    }
                }

                Console.SetCursorPosition(playerPos, Console.WindowHeight - 2);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("🚀");

                Thread.Sleep(50);
            }
            GameOverScreen(score);
        }

        // =========================================================
        // 🎯 ARVA NUMBER
        // =========================================================
        static void GuessNumberGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            int number = Random.Shared.Next(1, 101);
            int tries = 0;

            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║        🎯 ARVA NUMBER (1-100)          ║");
            Console.WriteLine("╚════════════════════════════════════════╝");

            while (true)
            {
                Console.Write("\nSisesta oma pakkumine (või 'tagasi'): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "tagasi") return;

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("❌ See ei ole number!");
                    continue;
                }

                tries++;
                if (guess < number) Console.ForegroundColor = ConsoleColor.Blue;
                if (guess < number) Console.WriteLine("⬆️ PROOVI SUUREMAT!");
                else if (guess > number) { Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("⬇️ PROOVI VÄIKSEMAT!"); }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n🎉 PALJU ÕNNE! Arvasid ära {tries} korraga.");
                    Console.ReadKey();
                    return;
                }
            }
        }

        static void GameOverScreen(int score)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n   💥 MÄNG LÄBI! 💥");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n      Sinu skoor: {score}");
            Console.WriteLine("\n   Vajuta suvalist klahvi...");
            Console.ReadKey();
        }

        enum Direction { Up, Down, Left, Right }
        enum Tile { Open, Snake, Food }
    }
}




