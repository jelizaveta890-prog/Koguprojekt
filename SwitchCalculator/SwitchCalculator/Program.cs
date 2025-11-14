namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("esineme number");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta tehe");
            string operation = Console.ReadLine();

            Console.WriteLine("teine number");
            float secondNumber = float.Parse(Console.ReadLine());


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
        }
    }
}
