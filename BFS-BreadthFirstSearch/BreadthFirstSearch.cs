using System;
using System.Collections.Generic;

namespace BFS_BreadthFirstSearch
{
    public class BreadthFirstSearch<T>
    {
        public void Traverse(Vertex<T> root)
        {
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
            root.IsVisited = true;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                Console.Write($"{vertex.Data} ");
                foreach (var v in vertex.Neighbors)
                {
                    if (!v.IsVisited)
                    {
                        v.IsVisited = true;
                        queue.Enqueue(v);
                    }
                }
            }
            Console.WriteLine();
        }
        public void Search(Vertex<T> root, T data)
        {
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
            root.IsVisited = true;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                Console.Write($"{vertex.Data} ");
                if (vertex.Data.Equals(data))
                {
                    Console.WriteLine($"\nFound {vertex.Data}");
                    break;
                }
                foreach (var v in vertex.Neighbors)
                {
                    if (!v.IsVisited)
                    {
                        v.IsVisited = true;
                        queue.Enqueue(v);
                    }
                }             
            }
            Console.WriteLine();
        }
    }
}
