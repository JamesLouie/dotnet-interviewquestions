using System;

namespace NetCore.Questions.Recursion
{
    public class RecursiveFactorial: IQuestion
    {
        public void Run()
        {
            AnswerQuestion(5);
            AnswerQuestion(4);
            AnswerQuestion(20);
        }

        public void AnswerQuestion(int n)
        {
            Console.WriteLine($"Find Factorialing {n}...");
            Console.WriteLine(FindFactorial(n));
        }

        public int FindFactorial(int n)
        {
            // Base Case
            if (n == 1)
            {
                return 1;
            }
            else
            {
                // Definition
                return n * FindFactorial(n-1);
            }
        }
    }
}
