using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TestRunner
{

   }



    public static class Sorts
    {
        public static int[] QuickSort (int[] items)
        {
            if (items.Length < 2)
            {
                return items;
            }
            else
            {
                var pivot = items[0];
                var less = items.Where (i => i < pivot);
                less.Append (pivot);
                var greater = items.Where (i => i > pivot);

                return QuickSort (less.Concat (greater).ToArray ());
            }
        }

    }

    public static class Problems
    {
        public static string MangoSellerProblemBreathFirst ()
        {
            bool PersonIsSeller (string personName) => personName[personName.Length - 1] == 'm';
            Dictionary<string, string[]> GetPersonGraph ()
            {
                var graph = new Dictionary<string, string[]> ();
                graph.Add ("you", new string[] { "alice", "bob", "claire" });
                graph.Add ("bob", new string[] { "anuj", "peggy" });
                graph.Add ("alice", new string[] { "peggy" });
                graph.Add ("claire", new string[] { "thom", "jonny" });
                graph.Add ("anuj", new string[0]);
                graph.Add ("peggy", new string[0]);
                graph.Add ("thom", new string[0]);
                graph.Add ("jonny", new string[0]);
                return graph;
            }

            Queue<String> GetPersonQueue ()
            {
                var evalQueue = new Queue<string> ();
                evalQueue.Enqueue ("you");
                return evalQueue;
            }

            var searched = new HashSet<String> ();
            var relationsGraph = GetPersonGraph ();

            var searchQueue = GetPersonQueue ();

            while (searchQueue.Count > 0)
            {
                var currentPerson = searchQueue.Dequeue ();
                if (PersonIsSeller (currentPerson))
                {

                    searched.Add (currentPerson);
                    Console.WriteLine ($"Match Found!\r\n Listing Persons Searched...");
                    foreach (var personSearched in searched)
                    {
                        Console.WriteLine ($"Searched {personSearched}");
                    }
                    Console.WriteLine ($"The Mango Seller is {currentPerson}");
                    return currentPerson;
                }
                else if (!searched.Contains (currentPerson))
                {
                    searched.Add (currentPerson);
                    foreach (var person in relationsGraph[currentPerson])
                    {
                        searchQueue.Enqueue (person);
                    }
                }
            }
            return "No Mango Seller Found";
        }
    }

    public static class Algo
    {
        public static void Dijkstra ()
        {
            Dictionary<string, string[]> GetPersonGraph ()
            {
                var graph = new Dictionary<string,> ();
                graph.Add ("start", new string[] { "alice", "bob", "claire" });
                graph.Add ("bob", new string[] { "anuj", "peggy" });
                graph.Add ("alice", new string[] { "peggy" });
                graph.Add ("claire", new string[] { "thom", "jonny" });
                graph.Add ("anuj", new string[0]);
                graph.Add ("peggy", new string[0]);
                graph.Add ("thom", new string[0]);
                graph.Add ("jonny", new string[0]);
                return graph;
            }

        }

        public static int GetFibonacciDigit (int fibDigit) => (fibDigit <= 1) ? fibDigit : GetFibonacciDigit (fibDigit - 1) + GetFibonacciDigit (fibDigit - 2);

        //if int arg is greater than the hundreth value add 1 else 
        public static int ConvertToHundreths (int val) => (int) (val * 0.010);
        public static int ConvertToThousands (int val) => (val * 100);

        public static int CenturyFromYear (int year)
        {
            var hundrethVal = ConvertToHundreths (year);
            var thousandsVal = ConvertToThousands (hundrethVal);
            return thousandsVal < year ? hundrethVal + 1 : hundrethVal;
        }

        public static bool checkPalindrome (string inputString) => Reverse (inputString) == inputString;

        public static string Reverse (string input)
        {
            var reverse = new char[input.Length];
            int i = input.Length - 1;
            int reverseIndex = 0;
            for (; i >= 0; i--)
            {
                reverse[reverseIndex] = input[i];
                reverseIndex++;
            }
            return new String (reverse);
        }

        public static int adjacentElementsProduct (int[] inputArray)
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

        public static int RecursiveSum (int[] items)
        {
            if (items.Length == 0)
            {
                return 0;
            }
            else
            {
                var currentLength = items.Length;
                int[] newArray = new int[currentLength - 1];
                Array.Copy (items, newArray, newArray.Length);
                return items[currentLength - 1] + RecursiveSum (newArray);
            }
        }

        public static int RecursiveCount (int[] items, int counter = 0)
        {
            if (items.Length == 0)
            {
                return counter;
            }
            else
            {
                var currentLength = items.Length;
                int[] newArray = new int[currentLength - 1];
                Array.Copy (items, newArray, newArray.Length);
                return RecursiveCount (newArray, ++counter);
            }
        }

        public static int MaxNumber (int[] arr, int currentMax = 0)
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
                Array.Copy (arr, newArr, lastIndex);
                return MaxNumber (newArr, currentMax);
            }
        }
    }
}