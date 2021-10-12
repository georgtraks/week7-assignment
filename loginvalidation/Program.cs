using System;

namespace loginvalidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int counter = 0;

            while (i < 3)
            {
                string login;
                string password;
                Console.WriteLine("login:");
                login = Console.ReadLine();
                Console.WriteLine("password: ");
                password = Console.ReadLine();
                Console.WriteLine("PIN-kood: ");
                string PINcode = Console.ReadLine();


                if (PINcode == "1234")
                {
                    Console.WriteLine("tere tulemast!");
                    break;
                }
                else if ((login == "admin") && (password == "pass1234") && (PINcode == "1234"))
                {
                    Console.WriteLine("tere tulemast.");
                }
                else if ((login != "admin") && (password == "pass1234"))
                {
                    Console.WriteLine("midagi läks valesti. proovi uuesti.");
                }
                else if ((login == "admin") && (password != "pass1234"))
                {
                    Console.WriteLine("midagi läks valesti. proovi uuesti.");
                }
                else
                {
                    i++;
                    Console.WriteLine($"proovi uuesti {3 - i} katset on jäänud");
                }
            }
            

        }
    }
}
