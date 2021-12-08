using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Operations
{
    class Deletion : IOperation
    {
        public string MakeOperation(string text, string pattern)
        {
            text = text.Remove(0, 1);            
            return text;
        }
    }
}
