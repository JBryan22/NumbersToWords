using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NumbersToWords.Models;
using System;

namespace NumbersToWords.Tests 
{
    [TestClass]
    public class ToWordsTest
    {
     [TestMethod]
        public void GivenNumberToWords_UserEnters11ReturnsEleven_Eleven()
        {
            ToWords newWord = new ToWords(11);
            string expected = "Eleven";
            string actual = newWord.EvaluateNumbersToWords(newWord._givenNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenNumberToWords_UserEnters80ReturnsEighty_Eighty()
        {
            ToWords newWord = new ToWords(80);
            string expected = "Eighty";
            string actual = newWord.EvaluateNumbersToWords(newWord._givenNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenNumberToWords_UserEnters85ReturnsEightyFive_EightyFive()
        {
            ToWords newWord = new ToWords(85);
            string expected = "Eighty Five";
            string actual = newWord.EvaluateNumbersToWords(newWord._givenNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenNumberToWords_UserEnters1485643ReturnsLongStringOfNumber_String()
        {
            ToWords newWord = new ToWords(1485643);
            string expected = "One Million Four Hundred Eighty Five Thousand Six Hundred Fourty Three";
            string actual = newWord.EvaluateNumbersToWords(newWord._givenNumber);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenNumberToWords_UserEnters58586439587ReturnsLongStringOfNumber_String()
        {
            ToWords newWord = new ToWords(58586439587);
            string expected = "Fifty Eight Billion Five Hundred Eighty Six Million Four Hundred Thirty Nine Thousand Five Hundred Eighty Seven";
            string actual = newWord.EvaluateNumbersToWords(newWord._givenNumber);

            Assert.AreEqual(expected, actual);
        }
    }
}