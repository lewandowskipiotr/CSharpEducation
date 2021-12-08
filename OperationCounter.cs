using System;
using System.Collections.Generic;
using System.Text;
using Test.Operations;

namespace Test
{
    public class OperationCounter
    {        
        private uint precision;
        List<IOperation> allOperations;

        public OperationCounter(uint precision)
        {
            this.precision = precision;
            Initializate();
        }

        private void Initializate()
        {
            allOperations = new List<IOperation>();
            allOperations.Add(new Replacement());
            allOperations.Add(new Insertion());                       
            allOperations.Add(new Deletion());                        
        }

        private int CalculateProfitability(string pattern, string text)
        {
            int profit = 0;
            uint lenght = precision;

            if(precision > pattern.Length | precision > text.Length)
            {
                lenght = (uint)Math.Min(pattern.Length, text.Length);
            }

            for(int i = 0; i < lenght; i++)
            {
                if(text[i] == pattern[i])
                {
                    profit++;
                }
            }
            return profit;
        }               

        private void TrimCommonPart(ref string pattern, ref string text)
        {
            var lenght = pattern.Length;
            if(pattern.Length > text.Length)
            {
                lenght = text.Length;
            }

            int prefixCounter = 0;

            for(int i = 0; i < lenght; i++)
            {
                if(pattern[i] == text[i])
                {
                    prefixCounter++;
                }
                else
                {
                    break;
                }
            }
            // Remove prefix (the same letters from the begin)
            pattern = pattern.Remove(0, prefixCounter);
            text = text.Remove(0, prefixCounter);
        }

        public int CalculateDistance(string pattern, string text)
        {
            if(pattern == text)
            {
                Console.WriteLine("The same sentences");
                return 0;
            }

            if (pattern.Length == 0)
            {
                return text.Length;
            }

            if (text.Length == 0)
            {
                return pattern.Length;
            }

            // If words started with the same string remove it. Example 1234,123894 -> 4,894
            TrimCommonPart(ref pattern, ref text);
            int modificationCounter = 0;
            pattern = pattern.ToLower();
            text = text.ToLower();
                      

            while (text != pattern)
            {
                modificationCounter++;
                string maxProfitText = "";
                int maxProfit = 0;

                // Iterate for every operation and find the most efficient(with the highest maxProfit value) operation 
                foreach (var operationType in allOperations)
                {                    
                    string tempText = operationType.MakeOperation(text, 0, pattern);
                    int profit = CalculateProfitability(pattern, tempText);                   
                    if (maxProfit < profit)
                    {
                        maxProfit = profit;
                        maxProfitText = tempText;
                    }
                }

                //Console.WriteLine("OPERATIONS: " + maxProfit + " " + maxProfitText);
                text = maxProfitText;
                TrimCommonPart(ref pattern, ref text);                
                
                // if words have different lenght stop iterating and add missing operations
                if (pattern == string.Empty)
                {
                    modificationCounter += text.Length;
                    return modificationCounter;
                }
                
                if (text == string.Empty)
                {
                    modificationCounter += pattern.Length;
                    return modificationCounter;
                }
            }
            return modificationCounter;
        }

        //Levenstein algorithm
        public int CalculateOperationsLevenshtein(string pattern, string newText)
        {

            if (pattern == newText)
            {
                Console.WriteLine("Sentences are the same");
                return 0;
            }

            if (pattern.Length == 0)
            {
                return newText.Length;
            }

            if (newText.Length == 0)
            {
                return pattern.Length;
            }

            pattern = pattern.ToLower();
            newText = newText.ToLower();

            var matrix = new int[pattern.Length + 1, newText.Length + 1];

            for (int i = 0; i <= pattern.Length; i++)
            {
                matrix[i, 0] = i;
            }
            for (int i = 0; i <= newText.Length; i++)
            {
                matrix[0, i] = i;
            }

            for (int i = 1; i <= pattern.Length; i++)
            {
                for (int j = 1; j <= newText.Length; j++)
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
