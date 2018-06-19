using System.Collections.Generic;

namespace DFS_DepthFirstSearch
{
    public class TestDFS
    {
        static void Main(string[] args)
        {
            var dfs = new DepthFirstSearch<int>();
            var v1 = new Vertex<int>(1);
            var v2 = new Vertex<int>(2);
            var v3 = new Vertex<int>(3);
            var v4 = new Vertex<int>(4);
            var v5 = new Vertex<int>(5);
            var v6 = new Vertex<int>(6);

            var list = new List<Vertex<int>>
            {
                v1,v2,v3,v4,v5
            };

            v1.AddNeigbors(v2);
            v1.AddNeigbors(v3);
            v2.AddNeigbors(v3);
            v4.AddNeigbors(v1);
            v4.AddNeigbors(v5);
            v5.AddNeigbors(v6);
            v6.AddNeigbors(v4);

            //dfs.TraverseDFS(list);
            dfs.DetectCycles(list);
        }
    }
}
