using System;
using System.Collections.Generic;
using System.Linq;

namespace PepeTask2_Palindrom
{
    class Program
    {
        public static Boolean isPalindrom(string text)
        {
            if(String.IsNullOrEmpty(text))
            {
                Console.WriteLine("Text is empty");
                return false;
            }
            else
            {
                text = text.Replace(" ", "").ToLower();                
                return text == new string(text.ToCharArray().Reverse().ToArray());
            }
        }

        static void Main(string[] args)
        {
            List<string> Examples = new List<string>() { "Ala", "AdA", "Piotrek" , "Co mi dał duch cud ład i moc", "kajak","GłośNIK" };
            foreach(var word in Examples)
            {
                if(isPalindrom(word))
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
