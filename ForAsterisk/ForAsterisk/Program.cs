namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Asterisk");

            int nr = Convert.ToInt32(Console.ReadLine());


            //tuleb kasutada for loopi 
            //sisestada ridade arvu ja tuleb vastav ridade arv konsooli 
            //peab näitama tärne

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("*");

            }
        }
    }
}
