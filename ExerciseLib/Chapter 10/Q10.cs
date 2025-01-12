class Q10
{
    static char[,] maze = 
    {
        {' ', ' ', ' ', '*', ' ', ' ', ' '},
        {'*', '*', ' ', '*', ' ', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        {' ', '*', '*', '*', '*', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
    };
    static void ans()
    {
        Console.WriteLine("The maze is shown as below: ");
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write("{0, 3}", maze[i,j]);
            }
            Console.WriteLine();
        }

        FindPath(0, 0);
    }
    static void FindPath(int row, int col)
    {
        if (row < 0 || row >= maze.GetLength(0) || col < 0 || col >= maze.GetLength(1))
        {
            return;
        }
                if (maze[row, col] == 'e')
        {
            Console.WriteLine("Path found!!");
            PrintPath(maze);
        }
        if (maze[row, col] != ' ')
        {
            return;
        }
        maze[row, col] = 's';

        FindPath(row + 1, col);
        FindPath(row, col - 1);
        FindPath(row - 1, col);
        FindPath(row, col + 1);

        maze[row, col] = ' ';
    }
    static void PrintPath(char[,] maze)
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write("{0, 3}", maze[i,j]);
            }
            Console.WriteLine();
        }
    }
}