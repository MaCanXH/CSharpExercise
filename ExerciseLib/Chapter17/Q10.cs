class Q10
{
    // Q10. Write breadth first search (BFS), 
    // based on a queue, to traverse a directed graph.
    static void ans()
    {
        Graph graph = new Graph(new List<int>[]{
            new List<int>(){1}, // successors of vertice 0
            new List<int>(){4, 5, 6}, // successors of vertice 1
            new List<int>(){1}, // successors of vertice 2
            new List<int>(){5}, // successors of vertice 3
            new List<int>(){7}, // successors of vertice 4
            new List<int>(){}, // successors of vertice 5
            new List<int>(){3}, // successors of vertice 6
            new List<int>(){6} // successors of vertice 7
        }); 
        Console.WriteLine("Input the starting vertice: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Traverse the graph by BFS: ");
        traverseBFS(graph, n);
    }

    // method to traverse the graph by BFS

    static void traverseBFS(Graph graph, int n)
    {
        List<int> child = graph.GetSuccessors(n);
        bool[] visited =new bool[graph.Size];
        visited[n] = true;
        Console.Write(n + " ");

        Queue<int> BFSQueue = new Queue<int>();
        BFSQueue.Enqueue(n);

        while(BFSQueue.Count != 0)
        {
            child = graph.GetSuccessors(BFSQueue.Dequeue());
            foreach(int childnode in child)
            {
                if(visited[childnode] == false)
                {
                    visited[childnode] = true;
                    BFSQueue.Enqueue(childnode);
                    Console.Write(childnode + " ");
                }
            }
        }
    }
}