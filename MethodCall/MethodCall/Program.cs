namespace MethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello();
            SayGoodbye();
        }
   

        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static void SayGoodbye()
        {
            Console.WriteLine("SayGoodbye");
        }




    }
}
