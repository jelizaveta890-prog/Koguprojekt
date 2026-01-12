namespace TunnitõõKordamine2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saad valida enda meetodi, kui sisestad numbri");
            Console.WriteLine("1. For loop");
            Console.WriteLine("2. While loop");
            Console.WriteLine("3. Liitmine ");
            Console.WriteLine("4. Nime küsimine");
            string choice = Console.ReadLine();

            if (choice == "1") 
            {
                ForLoop();
            } 
            
            else if (choice == "2") 
            {
                WhileLoop();
            } 
            
            else if (choice == "3") 
            {
                AddTwoNumbers();
            }

            else if  (choice == "4") 
            {
                AskAge();
            }  
            
            else  
            {
                Console.WriteLine("ERROR");
            } 
            
           

            AddTwoNumbers();

        }
        

        static void ForLoop()
        {
             for (int i = 0; i < 10; i++)
             {
                Console.WriteLine("Tere tulemas for loop");
             }
        }
       
        
        static void WhileLoop()
        {
            do
            {
                Console.WriteLine("Tere tulemast while loop ");
            }
            while (true);
        
        }


        static void AddTwoNumbers() 
        {
          Console.WriteLine("Numbrite liitmine");
          Console.WriteLine("Sisesta esimene number");
          int firstNr = int.Parse(Console.ReadLine());
            
          Console.WriteLine("Sisesta teine number");
          int secondNr = int.Parse(Console.ReadLine());
            
            
          Console.WriteLine("Vastus: " + (firstNr + secondNr));


        }
        static void AskAge() 
        {
            Console.WriteLine("Siseta enda vanus");
            string yourAge = Console.ReadLine();
            Console.WriteLine("Sinu vanus on " + yourAge);
        
        
        }

    }
}
