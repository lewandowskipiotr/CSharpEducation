using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OperationCounter operationCounter = new OperationCounter(50);
            Console.WriteLine("Operations: " + operationCounter.CalculateDistance("mice","mouse"));
            Console.WriteLine("Operations Levenshtein: " + operationCounter.CalculateOperationsLevenshtein("mice","mouse"));

            Console.ReadKey();
        }
    }
}
