class Q18
{
    static void Main()
    {
        // maze of size N x M
        char[,] maze = 
        {
            {'0', '0', '0', 'x', '0', 'x'},
            {'0', 'x', '0', 'x', '0', 'x'},
            {'0', '*', 'x', '0', 'x', '0'},
            {'0', 'x', '0', '0', '0', '0'},
            {'0', '0', '0', 'x', 'x', '0'},
            {'0', '0', '0', 'x', '0', 'x'}
        };
        MazeSolver(maze);
    }
    // using Queue and BFS to store the distance
    private static int[,] MazeBFS(int[,] maze, int row, int col, int n, int m)
    {
        Queue<int[]> visited = new Queue<int[]>(); // Queue is created to store the current position of in the maze
        visited.Enqueue(new int[]{row, col}); // begins from the starting point

        while(visited.Count > 0)
        {
            int[] current = visited.Dequeue();

            // check if the adjacent position of the current is out of bound or not
            // if not, enqueue the position and add 1 to the number matrix
            if(current[0] - 1 >= 0 && maze[current[0] - 1, current[1]] == 0)
            {
                visited.Enqueue(new int[]{current[0] - 1, current[1]});
                maze[current[0] - 1, current[1]] = maze[current[0], current[1]] + 1;
            }
            if(current[0] + 1 < n && maze[current[0] + 1, current[1]] == 0)
            {
                visited.Enqueue(new int[]{current[0] + 1, current[1]});
                maze[current[0] + 1, current[1]] = maze[current[0], current[1]] + 1;
            }
            if(current[1] - 1 >= 0 && maze[current[0], current[1] - 1] == 0)
            {
                visited.Enqueue(new int[]{current[0], current[1] - 1});
                maze[current[0], current[1] - 1] = maze[current[0], current[1]] + 1;
            }
            if(current[1] + 1 < m && maze[current[0], current[1] + 1] == 0)
            {
                visited.Enqueue(new int[]{current[0], current[1] + 1});
                maze[current[0], current[1] + 1] = maze[current[0], current[1]] + 1;
            }
        }
        maze[row, col] = -2; // to record the starting position in the number matrix for print
        return maze;
    }
    static void PrintMaze(int[,] ma, int n, int m)
    {
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if(ma[i, j] == -1)
                {
                    Console.Write("x   ");
                }
                else if(ma[i, j] == 0)
                {
                    Console.Write("u   ");
                }
                else if(ma[i, j] == -2)
                {
                    Console.Write("*   ");
                }
                else
                {
                    Console.Write(ma[i,j] + "   ");
                }
            }
            Console.WriteLine();
        }
    }
    static void MazeSolver(char[,] maze)
    {
        int row = 0;
        int col = 0;
        // search for the starting position
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                if(maze[i, j] == '*')
                {
                    row = i;
                    col = j;
                }
            }
        }

        // get the size of the maze
        int n = maze.GetLength(0);
        int m= maze.GetLength(1);
        
        // create a number version of the maze
        // for the ease of BFS
        int[,] numMaze = new int[n, m]; 
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                if(maze[i,j] == '0')
                {
                    numMaze[i,j] = 0;
                }
                else if(maze[i,j] == 'x')
                {
                    numMaze[i,j] = -1;
                }
                else
                {
                    numMaze[i,j] = 0;
                }
            }
        } 

        int[,] resMaze = MazeBFS(numMaze, row, col, n, m);
        PrintMaze(resMaze, n, m);
    }
}