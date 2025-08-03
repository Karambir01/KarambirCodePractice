using System;
using System.Collections.Generic;

public class DFS
{
    private Dictionary<int, List<int>> adjList = new();

    public void AddEdge(int u, int v)
    {
        if (!adjList.ContainsKey(u)) adjList[u] = new List<int>();
        if (!adjList.ContainsKey(v)) adjList[v] = new List<int>(); // if undirected
        adjList[u].Add(v);
        adjList[v].Add(u); // for undirected graph
    }

    public void DFSIterative(int start)
    {
        var visited = new HashSet<int>();
        var stack = new Stack<int>();
        stack.Push(start);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (!visited.Contains(node))
            {
                Console.Write(node + " ");
                visited.Add(node);

                foreach (var neighbor in adjList[node])
                {
                    if (!visited.Contains(neighbor))
                        stack.Push(neighbor);
                }
            }
        }
    }

}
