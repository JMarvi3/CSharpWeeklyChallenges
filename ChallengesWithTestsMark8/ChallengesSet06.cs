using System;
using System.Collections;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words is null) return false;
            if (ignoreCase) word = word.ToUpper();
            foreach(string w in words)
            {
                if (w is null) continue;
                if ((ignoreCase && (w.ToUpper() == word)) || (w == word)) return true;
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            bool prime = num > 1;
            for(int i=2; i*i<=num; i+=1)
                if (num%i==0)
                {
                    return false;
                }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            Dictionary<char, int> lastIndex = new Dictionary<char, int>(), count = new Dictionary<char, int>();
            for(int i=0; i<str.Length; ++i)
            {
                lastIndex[str[i]] = i;
                if (count.ContainsKey(str[i]))
                    count[str[i]] = count[str[i]] + 1;
                else
                    count[str[i]] = 1;
            }
            int last = -1;
            foreach(char c in lastIndex.Keys)
            {
                if (count[c] == 1)
                    last = Math.Max(last, lastIndex[c]);
            }
            return last;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int max_count = 0, count = 1;
            for (int i = 1; i < numbers.Length; ++i)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    ++count;
                }
                else
                {
                    max_count = Math.Max(max_count, count);
                    count = 1;
                }
            }
            return Math.Max(max_count, count);
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements is null || n<=0 || elements.Count < n) return new double[0];
            double[] result = new double[elements.Count / n];
            for (int i = n - 1; i < elements.Count; i += n) result[i / n] = elements[i];
            return result;
        }
    }
}
