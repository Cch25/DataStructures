using BinarySeachTrees;
using LinkedLists;
using Queues;
using Stacks;
using System;


namespace T107.DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main()
        {
            CheckLinkedLists();
            CheckStack();
            CheckQueue();
            CheckBinarySearchTree();

        }

        private static void CheckLinkedLists()
        {
            //linkedList
            var linkedList = new LinkedList<int>();
            linkedList.InsertBegin(5);
            linkedList.InsertBegin(15);
            linkedList.InsertAfter(50);
            linkedList.InsertAfter(35);
            linkedList.InsertBegin(25);

            linkedList.Remove(35);

            linkedList.TraverseList();
            Console.Write($" in the list there are currently {linkedList.Size()} items");
        }
        private static void CheckStack()
        {
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(15);
            stack.Push(25);
            stack.Push(35);
            Console.WriteLine("-------------");
            Console.WriteLine("Items in our stack: "+stack.Size());
            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-------------");
            Console.WriteLine("Peek items to pop: "+stack.Peek() +" removing: "+ stack.Pop());
            Console.WriteLine("Peek items to pop: "+stack.Peek() +" removing: "+ stack.Pop());
            Console.WriteLine("Peek items to pop: "+stack.Peek() +" removing: "+ stack.Pop());

            Console.WriteLine("-------------");
            Console.WriteLine("Items left: "+stack.Size());
            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Is stack empty: "+stack.IsEmpty());


        }
        private static void CheckQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("Anne");
            queue.Enqueue("July");
            queue.Enqueue("May");
            queue.Enqueue("April");
            Console.WriteLine($"size is {queue.Size()}");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());


        }
        private static void CheckBinarySearchTree()
        {
            var bst = new BinarySearchTree<int>();
            bst.Insert(10);
            bst.Insert(7);
            bst.Insert(15);
            bst.Insert(8);
            bst.Insert(6);
            bst.Insert(14);
            bst.Insert(13);
            bst.Insert(16);
            bst.Insert(17);

            bst.Traversal(TraverseType.InOrder);
            Console.WriteLine();
            Console.WriteLine($"Max value {bst.GetMaxValue()}");
            Console.WriteLine($"Min value {bst.GetMinValue()}");

            bst.Delete(8);

            bst.Traversal(TraverseType.InOrder);
        }
    }
}
