using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Amazon
{
    class Graph
    {
      /*  int V;
        List<int> adj[];

        public Graph(int V)
        {
            this.V = V;
            adj = new List<Integer>[V];
        }

        public void addEdge(int u, int v)
        {
            if (adj[u] == null)
            {
                adj[u] = new LinkedList<Integer>();
            }
            adj[u].add(v);
        }
    }

    public void topologicalSort(Graph g)
    {
        Stack<Integer> s = new Stack<Integer>();
        boolean[] visited = new boolean[g.V];
        for (int i = 0; i < V; ++i)
        {
            visited[i] = false;
        }
        for (int i = 0; i < g.V; ++i)
        {
            if (!visited[i])
            {
                sort(g, 0, s, visited);
            }
        }
    }

    private void sort(Graph g, int u, Stack<Integer> s, boolean[] visited)
    {
        visited[u] = true;
        foreach (int v: g.adj[u]) {
            if (!visited[v])
            {
                sort(g, v, s);
            }
        }
        s.push(u);
    }
    */
}
