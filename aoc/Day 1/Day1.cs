using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc.Day_1
{
    internal class Day1
    {
        int sum = 0;
        string[] NumStrings = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        List<char> GetDigitsFromString(string Input)
        {
            List<char> digits = new List<char>();

            for (int i = 0; i < Input.Length; i++)
            {
                if (char.IsDigit(Input[i]))
                    digits.Add(Input[i]);

                // Part 2
                string subString = Input.Substring(i);
                for (int j = 0; j < NumStrings.Length; j++)
                {
                    bool isDigit = subString.StartsWith(NumStrings[j]);
                    if (isDigit)
                    {
                        digits.Add((j + 1).ToString()[0]); // Removes Unicode
                    }
                }
            }
            return digits;
        }

        int GetNumberInString(string Input)
        {
            List<char> chars = GetDigitsFromString(Input);
            string Num = chars.First().ToString() + chars.Last();
            return int.Parse(Num);
        }

        int GetSum(string[] Input)
        {
            for (int i = 0; i < Input.Length; i++)
            {
                sum += GetNumberInString(Input[i]);
            }
            return sum;
        }

        public void Start(string[] Input)
        {
            Console.WriteLine(GetSum(Input));
        }
    }
}
