using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers is null) return 0;
            double min_value = Double.MaxValue, max_value = Double.MinValue;
            foreach (double num in numbers)
            {
                if (num < min_value)
                    min_value = num;
                if (num > max_value)
                    max_value = num;
            }
            return max_value + min_value;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int len_str1 = str1.Length, len_str2 = str2.Length;
            if (len_str1 < len_str2)
                return len_str1;
            else
                return len_str2;
        }

        public int Sum(int[] numbers)
        {
            if (numbers is null) return 0;
            int sum = 0;
            foreach (var num in numbers)
                sum += num;
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers is null) return 0;
            int sum = 0;
            foreach (var num in numbers)
                if (num % 2 == 0) sum += num;
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers is null) return false;
            int sum = 0;
            foreach (var num in numbers) sum += num;
            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0) return 0;
            return number / 2;
        }
    }
}
