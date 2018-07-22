using System;

namespace NetCore.Questions.Recursion
{
    public class RecursiveSumOfDigits: IQuestion
    {
        public void Run()
        {
            AnswerQuestion(0);
            AnswerQuestion(100);
            AnswerQuestion(4);
            AnswerQuestion(202);
            AnswerQuestion(1234901);
        }

        public void AnswerQuestion(int n)
        {
            Console.WriteLine($"Find Sum of Digits of {n}...");
            Console.WriteLine(FindSum(n));
        }

        public int FindSum(int n)
        {
            if (n < 0)
            {
                throw new Exception("Unable to handle negative numbers");
            }

            // Base Case
            if (n < 10)
            {
                return n;
            }
            else
            {
                // Definition
                var digit = n % 10;
                return FindSum((int)Math.Floor((decimal)n / 10)) + digit;
            }
        }
    }
}
