using System;

namespace NetCore.Questions.Recursion
{
    public class RecursivePowers: IQuestion
    {
        public void Run()
        {
            AnswerQuestion(10, 3);
            AnswerQuestion(5, 4);
        }

        public void AnswerQuestion(int baseNum, int n)
        {
            Console.WriteLine($"Find {baseNum} to the power of {n}...");
            Console.WriteLine(FindPowers(baseNum, n));
        }

        public int FindPowers(int baseNum, int n)
        {
            // Base Case
            if (n == 1)
            {
                return baseNum;
            }
            else
            {
                // Definition
                return baseNum * FindPowers(baseNum, n-1);
            }
        }
    }
}
