using System;
using NetCore.Questions.Array;
using NetCore.Questions.Recursion;
using NetCore.Questions.General;
using NetCore.Questions.Queues;
using NetCore.Questions.Strings;
using NetCore.Questions.Trees;
using NetCore.Questions;
using System.Collections.Generic;

namespace NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IQuestion> questions = new List<IQuestion>();
            
            // Recursion
            //questions.Add(new RecursiveFactorial());
            //questions.Add(new RecursiveSumOfDigits());
            //questions.Add(new RecursivePowers());
            //questions.Add(new RecursiveLinkedList());
            //questions.Add(new RecursiveFibonacci());
            //questions.Add(new RecursiveReverseString());
            
            // Arrays
            //questions.Add(new MostFrequentInteger());
            //questions.Add(new CommonElements());

            // General
            //questions.Add(new FibonacciIterative());

            // Queues
            //questions.Add(new TwoStackQueueQuestion());
            //questions.Add(new NthElementQueue());

            // Strings
            //questions.Add(new PalindromeString());
            questions.Add(new FirstRepeatedChar());

            // Trees
            //questions.Add(new BinarySearchTreeImpl());
            //questions.Add(new GenericTreeImpl());

            foreach(var question in questions)
            {
                question.Run();
            }
        }
    }
}
