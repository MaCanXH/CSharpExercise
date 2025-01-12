class Q16
{
    // Q16. We have N tasks to be performed successively. We are given 
    // a list of pairs of tasks for which the second is dependent on 
    // the outcome of the first and should be executed after it. Write 
    // a program that arranges tasks in such a way that each task is 
    // be performed after all the tasks which it depends on have been 
    // completed. If no such order exists print an appropriate message.

    // Example: {1, 2}, {2, 5}, {2, 4}, {3, 1} -> 3, 1, 2, 5, 4
    static void ans()
    {
        Graph graph = new Graph(new List<int>[]{
            new List<int>{1}, //successors of vertex 0
            new List<int>{3, 4}, //successors of vertex 1
            new List<int>{0}, //successors of vertex 2
            new List<int>{}, //successors of vertex 3
            new List<int>{} //successors of vertex 4
        });

        TopologicalSort(graph);
    }

    // Topological sorting based on DFS
    static void TopologicalSort(Graph graph)
    {
        // record the visited vertices by an array
        bool[] visited = new bool[graph.Size];
        // stack to store the result
        Stack<int> order = new Stack<int>();

        // recursively call the helper function to store the result in stack
        // topologiacal sorting process throughout all vertices
        for(int i = 0; i < graph.Size; i++)
        {
            if(!visited[i])
            {
                UtilTopoSort(graph, i, graph.GetSuccessors(i), visited, order);
            }
        }

        // print the result from the stack
        Console.WriteLine("The tasks order is ");
        while(order.Count > 0)
        {
            Console.Write(order.Pop() + " ");
        }
    }

    // Utility function of Topological sorting function
    static void UtilTopoSort(Graph graph, int v, List<int> child, bool[] visited, Stack<int> order)
    {
        // mark the current vertex as visited
        visited[v] = true;

        foreach(int childnode in child)
        {
            // recurssive call the the helper function for the child vertices
            if(!visited[childnode])
            {
                UtilTopoSort(graph, childnode, graph.GetSuccessors(childnode), visited, order);
            }
        }

        // store the current vertex into the stack
        order.Push(v);
    }
}