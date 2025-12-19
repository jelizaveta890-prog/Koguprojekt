namespace Jõulud

{
    
    class Program
        {
            static void Main()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.ForegroundColor = ConsoleColor.Green;

                int height = 10;

                // Täht
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("          ★");

                // Kuuse ladva ja oksad
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < height; i++)
                {
                    Console.Write(new string(' ', height - i));
                    for (int j = 0; j < i * 2 + 1; j++)
                    {
                        // Jõuluehted
                        if (j % 5 == 0 && i > 2)
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

                // Lumi ja tekst
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n❄ ❄ ❄ ❄ ❄ ❄ ❄ ❄ ❄ ❄");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   Häid Jõule ja Head Uut Aastat! 🎅🎁");

                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }




