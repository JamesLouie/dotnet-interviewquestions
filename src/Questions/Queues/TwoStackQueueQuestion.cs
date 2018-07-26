using System;
using System.Collections.Generic;

namespace NetCore.Questions.Queues
{
    public class TwoStackQueueQuestion : IQuestion
    {
        public void Run()
        {
            AnswerQuestion();
        }

        public void AnswerQuestion()
        {
            var queue = new TwoStackQueue<int>();

            queue.enqueue(1);
            Console.WriteLine("Pushing 1");
            queue.enqueue(2);
            Console.WriteLine("Pushing 2");
            queue.enqueue(3);
            Console.WriteLine("Pushing 3");
            var firstPop = queue.dequeue();
            Console.WriteLine($"First element popped: {firstPop}");
            queue.enqueue(5);
            Console.WriteLine("Pushing 5");
            var secondPop = queue.dequeue();
            Console.WriteLine($"Second element popped: {secondPop}");
            var thirdPop = queue.dequeue();
            Console.WriteLine($"Third element popped: {thirdPop}");
            var fourthPop = queue.dequeue();
            Console.WriteLine($"Fourth element popped: {fourthPop}");

            try 
            {
                var fifthPop = queue.dequeue();
            }
            catch
            {
                Console.WriteLine("Hit expected exception");
            }

        }

        public class TwoStackQueue<T>
        {
            public Stack<T> stackOne;
            public Stack<T> stackTwo;

            public TwoStackQueue()
            {
                stackOne = new Stack<T>();
                stackTwo = new Stack<T>();
            }

            public void enqueue(T item)
            {
                stackOne.Push(item);
            }

            public T dequeue()
            {
                if (stackOne.Count == 0 && stackTwo.Count == 0)
                {
                    throw new Exception("Unable to dequeue");
                }

                if (stackTwo.Count == 0)
                {
                    while(stackOne.Count > 0)
                    {
                        T popped = stackOne.Pop();
                        stackTwo.Push(popped);
                    }
                }

                return stackTwo.Pop();
            }
        }
    }
}