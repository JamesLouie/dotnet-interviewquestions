using System;

namespace NetCore.Questions.Strings
{
    public class PalindromeString : IQuestion
    {
        public void Run()
        {
            AnswerQuestion("ababa");
            AnswerQuestion("abba");
            AnswerQuestion("abca");
            AnswerQuestion("acbba");
        }

        public void AnswerQuestion(string s)
        {
            Console.WriteLine($"Determining if {s} is a palindrome...");
            Console.WriteLine(IsPalindrome(s));
        }

        public bool IsPalindrome(string s)
        {
            var charArray = s.ToCharArray();
            
            var index = 0;

            while (index < Math.Floor((double)s.Length / 2))
            {
                if (charArray[index] != charArray[s.Length - 1 - index])
                {
                    return false;
                }
                index++;
            }

            return true;
        }
    }
}