using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OperationCounter operationCounter = new OperationCounter();
            Console.WriteLine(operationCounter.CalculateOperationsLevenshtein("Piotr Lewandowski", "Piotr Pernej"));
            Console.ReadKey();
        }
    }
}
