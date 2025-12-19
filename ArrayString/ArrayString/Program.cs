using System;

namespace ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Euroopa üks pialinnadest on  ";
            Console.WriteLine("Tuple");
           
            //NÄIDE 1
            var cities = Tuple.Create("Tallinn", "Pariis", "Rooma", "London", "Helsingi");
            //tuple all on viis erinevat väärtust ja selle pärast saab atud 
            //juhul 5 inte-t sisestada
            Console.WriteLine(sentence + cities.Item5);
            Console.WriteLine("-------------------------------------");

            //NÄIDE 2
            string[] city = { "Tallinn", "Pariis", "Rooma", "London", "Helsingi" };
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(sentence + city[i]);              
            }
            Console.WriteLine("-------------------------------------");


            //NÄIDE 3
            Console.WriteLine(sentence + city[2]);
            Console.WriteLine("-------------------------------------");

            //NÄIDE 4
            Random number = new Random();
            int randomNumber = number.Next(0, 4);
            Console.WriteLine(sentence + city[randomNumber]);

        }
    }
}
