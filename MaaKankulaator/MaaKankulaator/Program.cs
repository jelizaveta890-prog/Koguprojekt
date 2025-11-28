namespace MaaKankulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja Maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameeti ja Maa raadiust

            //raadius = 6371 km,

            double coinDiameter = 25.75; //mm
            double earthRadius = 637100000;
            double aroundEarth = 2 * Math.PI * earthRadius;

            Console.WriteLine(aroundEarth);
            double howManyCoins = aroundEarth / coinDiameter;
            Console.WriteLine("Kahe euroseid läheb ümber maa {0:0}", howManyCoins);




        }
    }
}
