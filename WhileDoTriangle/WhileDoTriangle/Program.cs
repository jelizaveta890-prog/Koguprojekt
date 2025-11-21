namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            int rows = int.Parse(Console.ReadLine()); // The desired number of rows
            int i = 1;
            while (i < rows)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                Console.WriteLine();
                i++;


                //otsida Internetist While koodiga kolmnurga kujundeid e tegemise viisi
                //kui kood on leitud, siis kirjutada seda siia alla
                //teha vooskeem


            }
        }
    }
}
