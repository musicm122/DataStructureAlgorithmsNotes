using System;
using System.Collections.Generic;

namespace TestRunner
{
    public static class Problems
    {
        public static string MangoSellerProblemBreathFirst()
        {
            bool PersonIsSeller(string personName) => personName[personName.Length - 1] == 'm';
            Dictionary<string, string[]> GetPersonGraph()
            {
                var graph = new Dictionary<string, string[]>();
                graph.Add("you", new string[] { "alice", "bob", "claire" });
                graph.Add("bob", new string[] { "anuj", "peggy" });
                graph.Add("alice", new string[] { "peggy" });
                graph.Add("claire", new string[] { "thom", "jonny" });
                graph.Add("anuj", new string[0]);
                graph.Add("peggy", new string[0]);
                graph.Add("thom", new string[0]);
                graph.Add("jonny", new string[0]);
                return graph;
            }

            Queue<String> GetPersonQueue()
            {
                var evalQueue = new Queue<string>();
                evalQueue.Enqueue("you");
                return evalQueue;
            }

            var searched = new HashSet<String>();
            var relationsGraph = GetPersonGraph();

            var searchQueue = GetPersonQueue();

            while (searchQueue.Count > 0)
            {
                var currentPerson = searchQueue.Dequeue();
                if (PersonIsSeller(currentPerson))
                {

                    searched.Add(currentPerson);
                    Console.WriteLine($"Match Found!\r\n Listing Persons Searched...");
                    foreach (var personSearched in searched)
                    {
                        Console.WriteLine($"Searched {personSearched}");
                    }
                    Console.WriteLine($"The Mango Seller is {currentPerson}");
                    return currentPerson;
                }
                else if (!searched.Contains(currentPerson))
                {
                    searched.Add(currentPerson);
                    foreach (var person in relationsGraph[currentPerson])
                    {
                        searchQueue.Enqueue(person);
                    }
                }
            }
            return "No Mango Seller Found";
        }
    }
}