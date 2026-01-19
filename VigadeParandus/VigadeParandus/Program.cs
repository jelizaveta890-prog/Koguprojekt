using System.Threading.Channels;

namespace VigadeParandus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vigade parandus");
            Console.WriteLine("Vjuta numbrit");
            Console.WriteLine("1. Tagurpidi Püramiid");
            Console.WriteLine("2. Ristkülik");
            Console.WriteLine("3. Püramiid");
           string input = Console.ReadLine();
          //puhastab konsooli eelnevast tekstist
           Console.Clear();

            switch (input)
            {
                case "1":
                    //meetodi välja kutsumine
                    UpsidedownPyramiid();
                    break;

                case "2":

                    Rectangle();
                    break;


                case "3":

                    Pyramiid();
                    break;

                default:
                    Console.WriteLine("Sellist valiku ei ole");
                    break;

            }
        }
        static void UpsidedownPyramiid()
        {
            Console.WriteLine("Sisesta kõrgus");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n - 0; i >= 1; i--)
            {
                for (j = 1; j <= n - 1; j++)
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
        static void Rectangle()

        {
            Console.WriteLine("Sisetsa pikkus");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisetsa plaius");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("");
            }
            int area = row * width;
            int around = 2 * (row + width);

            Console.WriteLine("Pindala on " + area);
            Console.WriteLine("Pindala on " + area);
        }
        static void Pyramiid()
        
        {

            Console.WriteLine("");
            Console.WriteLine("Siseta püramiidi kõrgus: ");
           
            int i, j, n;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++) 
            {
                for (j = 1; j <= n - i ; j++)
                {
                    Console.Write("  ");            
                }
                for (j = 1; j <= 2 * i -1; j++) 
                {
                    Console.Write("*");
                }
               Console.Write("\n");
            }
        }
    }
}

