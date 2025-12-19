using System.Reflection;
using System.Threading.Channels;

namespace RectangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta ristküliku kahe külje mõõdud");
            Console.WriteLine("Pikkus");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Laius");
            double width = double.Parse(Console.ReadLine());

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= width; column++)
                {
                    string mark;
                    if (row == column || row + column <= +1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}