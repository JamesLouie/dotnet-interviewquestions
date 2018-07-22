using System;

namespace NetCore.Questions.Recursion
{
    public class RecursiveReverseString: IQuestion
    {
        public void Run()
        {
            AnswerQuestion("hi");
            AnswerQuestion("pocket");
            AnswerQuestion("hooheeh");
        }

        public void AnswerQuestion(string s)
        {
            Console.WriteLine($"Find Reversing string {s}...");
            Console.WriteLine(Reverse(s));
        }

        public string Reverse(string s)
        {
            if (s.Length == 0)
            {
                return "";
            }
            else
            {
                return Reverse(s.Substring(1, s.Length-1)) + s.Substring(0,1);
            }
        }

    }
}
