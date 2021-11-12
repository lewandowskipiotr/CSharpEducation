using System;
using System.Collections.Generic;
using System.Linq;

namespace PepeTask2_Palindrom
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> Examples = new List<string>() { "Ala", "AdA", "Piotrek", "Co mi dał duch cud ład i moc", "Kajak", "GłośNIK","" };
            foreach (var word in Examples)
            {
                if (Palindrom.IsPalindromOptimized(word))
                {
                    Console.WriteLine("'" + word + "' - correct");
                }
                else
                {
                    Console.WriteLine("'" + word + "' - incorrect");
                }
            }

            Console.ReadKey();
        }
    }
}
