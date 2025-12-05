using System.ComponentModel.Design;

namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ushort i = 0;

            //kui on 10 rida konsoolis, siis lõpetab ära
            //kasuta break;
            for (; ; )
            {
                Console.WriteLine("i väärtus on " + i);
                i++;
                if (i == 11)
                    break;
            }
        }
    }
}
