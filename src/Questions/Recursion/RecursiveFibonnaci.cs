using System;
using System.Diagnostics;

namespace NetCore.Questions.Recursion
{
    public class RecursiveFibonacci: IQuestion
    {
        public void Run()
        {
            //AnswerQuestion(3);
            //AnswerQuestion(7);
            //AnswerQuestion(10);
            //AnswerQuestion(20);
            AnswerQuestion(40);
        }

        public void AnswerQuestion(int n)
        {
            var watch = new Stopwatch();
            watch.Start();
            Console.WriteLine($"Find Fibonacci {n}...");
            Console.WriteLine(FindFibonacci(n));
            watch.Stop();
            Console.WriteLine($"Function took {watch.ElapsedMilliseconds} to run");
        }

        private int FindFibonacci(int n)
        {
            // Base Cases
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {   // Definition
                return FindFibonacci(n-1) + FindFibonacci(n-2);
            }
        }
    }
}
