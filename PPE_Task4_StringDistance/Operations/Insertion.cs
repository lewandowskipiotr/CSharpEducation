using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Operations
{
    class Insertion : IOperation
    {
        public string MakeOperation(string text, string pattern)
        {
            text = text.Insert(0, pattern[0].ToString());           
            return text;
        }
    }
}
