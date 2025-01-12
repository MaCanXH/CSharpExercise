class hamiltonianGraph
{
    static void ans()
    {
        int[,]  graph = {
            {0, 1, 1, 0, 1, 0 ,0 ,0}, // successors and weights of vertex 0
            {1, 0, 0, 0, 0, 0 ,0 ,1}, // successors and weights of vertex 1
            {1, 0, 0, 0, 1, 1 ,0 ,1}, // successors and weights of vertex 2
            {0, 0, 0, 0, 0, 1 ,1 ,0}, // successors and weights of vertex 3
            {1, 0, 1, 0, 0, 1 ,0 ,0}, // successors and weights of vertex 4
            {0, 0, 1, 1, 1, 0 ,0 ,1}, // successors and weights of vertex 5
            {0, 0, 0, 1, 0, 0 ,0 ,1}, // successors and weights of vertex 6
            {0, 1, 1, 0, 0, 1 ,1 ,0} // successors and weights of vertex 7
        };

        HamiltonCycle(graph);
    }

    // Backtracking method to find the Hamiltonian cycle with minimun length
    static void HamiltonCycle(int[,] graph)
    {
        int[] path = new int[graph.GetLength(0)];
        for(int i = 0; i < path.Length; i++)
        {
            path[i] = -1;
        }
        path[0] = 0;

        bool check = UtilHamCycle(graph, path, 1);
        if(check)
        {
            printHamilton(path);
        }
        else
        {
            Console.WriteLine("There is no Hamiltonian cycle.");
        }

    }
    // helper function to reccursively call the adjacent vertices
    static bool UtilHamCycle(int[,] graph, int[] path, int pos)
    {
        if(pos == graph.GetLength(0))
        {
            if(graph[path[pos - 1], path[0]] == 1)
            {
                return true;
            }
            else return false;
        }
        
        for (int v = 1; v < graph.GetLength(0); v++)
        {
            if(IsAdjacent(graph, path, pos, v))
            {
                path[pos] = v;
                if(UtilHamCycle(graph, path, pos + 1))
                {
                    return true;
                }
                path[pos] = -1;
            }
        }
        return false;
    }
    // helper method to check if the vertex is adjacent to prevously vertex
    static bool IsAdjacent(int[,] graph, int[] path, int pos, int v)
    {
        if(graph[path[pos - 1], v] == 0)
        {
            return false;
        }
        for (int i = 0; i < pos; i++)
        {
            if(path[i] == v)
            {
                return false;
            }
        }
        return true;
    }
    // helper function to print the result
    static void printHamilton(int[] path)
    {
        Console.WriteLine("The Hamilton cycle exist:");
        for(int i = 0; i < path.Length; i++)
        {
            Console.Write(path[i] + " ");
        }
        Console.WriteLine(path[0]);
    }
}