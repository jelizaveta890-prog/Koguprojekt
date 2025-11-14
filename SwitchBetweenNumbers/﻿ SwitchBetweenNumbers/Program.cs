using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _﻿_SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esimese koondtulemusele puhul on number vahemikus
            //0 kuni 100,
            //Teise puhul  101 kuni 200 ja 
            //kolmanada puhul 201 kuni 300
            //kasutada switchid
            int number = Convert.ToInt32(Console.ReadLine());
            
            switch (number)
            {

                case >= 0 and <= 100:
                Console.WriteLine(number >= 0 && number <= 100);
                Console.WriteLine("Number on vahemikus 0-100");
                    break;

                
                case >= 101 and <= 200:
                    Console.WriteLine(number >= 0 && number <= 100);
                    Console.WriteLine("Number on vahemikus 101-200");
                    break;

               
                case >= 201 and <= 300:
                    Console.WriteLine(number >= 0 && number <= 100);
                    Console.WriteLine("Number on vahemikus 201 - 300");
                    break;
                 
                    default:
                    Console.WriteLine("Number ei ole vahemikus 0-300");
                    break;

            }



           
        }
    }
}
