class Q18
{
    // Q18. A Hamiltonian cycle in a graph is a cycle containing 
    // every vertex in the graph exactly once. Write a program, which 
    // by given weighted oriented graph G (V, E), finds Hamiltonian 
    // loop with a minimum length, if such exists.
    
    // an array of int to store the minimun length path
    static int[] minPath;
    static void ans()
    {
        int[,]  graph = {
            {0, 2, 5, 0, 10, 0 ,0 ,0}, // successors and weights of vertex 0
            {2, 0, 0, 0, 0, 0 ,0 ,4}, // successors and weights of vertex 1
            {5, 0, 0, 0, 8, 1 ,0 ,2}, // successors and weights of vertex 2
            {0, 0, 0, 0, 0, 1 ,9 ,0}, // successors and weights of vertex 3
            {10, 0, 8, 0, 0, 7 ,0 ,0}, // successors and weights of vertex 4
            {0, 0, 1, 1, 7, 0 ,0 ,5}, // successors and weights of vertex 5
            {0, 0, 0, 9, 0, 0 ,0 ,7}, // successors and weights of vertex 6
            {0, 4, 2, 0, 0, 5 ,7 ,0} // successors and weights of vertex 7
        };

        HamiltonCycle(graph);
    }

    // Backtracking method to find the Hamiltonian cycle with minimun length
    static void HamiltonCycle(int[,] graph)
    {
        // visited[] to record the current visited vertex
        // path[] to record the current path, assign -1 for initialization
        bool[] visited = new bool[graph.GetLength(0)];
        int[] path = new int[graph.GetLength(0)];
        for(int i = 0; i < path.Length; i++)
        {
            path[i] = -1;
        }

        // begin at vertex 0
        path[0] = 0;
        visited[0] = true;

        // initialization of minPath and minLength
        minPath = new int[path.Length];
        int minLength = int.MaxValue;

        // get the minLength through the recurrsive process
        minLength = UtilHamCycle(graph, path, 1, 0, minLength, 0, visited);

        // if minLength is less than MaxValue, Hamiltonian Cycle exist
        if(minLength < int.MaxValue)
        {
            printHamilton();
            Console.WriteLine("The minimun length is " + minLength);
        }
        else
        {
            Console.WriteLine("There is no Hamiltonian cycle.");
        }

    }

    // <suammary> helper function to recursively call the adjacent vertices and walk through the whole graph </summary>
    // <param name = "graph"> the graph to be processed </param>
    // <param name = "path"> array to record the current path </param>
    // <param name = "count"> count the number of vertices walked </param>
    // <param name = "pos"> the current position in the graph </param>
    // <param name = "minLength"> array to record the minimun length of the hamiltonian cycle, if any </param>
    // <param name = "cost"> the current cost of the walked path </param>
    // <param name = "visisted"> array to mark the visited vertices </param>
    static int UtilHamCycle(int[,] graph, int[] path, int count, int pos, int minLength, int cost, bool[] visited)
    {
        // base case, if the count reached the total number of vertices in the graph
        // and if the path ending vertex is adjacent to the starting vertex
        if(count == graph.GetLength(0) && graph[pos, 0] > 0)
        {
            // check if the length of the current cycle is shorter than recored minimun
            // if yes, update the minimun length and minimun path
            if(minLength > Math.Min(minLength, cost + graph[pos, path[0]]))
            {
                minLength = Math.Min(minLength, cost + graph[pos, path[0]]);
                Array.Copy(path, minPath, graph.GetLength(0));
            }
            return minLength;
        }
        
        // check all the unvisited vertices
        for (int v = 0; v < graph.GetLength(0); v++)
        {
            // if the checking vertex is unvisited and adjacent to the current vertex
            if(!visited[v] && graph[pos, v] > 0)
            {
                // record the path and mark as visited
                path[count] = v;
                visited[v] = true;
                // recursively call the helper function for the next checking vertex
                minLength = UtilHamCycle(graph, path, count + 1, v, minLength, cost + graph[pos, v], visited);
                // backtracking by unrecord the checking vertex
                path[count] = -1;
                visited[v] = false;
            }
        }
        return minLength;
    }

    // helper function to print the result
    static void printHamilton()
    {
        Console.WriteLine("The Hamilton cycle exist:");
        for(int i = 0; i < minPath.Length; i++)
        {
            Console.Write(minPath[i] + " ");
        }
        //print the origin again to indicate a cycle
        Console.WriteLine(minPath[0]);
    }
}