using System.Threading.Channels;

namespace FibonacciFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Näita esimest Fibonacci seeriat");
            Console.WriteLine("---------------------------\n\n");
            Console.WriteLine("Sisesta number");
            int prv = 0, pre = 1, trm, i, n;
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Siin on Fibonacci seeria {0} kuni \n", n);
           
            Console.WriteLine($"{0} {1}", prv, pre);
               
            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write(trm + "  ");
                prv = pre;  
                pre = trm;
            }
            Console.Write("\n");

        }
    }
}
