using System;

namespace firstnamereverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string name = Console.ReadLine();

            if (name.Length >= 5)
            {
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"{name[i]}");
                }
            }
            else
            {
                Console.WriteLine($"{name}");
            }





        }
    }
}
