namespace SwitchWithNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number!");
            // Teie töö on teha switch rakendus,
            // kus on kolm case (1, 2, 3).
            //Iga case puhul teeb erineva arve beep-e        

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("tuli 1");
                    Console.Beep();
                    break;

                case "2":
                    Console.WriteLine("tuli 2");
                    Console.Beep();
                    Console.Beep();
                    break;

                case "3":
                    Console.WriteLine("tuli 3");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    break;

                default:
                    Console.WriteLine("ERORR");
                    break;


            }
        }
    }
}
