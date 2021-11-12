using System;
using Xunit;
using PepeTask2_Palindrom;
using System.Collections.Generic;

namespace PalindromUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            List<string> examplesPalindroms = new List<string>() { "Ala", "AdA", "Co mi da� duch cud �ad i moc", "Kajak","1221","  ","@@##@@"};

            foreach(var word in examplesPalindroms)
            {
                Assert.True(Palindrom.IsPalindromNaive(word));
                Assert.True(Palindrom.IsPalindromOptimized(word));
            }
        }

        [Fact]
        public void FailingTest()
        {
            List<string> examplesPalindroms = new List<string>() { "Piotrek", "sdasdsa", "Cdsa da� duch dd i moc", "231341", "12224421", "" ,"##!%#@!#$@"};

            foreach (var word in examplesPalindroms)
            {
                Assert.False(Palindrom.IsPalindromNaive(word));
                Assert.False(Palindrom.IsPalindromOptimized(word));
            }
        }
    }
}
