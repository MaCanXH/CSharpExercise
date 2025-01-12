class Q15
{
    // Q15. Suppose we are given a weighted oriented graph G (V, E), 
    // in which the weights on the side are nonnegative numbers. Write 
    // a program that by a given vertex x from the graph finds the 
    // shortest paths from it to all other vertical.
    static void ans()
    {
        // weighted graph by adjaceny martix
        int[,] graph = {
            {0, 4, 2, 0, 0, 0, 0, 0, 0, 0}, // edge with weight of vertice 0
            {4, 0, 1, 0, 0, 3, 0, 0, 7, 0}, // edge with weight of vertice 1
            {2, 1, 0, 3, 0, 0, 0, 8, 0, 0}, // edge with weight of vertice 2
            {0, 0, 3, 0, 7, 0, 0, 0, 0, 0}, // edge with weight of vertice 3
            {0, 0, 0, 7, 0, 0, 4, 0, 0, 0}, // edge with weight of vertice 4
            {0, 3, 0, 0, 0, 0, 0, 0, 0, 10}, // edge with weight of vertice 5
            {0, 0, 0, 0, 4, 0, 0, 0, 0, 0}, // edge with weight of vertice 6
            {0, 0, 8, 0, 0, 0, 0, 0, 5, 0}, // edge with weight of vertice 7
            {0, 0, 0, 0, 0, 0, 0, 5, 0, 5}, // edge with weight of vertice 8
            {0, 0, 0, 0, 0, 10, 0, 0, 5, 0}, // edge with weight of vertice 9
        };

        Console.Write("Enter the source vertice: ");
        int src = int.Parse(Console.ReadLine());

        Dijsktra(graph, src);
    }
    // method of Dijkstra algorithm 
    static void Dijsktra(int[,] graph, int src)
    {
        // array of dist to record the shortest distance from source
        int[] dist = new int[graph.GetLength(0)];
        // array of shortest path tree to record if the vertice visited
        // means the shortest distance from source is finalized
        bool[] sptSet = new bool[graph.GetLength(0)];

        // initialization of dist and sptSet
        for(int i = 0; i < graph.GetLength(0); i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        // distance from the source is always 0
        dist[src] = 0;

        // find the shortest path from source to vertice v
        // number of iteration is number of total vertices - 1
        for(int count = 0; count < graph.GetLength(0) - 1; count++)
        {
            // pick the minimum distance vertex from the set of vertices
            // not yet processed. u is always equal to src in the first iteration
            int u = minDist(dist, sptSet);
            sptSet[u] = true;

            // update dist value of the adjacent vertices of the vertex u
            for(int v = 0; v < dist.Length; v++)
            {
                if(!sptSet[v] && graph[u, v] != 0 && 
                dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                }
            }
        }

        // print the result
        PrintDist(dist);
    }

    // helper method to find the 
    // vertex with minimum distance
    // value, from the set of vertices
    // not yet included in shortest
    // path tree
    static int minDist(int[] dist, bool[] sptSet)
    {
        int min = int.MaxValue;
        int min_idx = -1;

        for(int v = 0; v < dist.Length; v++)
        {
            if(!sptSet[v] && dist[v] <= min)
            {
                min = dist[v];
                min_idx = v;
            }
        }
        return min_idx;
    }

    // helper method to print the result
    static void PrintDist(int[] dist)
    {
        Console.WriteLine("Vertice \t\t Shortest Distance from source");
        for(int i = 0; i < dist.Length; i++)
        {
            Console.WriteLine("{0} \t\t\t {1}", i, dist[i]);
        }
    }
}