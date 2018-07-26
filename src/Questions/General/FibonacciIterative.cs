using System;

namespace NetCore.Questions.General
{
    public class FibonacciIterative : IQuestion
    {
        public void Run()
        {
            AnswerQuestion(3);
            AnswerQuestion(4);
            AnswerQuestion(5);
            AnswerQuestion(6);
            AnswerQuestion(7);
        }

        public void AnswerQuestion(int n)
        {
            Console.WriteLine($"Finding iterative fibonacci of {n}...");
            Console.WriteLine(FindFibonacciNumber(n));
        }

        public int FindFibonacciNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int sumA = 0;
                int sumB = 1;

                for(int i = 2; i < n; i++)
                {
                    int newSum = sumA + sumB;
                    sumA = sumB;
                    sumB = newSum;
                }

                return sumA + sumB;
            }
        }
    }
}