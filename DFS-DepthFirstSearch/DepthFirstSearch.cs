using System;
using System.Collections.Generic;

namespace DFS_DepthFirstSearch
{
    public class DepthFirstSearch<T>
    {
        public void TraverseDFS(List<Vertex<T>> vertex)
        {
            foreach (var v in vertex)
                if (!v.Visited)
                    TraverseDFSClusters(v);
        }

        private void TraverseDFSClusters(Vertex<T> v)
        {
            var stack = new Stack<Vertex<T>>();
            stack.Push(v);
            v.Visited = true;
            while (stack.Count > 0)
            {
                var vertex = stack.Pop();
                Console.Write($"{vertex.Data} ");
                foreach(var vtx in vertex.NeigborsList)
                {
                    if (!vtx.Visited)
                    {
                        vtx.Visited = true;
                        stack.Push(vtx);
                    }
                }
            }
            Console.WriteLine();
        }

        public void DetectCycles(List<Vertex<T>> vertexList)
        {
            foreach (var v in vertexList)
                if (!v.Visited)
                    DetectCyclesDFS(v);
        }

        private void DetectCyclesDFS(Vertex<T> vertex)
        {
            Console.WriteLine($"Currently on vertex {vertex}");
            vertex.BeingVisited = true;
            foreach(var v in vertex.NeigborsList)
            {
                Console.WriteLine($"Visiting neigbors of {v}");
                if (v.BeingVisited)
                {
                    Console.WriteLine($"Cycle detected");
                    return;
                }
                if (!v.Visited)
                {
                    Console.WriteLine($"Visiting vertex {vertex}");
                    v.Visited = true;
                    DetectCyclesDFS(v);
                }
            }
            Console.WriteLine($"Set vertex {vertex} as being visited false and visited true");
            vertex.BeingVisited = false;
            vertex.Visited = true;
        }
    }
}
