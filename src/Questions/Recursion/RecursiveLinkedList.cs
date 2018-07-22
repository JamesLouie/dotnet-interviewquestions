using System;

namespace NetCore.Questions.Recursion
{
    public class RecursiveLinkedList: IQuestion
    {
        public void Run()
        {
            // LL = A -> B -> C
            var nodeA = new Node(5);
            var nodeB = new Node(9);
            var nodeC = new Node(1);
            nodeA.Next = nodeB;
            nodeB.Next = nodeC;
            LinkedList LL = new LinkedList();
            LL.Head = nodeA;

            AnswerQuestion(LL);
        }

        private void AnswerQuestion(LinkedList ll)
        {
            Console.WriteLine("Reversing Linked List");
            Node currentNode = ll.Head;
            while(currentNode != null)
            {
                Console.WriteLine($"Original Order: {currentNode.Data}");
                currentNode = currentNode.Next;
            }

            var reversed = Reverse(ll.Head, null);

            while(reversed != null)
            {
                Console.WriteLine($"Reversed Order: {reversed.Data}");
                reversed = reversed.Next;
            }
        }

        private Node Reverse(Node startNode, Node n)
        {
            // Save Reference
            var actualNextNode = startNode.Next;

            // Flip
            startNode.Next = n;

            
            // Base Case
            if (actualNextNode == null)
            {
                return startNode;
            }
            else
            {
                // Definition
                return Reverse(actualNextNode, startNode);
            }
        }



        // Test Setup
        private class LinkedList
        {
            public Node Head;
        }

        private class Node
        {
            public Node(int data)
            {
                this.Data = data;
            }

            public int Data;
            public Node Next;
        }
    }
}
