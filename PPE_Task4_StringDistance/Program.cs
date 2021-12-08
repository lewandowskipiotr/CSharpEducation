using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OperationCounter operationCounter = new OperationCounter(3);
            Console.WriteLine("Operations: " + operationCounter.CalculateDistance("mouse","mice"));
            Console.WriteLine("Operations Levenshtein: " + operationCounter.CalculateOperationsLevenshtein("mice","mouse"));

            Console.ReadKey();
        }
    }
}
