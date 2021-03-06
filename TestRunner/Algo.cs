﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace TestRunner
{

    public static class Algo
    {

        public static int GetFibonacciDigitMemoizeBottomUp(int fibDigit)
        {
            if (fibDigit == 0 || fibDigit == 1)
            {
                return fibDigit;
            }

            var memoizedValues = new int[fibDigit];

            if (memoizedValues[fibDigit] != default(int))
            {
                return memoizedValues[fibDigit];
            }

            memoizedValues[fibDigit] = memoizedValues[fibDigit - 1] + memoizedValues[fibDigit - 2];

            return memoizedValues[fibDigit];
        }
        public static int GetFibonacciDigitRecursive(int fibDigit) => (fibDigit <= 1) ? fibDigit : GetFibonacciDigitRecursive(fibDigit - 1) + GetFibonacciDigitRecursive(fibDigit - 2);

        //if int arg is greater than the hundreth value add 1 else 
        public static int ConvertToHundreths(int val) => (int)(val * 0.010);
        public static int ConvertToThousands(int val) => (val * 100);

        public static int CenturyFromYear(int year)
        {
            var hundrethVal = ConvertToHundreths(year);
            var thousandsVal = ConvertToThousands(hundrethVal);
            return thousandsVal < year ? hundrethVal + 1 : hundrethVal;
        }

        public static bool checkPalindrome(string inputString) => Reverse(inputString) == inputString;

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

        public static int RecursiveSum(int[] items)
        {
            if (items.Length == 0)
            {
                return 0;
            }
            else
            {
                var currentLength = items.Length;
                int[] newArray = new int[currentLength - 1];
                Array.Copy(items, newArray, newArray.Length);
                return items[currentLength - 1] + RecursiveSum(newArray);
            }
        }

        public static int RecursiveCount(int[] items, int counter = 0)
        {
            if (items.Length == 0)
            {
                return counter;
            }
            else
            {
                var currentLength = items.Length;
                int[] newArray = new int[currentLength - 1];
                Array.Copy(items, newArray, newArray.Length);
                return RecursiveCount(newArray, ++counter);
            }
        }

        public static int MaxNumber(int[] arr, int currentMax = 0)
        {
            if (arr.Length == 1)
            {
                return currentMax;
            }
            else
            {
                var lastIndex = arr.Length - 1;
                currentMax = (currentMax < arr[lastIndex]) ? arr[lastIndex] : currentMax;
                var newArr = new int[lastIndex];
                Array.Copy(arr, newArr, lastIndex);
                return MaxNumber(newArr, currentMax);
            }
        }
    }
}