using System;

namespace fullnameinitals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi");
            string lastname = Console.ReadLine();

            string fullname = $"{firstname}{lastname}".ToUpper();



        }
    }
}
