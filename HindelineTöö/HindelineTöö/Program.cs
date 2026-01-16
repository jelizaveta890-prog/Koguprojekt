namespace HindelineTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Teha switchiga kolm meetodi kutsumist.
            //Esimne meetod küsib kasutajalt püramiidi kõrgust.
            //teine meetod teeb ruudu.Lisaks sellele peab arvutama pindala ja ümbermõõdu.
            //Kolmas meetod teeb ruutvõrrandi valemiga: y=a(x+p)2+q.
            //kasutaja peab saama sisestadud muutjaid a, p, ja q.
            Console.WriteLine("Saad valida enda meetodi, kui sisestad numbri");
            Console.WriteLine("1. Sisestada püramiidi kõrgust: ");
            Console.WriteLine("2. Sisesta ruudu suurus");
            Console.WriteLine("3. Ruutvõrrandi valemiga: y=a(x+p)2+q");
           
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Püramiid();
            }

            else if (choice == "2")
            {
                RuuduSuurus();
            }

            else if (choice == "3")
            {
                Ruutvõrrand();
            }


            else
            {
                Console.WriteLine("ERROR");
            }



            

        }


        static void Püramiid()
        {
            Console.Write("\n\n");
            Console.WriteLine("Sisesta püramiidi kõrgust: ");

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
        }

        static void RuuduSuurus()
        {
                Console.WriteLine("Sisesta ruudu suurus");
               
                int size = int.Parse(Console.ReadLine());


                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                
               
                int area = size * size;
                int around = 4 * size;
                Console.WriteLine("Pindala on  " + area);
                Console.WriteLine("Ümbermõõt on  " + around);

        }


        static void Ruutvõrrand()
        {
            Console.WriteLine("Ruutvõrrandi valemiga: y=a(x+p)2+q");



            Console.Write("sisesta a väärtus:");
            double a = double.Parse(Console.ReadLine());

            Console.Write("sisesta p väärtus:");
            double p = double.Parse(Console.ReadLine());

            Console.Write("sisesta q väärtus:");
            double q = double.Parse(Console.ReadLine());

            double y = a * (2 + p) * 2 + q;

            Console.WriteLine($"x1 = {(-p + Math.Sqrt(y)) / (2 * a)}, x2 = {(-p + Math.Sqrt(y)) / (2 * a)}");
        }
    }
}
