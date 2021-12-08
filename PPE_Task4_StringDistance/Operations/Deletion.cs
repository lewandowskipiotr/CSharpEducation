using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Operations
{
    class Deletion : IOperation
    {
        public string MakeOperation(string text, int i, string pattern)
        {
            if(i >= text.Length)
            {
                return string.Empty;
            }
            text = text.Remove(0, 1);            
            return text;
        }
    }
}
