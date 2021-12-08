using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Operations
{
    class Replacement : IOperation
    {
        public string MakeOperation(string text, string pattern)
        {
            char[] arr = text.ToCharArray();
            arr[0] = pattern[0];;
            return new string(arr);
        }
    }
}
