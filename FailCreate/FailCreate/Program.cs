using System.Threading.Channels;

namespace FailCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjutab faili läbi konsooli");

            string filePath = "C:/Users/opilane/Desktop/WriteToFile.txt";
            string input = Console.ReadLine();

            File.WriteAllText(filePath, input);
       
        
        
        }
    }
}
