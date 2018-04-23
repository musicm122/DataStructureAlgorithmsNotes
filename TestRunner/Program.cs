using System;
using System.Collections.Generic;
using System.Linq;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Problems.MangoSellerProblemBreathFirst());
        }

        static void SumTest2()
        {
            var n = 26;
            var range = Enumerable.Range(1, n).Aggregate((n1, n2) => n1 * n2);
        }

        static void MaxNumberTest()
        {
            var result = Algo.MaxNumber(new int[] { 1, 2, 3, 10, 200, 13, 4, 2000, 2, -2, 3 });
            Console.WriteLine(result.ToString());
        }

        static void Fibonacci_RecursiveTest()
        {
            var n = 26;
            var fib = Algo.GetFibonacciDigitRecursive(n);
            Console.WriteLine(fib);
        }

        static void Fibonacci_MemoizeBottomUpTest()
        {
            var n = 26;
            var fib = Algo.GetFibonacciDigitMemoizeBottomUp(n);
            Console.WriteLine(fib);
        }

        static void AdjacentElementsProductTest()
        {
            var testCases = new int[][]
            {
                new int[] { 3, 6, -2, -5, 7, 3 },
                new int[] {-1, -2 },
                new int[] { 5, 1, 2, 3, 1, 4 }
            };

            foreach (var testItem in testCases)
            {
                Console.WriteLine($"{testItem.ToString()} : {adjacentElementsProduct(testItem).ToString()}");
            }

        }

        static void PalindromeTest()
        {
            var testVals = new List<String>() { "aabaa", "abac", "a", "az", "abacaba" };

            foreach (var testItem in testVals)
            {
                Console.WriteLine($"{testItem} : {checkPalindrome(testItem).ToString()}");
            }

        }

        static void SumTest()
        {
            var sumableValue = new int[] { 1, 2, 3 };
            var result = Algo.RecursiveSum(sumableValue);
            Console.WriteLine(result);
        }

        static void ArrayCount()
        {
            var sumableValue = new int[] { 1, 2, 3 };
            var count = Algo.RecursiveCount(sumableValue);
            Console.WriteLine(count);

        }

        static void RunSortTest()
        {
            var unsortedArray = new int[] { 1, 2, 4, 3, 1, 2, 3 };
            var sortedArray = Sorts.QuickSort(unsortedArray);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i].ToString());
            }

        }

        //if int arg is greater than the hundredth value add 1 else 
        public static int ConvertToHundredths(int val) => (int)(val * 0.010);
        public static int ConvertToThousands(int val) => (val * 100);

        public static int CenturyFromYear(int year)
        {
            var hundredthVal = ConvertToHundredths(year);
            var thousandsVal = ConvertToThousands(hundredthVal);
            return thousandsVal < year ? hundredthVal + 1 : hundredthVal;
        }

        static bool checkPalindrome(string inputString) => Reverse(inputString) == inputString;

        public static string Reverse(string input)
        {
            var reverse = new char[input.Length];
            int i = input.Length - 1;
            int reverseIndex = 0;
            for (; i >= 0; i--)
            {
                reverse[reverseIndex] = input[i];
                reverseIndex++;
            }
            return new String(reverse);
        }

        public static int adjacentElementsProduct(int[] inputArray)
        {
            var values = new int[inputArray.Length - 1];
            var highVal = inputArray[0] * inputArray[1];
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int temp = inputArray[i] * inputArray[i + 1];
                highVal = highVal < temp ? temp : highVal;
            }

            return highVal;
        }

        /*
        static int centuryFromYear(int year)
        {
        }

        static int GetMaxYear(int year)
        {
            if (year < 100)
            {
                return 1;
            }
            year * 0.0;
        }
        */

    }
}