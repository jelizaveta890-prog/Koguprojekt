namespace TunnitööKordamine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Vaja teha if ja else -ga neli meetodi kutsumist.            
            //Kasutaja saab valida nelja meetodi vahel.

            //Esimene meetod kasutab for loopi ja kordab kolm korda teksti.
            //teha konsoolirakendust, kus kasutad for loopi
            //kolm korda näidetakse Tere tulemast
            int loop = 3;

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("Tere tulemast");

            }

            //Teine meetod kasutab while ja kordab kolm korda teksti.
            int a = 1;

            while (a <= 3)
            {
                // uus while    
                int b = 1;
                while (b <= 3)
                {

                    Console.Write(b + " ");
                    b++;

                    Console.WriteLine();
                    a++;

                }
                //Kolmas küsib kasutajalt kahte arvu ja teeb liitmise.
                Console.WriteLine("esineme number");
                float firstNumber = float.Parse(Console.ReadLine());

                Console.WriteLine("Vali tehe: +, -, *, /");
                string operation = Console.ReadLine();

                Console.WriteLine("teine number");
                float secondNumber = float.Parse(Console.ReadLine());

                Console.WriteLine("Vastus on: ");

                switch (operation)
                {
                    case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;

                    case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                    case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;

                    case "/":
                    Console.WriteLine(firstNumber / secondNumber);
                    break;
                    default:
                    Console.WriteLine("Vale operaator");
                    break;
                }
            
                 Console.WriteLine("Sisesta oma vanus: ");
                 int vanus = Convert.ToInt32(Console.ReadLine());
               
                         string input = Console.ReadLine();
                switch (operation) 
                    { case "+": 
                
                 Console.WriteLine("Sinu vanus on: " + vanus);
                break;
                    }
                }
            }
        }
    }






