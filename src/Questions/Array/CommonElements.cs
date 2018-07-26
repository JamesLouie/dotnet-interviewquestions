using System;
using System.Collections.Generic;

namespace NetCore.Questions.Array
{
    public class CommonElements : IQuestion
    {
        public void Run()
        {
            AnswerQuestion(new int[] {1, 1, 2, 3, 0, 3 , 4, 4, 5,6}, new int[] {0,0,0,0,0,1});
            AnswerQuestion(new int[] {0,1 ,3 ,4 ,4, 6,6}, new int[] { 2, 7});
        }

        public void AnswerQuestion(int[] first, int[] second)
        {
            Console.WriteLine("Finding Common Elements in arrays...");
            Console.WriteLine($"[{String.Join(",", first)}]");
            Console.WriteLine($"[{String.Join(",", second)}]");
            Console.WriteLine($"Commmon elements: [{String.Join(",", Compare(first, second))}]");
        }

        // Complexity O(2n)
        // Space O(2n)
        public HashSet<int> Compare(int[] first, int[] second)
        {
            var returnSet = new HashSet<int>();
            var set = new HashSet<int>();

            // O(n)
            foreach(var element in first)
            {
                set.Add(element);
            }

            // O(n)
            foreach(var element in second)
            {
                if (set.Contains(element))
                {
                    returnSet.Add(element);
                }
            }

            return returnSet;
        }
    }
}