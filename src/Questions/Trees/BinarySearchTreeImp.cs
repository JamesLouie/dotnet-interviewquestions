using System;

namespace NetCore.Questions.Trees
{
    public class BinarySearchTreeImpl : IQuestion
    {
        public void Run()
        {
            AnswerQuestion();
        }

        public void AnswerQuestion()
        {
            var tree = new BinarySearchTree<int>();

            tree.Insert(6);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(10);
            tree.Insert(8);
            tree.Insert(3);

            tree.PrintInOrder();

            Console.WriteLine($"Contains 3...{tree.Contains(3)}");
            Console.WriteLine($"Contains 10...{tree.Contains(10)}");
            Console.WriteLine($"Contains 11...{tree.Contains(11)}");
        }


        public class BinarySearchTree<T> where T : IComparable<T>
        {
            public Node<T> Root {get;set;}

            public void Insert(T val)
            {
                if (Root == null)
                {
                    Root = new Node<T>(val);
                }
                else
                {
                    InsertChildren(Root, val);
                }
            }

            private void InsertChildren(Node<T> evalNode, T val)
            {
                if (evalNode.data.CompareTo(val) > 0)
                {
                    if (evalNode.Left == null)
                    {
                        evalNode.Left = new Node<T>(val);
                    }
                    else
                    {
                        InsertChildren(evalNode.Left, val);
                    }
                }
                else
                {
                    if (evalNode.Right == null)
                    {
                        evalNode.Right = new Node<T>(val);
                    }
                    else
                    {
                        InsertChildren(evalNode.Right, val);
                    }
                }
            }

            public bool Contains(T val)
            {
                return ContainsChildren(Root, val);
            }

            private bool ContainsChildren(Node<T> n, T val)
            {
                if (n == null)
                {
                    return false;
                }
                else if (n.data.CompareTo(val) == 0)
                {
                    return true;
                }
                else if (n.data.CompareTo(val) > 0)
                {
                    return ContainsChildren(n.Left, val);
                }
                else
                {
                    return ContainsChildren(n.Right, val);
                }
            }

            public Node<T> Remove(T value)
            {
                return null;
            }

            public void PrintInOrder()
            {
                PrintChildren(Root);
            }

            private void PrintChildren(Node<T> n)
            {
                if (n == null)
                {
                    return;
                }
                PrintChildren(n.Left);
                Console.Write(n.data + "|");
                PrintChildren(n.Right);
            }
        }

        public class Node<T>
        {
            public T data;

            public Node(T data)
            {
                this.data = data;
            }

            public Node<T> Left {get;set;}
            public Node<T> Right {get;set;}
        }

    }
}