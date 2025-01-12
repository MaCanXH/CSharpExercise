class Q9
{
    // Q9. Implement a recursive traversal in depth in an 
    // undirected graph and a program to test it.
    static void ans()
    {
        // undirected graph with all neighbour as the child nodes
        Graph graph = new Graph(new List<int>[]{
            new List<int>(){1}, // successors of vertice 0
            new List<int>(){0, 2, 4, 5, 6}, // successors of vertice 1
            new List<int>(){1}, // successors of vertice 2
            new List<int>(){5, 6}, // successors of vertice 3
            new List<int>(){1, 7}, // successors of vertice 4
            new List<int>(){1, 3}, // successors of vertice 5
            new List<int>(){1, 3, 7}, // successors of vertice 6
            new List<int>(){4, 6} // successors of vertice 7
        }); 
        Console.WriteLine("Input the starting vertice: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Traverse the graph by DFS: ");
        traverseDFS(graph, n);
    }

    // method to traverse the graph
    static void traverseDFS(Graph graph, int n)
    {
        bool[] visited = new bool[graph.Size];
        visited[n] = true;
        Console.Write(n + " ");
        DFS(graph, graph.GetSuccessors(n), visited);
    }

    // method to traverse the undirected graph by DFS
    static void DFS(Graph graph, List<int> child, bool[] visited)
    {
        for(int i = 0; i < child.Count; i++)
        {
            if(visited[child[i]] == false)
            {
                visited[child[i]] = true;
                Console.Write(child[i] + " ");
                DFS(graph, graph.GetSuccessors(child[i]), visited);
            }
        }
    }
}