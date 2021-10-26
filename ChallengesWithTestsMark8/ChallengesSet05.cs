using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return startNumber + (n - startNumber % n);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
                if (business.TotalRevenue == 0)
                    business.Name = "CLOSED";
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers is null || numbers.Length == 0) return false;
            for (int i = 1; i < numbers.Length; ++i)
                if (numbers[i] < numbers[i - 1]) return false;
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers is null) return 0;
            int sum = 0;
            for (int i = 1; i < numbers.Length; ++i) if (numbers[i - 1] % 2 == 0) sum += numbers[i];
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words is null) return "";
            List<string> strings = new List<string>();
            foreach(string word in words)
            {
                string trimmed = word.Trim();
                if (trimmed != "") strings.Add(trimmed);
            }
            if (strings.Count == 0) return "";
            return String.Join(" ", strings) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements is null || elements.Count < 4) return new double[0];
            double[] result = new double[elements.Count / 4];
            for (int i = 3; i < elements.Count; i += 4) result[i / 4] = elements[i];
            return result;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            Dictionary<int, int> indexes = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i) indexes[nums[i]] = i;
            for (int i = 0; i < nums.Length; ++i)
                if (indexes.ContainsKey(targetNumber - nums[i]) && indexes[targetNumber - nums[i]] != i) return true;
            return false;

        }
    }
}
