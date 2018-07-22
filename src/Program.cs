using System;
using NetCore.Questions.Recursion;
using NetCore.Questions;
using System.Collections.Generic;

namespace NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IQuestion> questions = new List<IQuestion>();
            //questions.Add(new RecursiveFactorial());
            //questions.Add(new RecursiveSumOfDigits());
            //questions.Add(new RecursivePowers());
            //questions.Add(new RecursiveLinkedList());
            //questions.Add(new RecursiveFibonacci());
            questions.Add(new RecursiveReverseString());

            foreach(var question in questions)
            {
                question.Run();
            }
        }
    }
}
