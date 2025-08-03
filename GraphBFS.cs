using System;
using System.Collections.Generic;

namespace BFS
{
    public class GraphBFS
    {
        private Dictionary<int, List<int>> adjList = new();

        public void AddEdge(int u, int v)
        {
            if (!adjList.ContainsKey(u)) adjList[u] = new List<int>();
            if (!adjList.ContainsKey(v)) adjList[v] = new List<int>(); // if undirected
            adjList[u].Add(v);
            adjList[v].Add(u); // for undirected graph
        }

        public void BFS(int start)
        {
            var visited = new HashSet<int>();
            var queue = new Queue<int>();
            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");

                foreach (var neighbor in adjList[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }
        }
    }
}