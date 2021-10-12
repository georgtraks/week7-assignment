using System;

namespace cakereplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "the c4ke i3 4 l1e";

            word = word.Replace('4', 'a');
            word = word.Replace('1', 'i');
            word = word.Replace('3', 's');

            Console.WriteLine(word);




        }
    }
}
