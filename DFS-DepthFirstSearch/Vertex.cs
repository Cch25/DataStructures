using System.Collections.Generic;

namespace DFS_DepthFirstSearch
{
    public class Vertex<T>
    {
        public T Data { get; set; }
        public bool Visited { get; set; }
        public bool BeingVisited { get; set; }
        public List<Vertex<T>> NeigborsList { get; set; }
        public Vertex(T data)
        {
            Data = data;
            NeigborsList = new List<Vertex<T>>();
        }

        public void AddNeigbors(Vertex<T> vertex)
        {
            NeigborsList.Add(vertex);
        }
        public override string ToString()
        {
            return $"{Data.ToString()} ";
        }
    }
}
