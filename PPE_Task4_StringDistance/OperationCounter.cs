using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class OperationCounter
    {

        public int CalculateOperationsLevenshtein(string pattern, string newText)
        {
     
            if (pattern == newText)
            {
                Console.WriteLine("Sentences are the same");
                return 0;
            }

            if(pattern.Length == 0)
            {                
                return newText.Length;
            }

            if(newText.Length == 0)
            {
                return pattern.Length;
            }

            pattern = pattern.ToLower();
            newText = newText.ToLower();

            var matrix = new int[pattern.Length + 1, newText.Length + 1];
            
            for(int i = 0; i <= pattern.Length; i++)
            {
                matrix[i, 0] = i;                
            }                       
            for(int i = 0; i <= newText.Length; i++)
            {
                matrix[0, i] = i;               
            }
            
            for(int i = 1; i <= pattern.Length; i++)
            {
                for(int j = 1; j <= newText.Length; j++)
                {
                    int operations = 0;

                    if (pattern[i - 1] != newText[j - 1])
                    {
                        operations++;
                    }

                    matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1), matrix[i - 1, j - 1] + operations);
                }
            }
            return matrix[pattern.Length, newText.Length];                      
        }


    }

}
