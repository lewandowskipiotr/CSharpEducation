using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Operations
{
    class Insertion : IOperation
    {
        public string MakeOperation(string text, int i, string pattern)
        {
            text = text.Insert(i, pattern[i].ToString());           
            return text;
        }
    }
}
