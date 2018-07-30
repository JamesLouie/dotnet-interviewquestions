using System;
using System.Collections.Generic;
using System.Linq;

namespace NetCore.Questions.Trees
{
    public class GenericTreeImpl : IQuestion
    {
        public void Run()
        {
            AnswerQuestion();
        }

        public void AnswerQuestion()
        {
            var n1 = new Node<int>(1);
            var n2 = new Node<int>(2);
            var n3 = new Node<int>(3);
            var n4 = new Node<int>(4);
            var n5 = new Node<int>(5);
            var n6 = new Node<int>(6);
            var n7 = new Node<int>(7);
            var n8 = new Node<int>(8);

            n2.AddChild(n1);
            n2.AddChild(n3);
            n4.AddChild(n2);
            n5.AddChild(n4);
            n5.AddChild(n6);
            n7.AddChild(n8);
            n5.AddChild(n7);

            var tree = new GenericTree<int>();
            tree.Root = n5;

            tree.PrintByLevel();
        }

        public class GenericTree<T>
        {
            public Node<T> Root;

            public void PrintByLevel()
            {
                var levelNodes = new List<Node<T>>();
                var queue = new Queue<Node<T>>();

                Console.WriteLine("printing first level: " + Root.data);

                levelNodes.Add(Root);

                while(levelNodes.Count > 0)
                {
                    // Print out current level
                    Console.WriteLine($"Printing Level: [{string.Join(",",levelNodes.Select(n => n.data).ToArray())}]");

                    // Reset list
                    var nextLevel = new List<Node<T>>();

                    // Add next level
                    foreach(var node in levelNodes)
                    {
                        nextLevel.AddRange(node.children);
                    }

                    // Set loop condition
                    levelNodes = nextLevel;
                }
            }
        }

        public class Node<T>
        {
            public T data;
            public List<Node<T>> children;

            public Node(T data)
            {
                this.data = data;
                children = new List<Node<T>>();
            }

            public void AddChild(Node<T> child)
            {
                children.Add(child);
            }
        }


    }



}