class Q14
{
    // Q14. Let’s have as given a graph G (V, E). Write a program 
    // that finds all connected components of the graph, i.e. finds 
    // all maximal connected sub-graphs. A maximal connected sub-graph 
    // of G is a connected graph such that no other connected 
    // sub-graphs of G, contains it.
    
    // implementation of finding undirected graph's connected components
    static void ans()
    {
        Graph graph = new Graph(new List<int>[]{
            new List<int>(){1}, // successors of vertice 0
            new List<int>(){0, 2, 4, 6}, // successors of vertice 1
            new List<int>(){1}, // successors of vertice 2
            new List<int>(){5, 9}, // successors of vertice 3
            new List<int>(){1, 7}, // successors of vertice 4
            new List<int>(){3, 8, 10}, // successors of vertice 5
            new List<int>(){1, 7}, // successors of vertice 6
            new List<int>(){4, 6}, // successors of vertice 7
            new List<int>(){5, 10},  // successors of vertice 8
            new List<int>(){3}, // successors of vertice 9
            new List<int>(){5, 8}, // successors of vertice 10
            new List<int>(){} // successors of vertice 11
        });
        Console.WriteLine("The connected graph components are");
        GetCompo(graph);
    }
    // method to print all the connected component
    static void GetCompo(Graph graph)
    {
        bool[] visited = new bool[graph.Size];

        for(int i = 0; i < graph.Size; i++)
        {
            if(!visited[i])
            {
                traverseDFS(graph, i, visited);
                Console.WriteLine();
            }
        }
    }
    // method to traverse the graph by DFS
    static void traverseDFS(Graph graph, int childnode, bool[] visited)
    {
        List<int> child = graph.GetSuccessors(childnode);
        if(!visited[childnode])
        {
            Console.Write(childnode + " ");
            visited[childnode] = true;
            for(int i = 0; i < child.Count; i++)
            {
                traverseDFS(graph, child[i], visited);
            }
        }
    }
}