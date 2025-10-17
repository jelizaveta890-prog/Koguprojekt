namespace SwitchRandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kuni kuueni");

            //kõik kuus tuleb ära käsitleda switchiga
           
            int cube = new Random().Next(1, 7);

            switch (cube)
            {
                case 1:
                    Console.WriteLine("tuli 1");
                    break;

                case 2:
                    Console.WriteLine("tuli 2");
                    break;

                case 3:
                    Console.WriteLine("tuli 3");
                    break;
                
                
                case 4:
                    Console.WriteLine("tuli 4");
                    break; 
                
                case 5:
                    Console.WriteLine("tuli 5");
                    break; 
                
                case 6:
                    Console.WriteLine("tuli 6");
                    break; 
                
                default:
                    Console.WriteLine("ERROR");
                    break;


            }
        }
    }
}
