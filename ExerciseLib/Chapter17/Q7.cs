using System.Reflection.Metadata.Ecma335;

class Q7
{
    // Q7. Let’s have as given a graph G(V, E) and two of its 
    // vertices x and y. Write a program that finds the shortest 
    // path between two vertices measured in number of vertices 
    // staying on the path.
    static void ans()
    {
        Graph graph = new Graph(new List<int>[]{
            new List<int>(){1}, // successors of vertice 0
            new List<int>(){4, 6}, // successors of vertice 1
            new List<int>(){1}, // successors of vertice 2
            new List<int>(){5}, // successors of vertice 3
            new List<int>(){7}, // successors of vertice 4
            new List<int>(){}, // successors of vertice 5
            new List<int>(){3}, // successors of vertice 6
            new List<int>(){6} // successors of vertice 7
        });
        List<int> path = ShortestPath(graph, 2, 5);
        Console.WriteLine("The shortest path is");

        // print the reversed shortest path list
        for(int i = path.Count - 1; i >= 0; i--)
        {
            if(i > 0)
            {
                Console.Write(path[i] + " -> ");
            }
            else
            {
                Console.Write(path[i]);
            }
        }
    }

    // method to return a list of the shortest path by Queue BFS in reverse order
    // in this case, the shortest path between 2 and 5 is 
    // 2 -> 1 -> 6 -> 3 -> 5

    static List<int> ShortestPath(Graph graph, int u, int v)
    {
        List<int> childNodes = null;
        // an array to store the predecessor of the vertice
        // -1 is assigned as default value of the array element for unvisited vertice
        int[] parent = new int[graph.Size];
        for(int i = 0; i < graph.Size; i++)
        {
            parent[i] = -1;
        }

        // queue to implement BFS
        Queue<int> BFS = new Queue<int>();
        BFS.Enqueue(u);

        while(BFS.Count > 0)
        {
            int par = BFS.Peek();
            childNodes = graph.GetSuccessors(BFS.Dequeue());
            foreach(int child in childNodes)
            {
                BFS.Enqueue(child);
                // check if vertice visited or not
                if(parent[child] == -1)
                {
                    parent[child] = par;
                }
            }
        }

        // create a list of shortest path
        int p = v;
        List<int> path = new List<int>();
        path.Add(v);
        while(p != u)
        {
            path.Add(parent[p]);
            p = parent[p];
        }
        return path;
    }

    // graph implementation by list of successors
}
