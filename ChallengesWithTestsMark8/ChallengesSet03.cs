using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
                if (val == false)
                    return true;
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers is null) return false;
            int num_odds = 0;
            foreach (int num in numbers)
                if (num % 2 != 0) num_odds += 1;
            return num_odds % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false, lower = false, number = false;
            foreach (char c in password)
            {
                if (Char.IsUpper(c))
                    upper = true;
                else if (Char.IsLower(c))
                    lower = true;
                else if (Char.IsNumber(c))
                    number = true;
                if (upper && lower && number) return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int []results = new int[50];
            for (int i = 1; i < 100; i += 2) results[i / 2] = i;
            return results;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; ++i)
                words[i] = words[i].ToUpper();
        }
    }
}
