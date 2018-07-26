using System;
using System.Collections.Generic;

namespace NetCore.Questions.Queues
{
    public class NthElementQueue : IQuestion
    {
        public void Run()
        {
            var linkListOne = new LinkedList<int>();
            linkListOne.AddFirst(1);
            linkListOne.AddFirst(2);
            linkListOne.AddFirst(3);
            linkListOne.AddFirst(4);

            AnswerQuestion(linkListOne, 3);
            AnswerQuestion(linkListOne, 4);
        }

        public void AnswerQuestion(LinkedList<int> ll, int k)
        {
            Console.WriteLine($"Finding {k} to last element...");
            Console.WriteLine(FindKthElement(ll, k));
        }

        public int FindKthElement(LinkedList<int> ll, int k)
        {
            LinkedListNode<int> kNode = ll.First;
            LinkedListNode<int> runnerNode = ll.First;

            // Run the node
            for(int i = 0; i < k-1; i++)
            {
                if (runnerNode.Next == null)
                {
                    throw new Exception("List not long enough");
                }
                runnerNode = runnerNode.Next;
            }

            // Run both nodes
            while (runnerNode.Next != null)
            {
                runnerNode = runnerNode.Next;
                kNode = kNode.Next;
            }

            return kNode.Value;
        }
    }
}