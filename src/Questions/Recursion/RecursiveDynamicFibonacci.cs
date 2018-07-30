using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace NetCore.Questions.Recursion
{
    public class RecursiveDynamicFibonacci : IQuestion
    {
        public void Run()
        {
            //AnswerQuestion(3);
            //AnswerQuestion(4);
            //AnswerQuestion(5);
            //AnswerQuestion(6);
            //AnswerQuestion(7);
            //AnswerQuestion(100);
            AnswerQuestion(40);
            AnswerQuestion(1000);
        }

        public void AnswerQuestion(int n)
        {
            var watch = new Stopwatch();
            watch.Start();
            Console.WriteLine($"Finding dynamic recursive fibonacci of {n}...");
            var dic = new Dictionary<int,int>();
            Console.WriteLine(Fib(n, ref dic));
            watch.Stop();
            Console.WriteLine($"Function took {watch.ElapsedMilliseconds} to run");
        }

        public int Fib(int n, ref Dictionary<int,int> dic)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else if (dic.TryGetValue(n, out int saved))
            {
                return saved;
            }
            else
            {
                var calculatedFibAtN = Fib(n-1, ref dic) + Fib(n-2, ref dic);
                dic.Add(n, calculatedFibAtN);
                return calculatedFibAtN;
            }
        }
    }
}