using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
                if (num % 2 == 0)
                    sum += num;
                else
                    sum -= num;
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return GetSmallestNumber(str1.Length, str2.Length, str3.Length, str4.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(number1, Math.Min(number2, Math.Min(number3, number4)));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            System.Collections.Generic.List<int> triangle = new System.Collections.Generic.List<int>(new int[]{sideLength1, sideLength2, sideLength3});
            triangle.Sort();
            return triangle[0] + triangle[1] > triangle[2];
        }

        public bool IsStringANumber(string input)
        {
            try
            {
                Double.Parse(input);
                return true;
            } catch
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int num_nulls = 0;
            foreach (var obj in objs)
                if (obj is null) num_nulls += 1;
            return num_nulls > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers is null) return 0;
            int sum=0, num_evens=0;
            foreach(int num in numbers)
                if (num%2==0)
                {
                    sum += num;
                    ++num_evens;
                }
            if (num_evens == 0) return 0;
            return (sum * 1.0) / num_evens;
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            int result = 1;
            for (int i = 2; i <= number; ++i) result *= i;
            return result;
        }
    }
}
