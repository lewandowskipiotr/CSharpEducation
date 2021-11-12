using System;
using System.Linq;

namespace PepeTask2_Palindrom
{
    public class Palindrom
    {
        public static Boolean IsPalindromNaive(string text)
        {
            if (String.IsNullOrEmpty(text))
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
                while (begin < end)
                {
                    if (text[begin] == text[end])
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
    }
}
