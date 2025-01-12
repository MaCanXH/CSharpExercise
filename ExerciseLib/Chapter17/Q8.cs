class Q8
{
    // Q8. Let’s have as given a graph G(V, E). Write a program 
    // that checks whether the graph is cyclic.
    static void ans()
    {        
        Graph graph = new Graph(new List<int>[]{
            new List<int>(){1}, // successors of vertice 0
            new List<int>(){4, 6}, // successors of vertice 1
            new List<int>(){1}, // successors of vertice 2
            new List<int>(){5}, // successors of vertice 3
            new List<int>(){7}, // successors of vertice 4
            new List<int>(){1}, // successors of vertice 5
            new List<int>(){3}, // successors of vertice 6
            new List<int>(){6} // successors of vertice 7
        }); 

        Console.WriteLine("Is this graph contains a cycle?");
        Console.WriteLine(CyclicGraph(graph, graph.Size));
    }
    // Kahn's algorithm by BFS to find a cycle in a graph
    static bool CyclicGraph(Graph graph, int V)
    {
        Queue<int> NoInDegree = new Queue<int>();

        // an int array to store the in-degree of each vertice
        int[] InDegree = new int[V];
        int visited = 0;

        for(int i = 0; i < V; i++)
        {
            foreach(var child in graph.GetSuccessors(i))
            {
                InDegree[child]++;
            }
        }

        // if the in-degree of a vertice is 0, add it into the queue
        for(int i = 0; i < V; i++)
        {
            if(InDegree[i] == 0)
            {
                NoInDegree.Enqueue(i);
            }
        }

        // BFS to traverse the graph
        while(NoInDegree.Count > 0)
        {
            int u = NoInDegree.Dequeue();
            visited++;

            foreach(int child in graph.GetSuccessors(u))
            {
                InDegree[child]--;

                if(InDegree[child] == 0)
                {
                    NoInDegree.Enqueue(child);
                }
            }
        }

        // if visited is not equal to the number of vertice, it contains at least one cycle
        // otherwise no cycle
        return visited != V;
    }
}
