using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class ToWords
  {
    public long _givenNumber;

    private static List<string> _unitsList = new List<string> {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    private static List<string> _tenList = new List<string> {"Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};


    public ToWords(long givenNumber)
    {
      _givenNumber = givenNumber;
    }

    public string EvaluateNumbersToWords(long number)
    {
      string wordNumber = "";

      if (number < 0)
      {
         wordNumber += "Negative ";
      }

      if (number == 0)
      {
        return "Zero";
      }

      if (number / 1000000000000 > 0)
      {
        wordNumber += EvaluateNumbersToWords(number / 1000000000000) + " Trillion ";
        number %= 1000000000000;
      }

      if (number / 1000000000 > 0)
      {
        wordNumber += EvaluateNumbersToWords(number / 1000000000) + " Billion ";
        number %= 1000000000;
      }

      if (number / 1000000 > 0)
      {
        wordNumber += EvaluateNumbersToWords(number / 1000000) + " Million ";
        number %= 1000000;
      }

      if (number / 1000 > 0)
      {
        wordNumber += EvaluateNumbersToWords(number / 1000) + " Thousand ";
        number %= 1000;
      }

      if (number / 100 > 0)
      {
        wordNumber += EvaluateNumbersToWords(number / 100) + " Hundred ";
        number %= 100;
      }

      if (number < 20)
      {
        wordNumber += _unitsList[(int)number];
      }
      else
      {
        wordNumber += _tenList[(int)number / 10];
        number %= 10;
        if(number > 0)
        {
          wordNumber += " " + _unitsList[(int)number];
        }

      }
      return wordNumber;

    }

    // private static int[] _numberArray = new int[4] {1000, 100, 10, 1};
    // private static string[] _numberEvery3 = new string[5] {"Trillion", "Billion", "Million", "Thousand", "Hundred"};

    // private static Dictionary<string, int> _oneToNineTeen = new Dictionary<string, int> {{"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}, {"ten", 10}, {"eleven", 11}, {"twelve", 12}, {"thirteen", 13}, {"fourteen", 14}, {"fifteen", 15}, {"sixteen", 16}, {"seventeen", 17}, {"eighteen", 18}, {"nineteen", 19}}; 
    // //private static Dictionary<string, int> _2DigitNames = new Dictionary<string, int> {{"zero", 0}, {"ten", 10}, {"twenty", 2}, {"thirty", 3}, {"fourty", 4}, {"fifty", 5}, {"sixty", 6}, {"seventy", 7}, {"eighty", 8}, {"ninety", 9}};

    // private static List<string> _1DigitList = new List<string> {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    // private static List<string> _2DigitList = new List<string> {"zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};

    // public ToWords(int givenNumber)
    // {
    //   _givenNumber = givenNumber;
    // }

    // public string GivenNumberToWords()
    // {
    //   string returnString = "";
    //   if (_givenNumber < 0)
    //   {
    //     returnString += "negative";
    //   }

    //   if (_givenNumber < 20)
    //   {
    //     foreach (KeyValuePair<string, int> entry in _oneToNineTeen)
    //     {
    //       if (entry.Value == _givenNumber)
    //       {
    //         returnString += entry.Key;
    //       }
    //     }
    //     return returnString;
    //   }

    //   int index = 0;
    //   int counter = 0;
    //   while (index < _numberArray.Length) 
    //   {
    //     if (_givenNumber >= _numberArray[index]) 
    //     {
    //       _givenNumber -= _numberArray[index];
    //       counter ++;
    //     }
    //     else
    //     {
    //       if (counter > 0) 
    //       {
    //         if(index == 2)
    //         {
    //           returnString += _2DigitList[counter] + " ";
    //         }
    //         else if (index == 3)
    //         {
    //           returnString += _1DigitList[counter] + " ";
    //         }
    //         counter = 0;
    //       }
    //       index ++;
    //     }
    //   }
    //   return returnString;
    // }
  }
}