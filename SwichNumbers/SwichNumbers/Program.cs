namespace SwichNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        //peab saama sisestada numbrid ja muudab selle int andmetüübiks
        int number = Convert.ToInt32(Console.ReadLine());
            //tuleb teha switch, kus on esimene case 10, teine on 20 ja kolmas on 30
            //kindlasti  tuleb ka deafult lõppu teha

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;

                case 20:
                    Console.WriteLine("Number is 20");
                    break;

                case 30:
                    Console.WriteLine("Number is 30");
                    break;


                default:
                    Console.WriteLine("Number is not 10,20, or 30");
                    break;

              }
           }
        }
    }
