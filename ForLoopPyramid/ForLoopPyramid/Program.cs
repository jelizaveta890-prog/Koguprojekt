namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loome tärnidest püramiidi:  \n");
            Console.WriteLine("-------------------------------");
            Console.Write("\n\n");
            Console.WriteLine("Sisesta suurus: ");

            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)            
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");


            }
        }
    }
} 
