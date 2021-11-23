using System;
using System.Collections.Generic;

namespace PepeTask3_Anagram
{

    class Program
    {
        static void Main(string[] args)
        {
            string word = "123";
            int permutationSize = word.Length;           
            
            if(permutationSize > word.Length)
            {
                Console.WriteLine("Incorrect permutation size");
            }
            else if(word.Length == 1)
            {
                Console.WriteLine(word);
            }
            else
            {
                for (int i = permutationSize; i > 1; i--)
                {
                    Anagram.CalculateVariations(word, new char[permutationSize], -1, i, -1);
                }
                Anagram.ClearCounter();
            }

            Console.ReadKey();
        }
    }
}
