namespace ComputerCaklogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Console.WriteLine("Kui palju on 3 + 8 / (4 - 2) * 4 = ? ");

            double calkulaetion1 = 3 + 8 / (4 - 2) * 4; 
            float calkulaetion2 = 3 + 8 / 4 - 2 * 4;
            double calkulaetion3 = (3 + 8) / (4 - 2) * 4;
            
            //kui tahad, et võtaks arvesse komakohta, siis pane nr lõppu .0
            double calkulaetion4 = ((3.0 + 8.0) / (4.0 - 2.0) * 4.0);



            Console.WriteLine(" 3 + 8 / (4 - 2) * 4 = " + calkulaetion1);
            Console.WriteLine(" 3 + 8 / 4 - 2 * 4 = " + calkulaetion2);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calkulaetion3);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + calkulaetion4);





        }
    }
}
