using System.Collections.Generic;

namespace BFS_BreadthFirstSearch
{
    public class Vertex<T>
    {
        public T Data { get; set; }
        public bool IsVisited { get; set; }
        public List<Vertex<T>> Neighbors { get; set; }
        public Vertex(T data)
        {
            Data = data;
            Neighbors = new List<Vertex<T>>();
        }
        public void AddNeighbours(Vertex<T> v)
        {
            Neighbors.Add(v);
        }
        public override string ToString()
        {
            return $"{Data.ToString()} ";
        }
    }
}
