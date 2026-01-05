namespace AnimalLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Üleasnne 4
             >>>>>>>>>>>
            Koer, kass, jänes, sipelgasiil ja lendorav hakkasid vaidlema,
            kellel on kõige pikkem nimetus. Koost programm, kus on antud loomanimed järjend.
            Loo funktsioon, mis saab argumendina ette looma nime ning tagastab (mitte ei trüki!)
            selle pikkuse. Lase programmil kustuda funktsiooni välja 
            iga loomanimed järjendi elemendiga ning trükib ekraanile nime pikkuse.
            Pärast pikkuste kontrollimist peab programm väljastama küigi pikema loomanime 
            (võrdsete pikkuste puhul võib esitada vaid ühe pikimatest).
             */

            //1. massivi tegemine
            string[] animalName = { "Koer", "kass", "jänes", "sipelgasiil", "lendorav" };
         
            
            //2. programm peab aru saama, et sõna pikkusest
            int longerName = animalName[0].Length;
            string longerNameString = animalName[0];

            //3.for loop tuleb teha, et saaka nimed pikkust omavahel võrrelda 
            // for loopi sees tuleks kasutada if-i
            
            for (int i = 0; i < animalName.Length; i++)
            {            
                if (longerName < animalName[i].Length)
                {
                    longerName = animalName[i].Length;
                    longerNameString = animalName[i];                  
                
                }
                int animalLegth = AnimalLegth(animalName[i]);
                Console.WriteLine(animalName[i] + " = ");
                Console.WriteLine(animalLegth);
                Console.WriteLine();

            }
            Console.WriteLine("Pikim nimi oli {0} ja mille nime pikkus oli: {1}", longerNameString, longerName);
        }
       static int AnimalLegth(string animalName) 
        {
          return animalName.Length;

       
       }
    }
}
