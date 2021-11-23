using System;
using System.Collections.Generic;
using System.Text;

namespace PepeTask3_Anagram
{
    class Anagram
    {
        private static int counter = 0;

        public static void ClearCounter()
        {
            counter = 0;
        }


        private static string Swap(string word, int first, int second)
        {
            char[] arr = word.ToCharArray();
            char temp = word[first];
            arr[first] = arr[second];
            arr[second] = temp;
            return new string(arr);
        }

        public static void CalculateVariations(string word, int left, int right)
        {
            if (left > right)
            {
                Console.WriteLine(word);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    string swapped = Swap(word, left, i);
                    CalculateVariations(swapped, left + 1, right);
                }
            }
        }

        public static void Display(char[] arr)
        {
            counter++;
            Console.Write(counter + ": ");
            foreach (char c in arr)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        public static string RemoveChar(ref string word, int position)
        {
            return word.Substring(0, position) + word.Substring(position + 1);
        }

        public static void CalculateVariations( string letters, char[] permutation, int position, int size, int letterToRemove)
        {
            if (position == size - 1)
            {
                Display(permutation);
                return;
            }
            else if (position < size - 1)
            {
                position++;
                if(letterToRemove > -1)
                {
                    letters = RemoveChar(ref letters, letterToRemove);
                }

                for (int i = 0; i < letters.Length; i++)
                {
                    permutation[position] = letters[i];
                    CalculateVariations(letters, permutation, position, size, i);
                }
            }
        }
    }


}

