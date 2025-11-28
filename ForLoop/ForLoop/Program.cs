
namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop");

            int loop = 10;

            //int i on muutuja määratlemin ja selle väärtus on 0
            // i < loop iga kord võrdleb loop muutja, et kas on suurem i-st
            //i++ liidab iga kord ühe korra juurde e sama hea, kui i + 1
            //teha vooskeem

            for (int i = 0; i < loop; i++) 
            {
                Console.WriteLine("Loop" + i);
                Thread.Sleep(1000);
                Console.Beep();
            }
        }
    }
}
