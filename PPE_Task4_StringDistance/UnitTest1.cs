using System;
using Xunit;
using Test;
using System.Collections.Generic;

namespace OperationCounterTests
{
    public class UnitTest1
    {

        [Fact]
        public void TheSameSentencesLevenshtein()
        {
            // Arrange
            string[] sentences = new string[3] { "12345", "1234567", "%@!$#@!$@!" };
            int expectedValue = 0;
            OperationCounter operationCounter = new OperationCounter(3);

            //Assert 
            foreach (var s in sentences)
            {
                Assert.Equal(expectedValue, operationCounter.CalculateOperationsLevenshtein(s, s));
            }
        }

        [Fact]
        public void EmptySentencesLevenshtein()
        {
            // Arrange
            string emptyText = string.Empty;
            OperationCounter operationCounter = new OperationCounter(3);
            int expectedValue = 0;

            //Assert 
            Assert.Equal(expectedValue, operationCounter.CalculateOperationsLevenshtein(emptyText, emptyText));
        }

        // Other way to perform tests. Basiclly [Fact] can be used, but only for parametless function. This is the way on how I can use parameters in xUnit tests. 
        [Theory]
        [InlineData("Piotr Lewandowski", "Piotr Pernej", 9)]
        [InlineData("1234", "238", 2)]
        [InlineData("mice", "mouse", 3)]
        public void CalculateDistance(string pattern, string newText, int expectedValue)
        {
            // Arrange
            OperationCounter operationCounter = new OperationCounter(3);

            //Assert 
            Assert.Equal(expectedValue, operationCounter.CalculateOperationsLevenshtein(pattern, newText));
        }

        [Theory]
        [InlineData("PioTr LewanDOwsKI", "Piotr Pernej", 9)]
        [InlineData("MiCe", "MoUSE", 3)]
        public void CalculateDistanceCapitalLettersLevenshtein(string pattern, string newText, int expectedValue)
        {
            // Arrange
            OperationCounter operationCounter = new OperationCounter(3);

            //Assert 
            Assert.Equal(expectedValue, operationCounter.CalculateOperationsLevenshtein(pattern, newText));
        }

        [Theory]
        [InlineData("PioTr LewanDOwsKI", "Piotr Pernej", 3, 10)]
        [InlineData("1234", "238", 3, 2)]
        [InlineData("MiCe", "MoUSE", 3, 4)]
        public void CorrectDistanceConstantPrecision(string pattern, string newText, uint precision, int expectedValue)
        {
            // Arrange
            OperationCounter operationCounter = new OperationCounter(precision);
            //Assert 
            Assert.Equal(expectedValue, operationCounter.CalculateDistance(pattern, newText));
        }

        [Theory]
        [InlineData("PioTr LewanDOwsKI", "Piotr Pernej", 3, 10)]
        [InlineData("1234", "238", 3, 2)]
        [InlineData("MiCe", "MoUSE", 3, 4)]
        public void CalculateDistanceCapitalLetters(string pattern, string newText, uint precision, int expectedValue)
        {
            // Arrange
            OperationCounter operationCounter = new OperationCounter(precision);
            //Assert 
            Assert.Equal(expectedValue, operationCounter.CalculateDistance(pattern, newText));
        }

        [Theory]
        [InlineData("mouse", "mice", 1, 4)]
        [InlineData("mouse", "mice", 10, 3)]
        public void TheSameWordsDiferentPrecisions(string pattern, string newText, uint precision, int expectedValue)
        {
            // Arrange
            OperationCounter operationCounter = new OperationCounter(precision);
            //Assert 
            Assert.Equal(expectedValue, operationCounter.CalculateDistance(pattern, newText));
        }

        [Fact]
        public void TheSameSentences()
        {
            // Arrange
            string[] sentences = new string[3] { "12345", "1234567", "%@!$#@!$@!" };
            int expectedValue = 0;
            OperationCounter operationCounter = new OperationCounter(3);

            //Assert 
            foreach (var s in sentences)
            {
                Assert.Equal(expectedValue, operationCounter.CalculateDistance(s, s));
            }
        }

        [Fact]
        public void EmptySentences()
        {
            // Arrange
            string emptyText = string.Empty;
            OperationCounter operationCounter = new OperationCounter(3);
            int expectedValue = 0;

            //Assert 
            Assert.Equal(expectedValue, operationCounter.CalculateDistance(emptyText, emptyText));
        }


    }
}
