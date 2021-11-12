using System;
using System.Collections.Generic;
using System.Linq;

namespace PepeTask2_Palindrom
{
    class Program
    {
  
        public static Boolean IsPalindromNaive(string text)
        {
            if(String.IsNullOrEmpty(text))
            {
                Console.Write("Text is empty: ");
                return false;
            }
            else
            {
                text = String.Concat(text.Where(c => !Char.IsWhiteSpace(c))).ToLower();
                return text == new string(text.ToCharArray().Reverse().ToArray());
            }
        }


        public static Boolean IsPalindromOptimized(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                Console.Write("Text is empty: ");
                return false;
            }
            else
            {
                text = String.Concat(text.Where(c => !Char.IsWhiteSpace(c))).ToLower();
                int begin = 0;
                int end = text.Length - 1;
                while(begin < end)
                {
                    if(text[begin] == text[end])
                    {
                        begin++;
                        end--;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;                
            }
        }

        static void Main(string[] args)
        {
            List<string> Examples = new List<string>() { "Ala", "AdA", "Piotrek", "Co mi dał duch cud ład i moc", "Kajak", "GłośNIK","" };
            foreach (var word in Examples)
            {
                if (IsPalindromOptimized(word))
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
