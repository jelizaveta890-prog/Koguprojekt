namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljestaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            
            
            Console.WriteLine("Sisesta korduste arv");
            int arv = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arv; i++)
             //nüüd siia lisada kaks for loopi
            {
                Console.WriteLine("kill - koll");
                Console.WriteLine("kill - koll");
                Console.WriteLine("killadi - koll");
            }

            
            Console.WriteLine("kill - koll");




        }
    }
}
