class Q17
{
    // Q17. An Eulerian cycle in a graph is called a loop that 
    // starts from a vertex, passes exactly once through all edges 
    // in the graph returns to the starting vertex. Vertices can be 
    // visited repeatedly. Write a program that by a given graph, 
    // finds whether the graph has an Euler loop.
    static void ans()
    {
        Graph graph = new Graph(new List<int>[]{
            new List<int>{1, 2}, // successors of vertex 0
            new List<int>{0, 7}, // successors of vertex 1
            new List<int>{0, 4, 5, 7}, // successors of vertex 2
            new List<int>{5, 6}, // successors of vertex 3
            new List<int>{2, 5}, // successors of vertex 4
            new List<int>{2, 3, 4, 7}, // successors of vertex 5
            new List<int>{3, 7}, // successors of vertex 6
            new List<int>{1, 2, 5, 6}, // successors of vertex 7
        });

        int check = EulerianCheck(graph);

        if(check == 0)
        {
            Console.WriteLine("The graph is not Eulerian.");
        }
        else if(check == 1)
        {
            Console.WriteLine("The graph has an Eulerian path.");
        }
        else if(check == 2)
        {
            Console.WriteLine("The graph has an Eulerian cycle.");
        }
    }
    // Eulerian path/cycle only works in a undirected graph.
    // Eulerian path has the following conidtion:
    // 1. All vertices with non-zero degree are connected. Vertices with zero degree could be ignored.
    // 2. Only zero or two vertices have odd degree. All other vertices have even degree.
    // Eulerian cycle has the following conidtion:
    // 1. All vertices with non-zero degree are connected. Vertices with zero degree could be ignored.
    // 2. All vertices have even degree.

    // helper function to check if the all non-zero degree vertices
    // are connected in the graph
    static bool IsConnected(Graph graph)
    {
        bool[] visited = new bool[graph.Size];

        // find a non-zero degree vertex to start the DFS
        for(int i = 0; i < graph.Size; i++)
        {
            if(graph.GetSuccessors(i).Count != 0)
            {
                traverseDFS(graph, i, visited);
                break;
            }
        }

        // retrun false if there is an unvisited vertex with non-zero degree
        for(int i = 0; i < graph.Size; i++)
        {
            if(!visited[i] && graph.GetSuccessors(i).Count > 0)
            {
                return false;
            }
        }
        return true;
    }
    // helper function to traverse the graph by DFS 
    // and mark the visited vertices in array
    static void traverseDFS(Graph graph, int v, bool[] visited)
    {
        if(visited[v])
        {
            return;
        }

        visited[v] = true;
        for(int i = 0; i < graph.GetSuccessors(v).Count; i++)
        {
            traverseDFS(graph, graph.GetSuccessors(v)[i], visited);
        }
    }
    // function ot check if the graph is Eulerian or not
    static int EulerianCheck(Graph graph)
    {
        // check if all non-zero degree vertices are connected
        if(!IsConnected(graph))
        {
            return 0;
        }

        int odd = 0;

        // Count the vertices with odd degree
        for(int i = 0; i < graph.Size; i++)
        {
            if(graph.GetSuccessors(i).Count % 2 != 0)
            {
                odd++;
            }
        }

        // if count is more than 2, then the graph is not Eulerain
        if(odd > 2)
        {
            return 0;
        }
        // if count is 2, then semi-eulerian
        // if count is 0, then eulerian
        // undirected graph will never have 1 odd count
        return (odd == 2)? 1 : 2;
    }
}