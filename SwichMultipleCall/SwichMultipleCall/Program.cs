namespace SwichMultipleCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //teha switch rakendus,
            //kus kasutaja sisestab sõiduki tüübi (coupe või truck)
            string input = Console.ReadLine();
            //ja programm kutsub vastava meetodi (CarCope või Truck)
            switch (input)
            {
                case "Car Coupe":
                    CarCoupe();

                    break;

                case "Truck":
                    Truck();
                    break;

                default:
                    Console.WriteLine("Unknown vehicle type.");
                    break;
            }

            static void CarCoupe()
            {
                Console.WriteLine("This is a coupe car.");
            }

            static void Truck()
            {
                Console.WriteLine("This is a truck.");
            }
        }
    }
}
