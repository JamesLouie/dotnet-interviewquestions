using System;

namespace NetCore.Questions.Queues
{
    public class FindLoopInQueue : IQuestion
    {
        public void Run()
        {
            var n1 = new Node(1);
            var n2 = new Node(2);
            var n3 = new Node(3);
            var n4 = new Node(4);
            var n5 = new Node(5);
            var n6 = new Node(6);
            var n7 = new Node(7);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = n7;
            n7.next = n4;

            AnswerQuestion(n1);

            n7.next = null;

            AnswerQuestion(n1);
        }

        public void AnswerQuestion(Node root)
        {
            Console.WriteLine("Checking if linked list contains loop");
            Console.WriteLine(ContainsLoop(root));
        }

        public bool ContainsLoop(Node root)
        {
            Node firstRunner = root;
            Node secondRunner = root;

            while (secondRunner.next != null)
            {
                firstRunner = firstRunner.next;
                secondRunner = secondRunner?.next?.next;

                if (secondRunner == null)
                {
                    break;
                }

                if (firstRunner == secondRunner)
                {
                    return true;
                }
            }

            return false;
        }


        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }
    }
}