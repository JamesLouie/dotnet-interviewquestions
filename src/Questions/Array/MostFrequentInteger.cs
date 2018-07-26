using System;
using System.Collections.Generic;
using System.Linq;

namespace NetCore.Questions.Array
{
    public class MostFrequentInteger : IQuestion
    {
        public void Run()
        {
            AnswerQuestion(new int[] { 1, 1, 1, 2, 3, 3, 4, 3, 3, 3, 2, 3, 4, 5 });
            AnswerQuestion(new int[] { 0, 11, 11, 0, 1, 2, 2, 3, 4, 5});
        }

        public void AnswerQuestion(int[] input)
        {
            Console.WriteLine("Find the most frequent integer in array....");
            Console.WriteLine($"[{String.Join(",",input)}]");
            Console.WriteLine(FindMostFrequentInteger(input));
        }

        public int FindMostFrequentInteger(int[] input)
        {
            var dic = new Dictionary<int, int>();
            foreach(var i in input)
            {
                if (dic.TryGetValue(i, out int count)) 
                {
                    dic[i] = count + 1;
                }
                else
                {
                    dic.Add(i, 1);
                }
            }
            
            KeyValuePair<int,int> mostFrequentPair = new KeyValuePair<int,int>(0,0);
            
            foreach(var kvp in dic)
            {
                if (kvp.Value > mostFrequentPair.Value)
                {
                    mostFrequentPair = kvp;
                }
            }

            return mostFrequentPair.Key;
        }
    }
}