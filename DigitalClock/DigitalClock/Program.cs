using System.Data;

namespace DigitalClock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Digital Clock";
            Console.CursorVisible = false;

            // while (true)
            // { 
            // Console.Clear();
            // Console.WriteLine("Digital Clock\n");
            // Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            // Thread.Sleep(1000);
            // }

            //Tsükel
            //while (true)
            //{
            //    //Tühjendab konsooliakna
            //    Console.Clear();
            //    //muutuja, mille on arvutiaega
            //    string time = DateTime.Now.ToString("HH:mm:ss");

            //    //ekraani laius
            //    int x = (Console.WindowWidth - time.Length) / 2;
            //    //ekraani pikkus
            //    int y = Console.WindowHeight / 2;

            //    //kella numbrite näitemise koht
            //    Console.SetCursorPosition(x, y);
            //    //näitab aega läbi muutuja time
            //    Console.Write(time);
            //    //ootab ühe sekundi 
            //    Thread.Sleep(1000);
            //}

            //for luupiga digitaalne kell
            for (; ; )
            {

                Console.Clear();
                Console.WriteLine("Digital Clock\n");
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
            }
        }
    }
}
