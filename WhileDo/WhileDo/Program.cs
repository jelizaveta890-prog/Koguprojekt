namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            int i = 1;

            do
            {

                Console.WriteLine(i);
                //suurendab numbrit ühe võrra e number + 1
                i++;
                //Kui number on väiksem voi võrdne 5-ga siis jätkab tsüklit
            } while (i <= 10);
        }
    }
}
