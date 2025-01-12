class Q12d
{
    static void ans()
    {
        Console.Write("Please enter size n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        arr[0, 0] = 1;
        int xpos = n - 1, ypos = 0; //initialize the current and previous x
        int xpre = n - 1, ypre = 0; //initialize the current and previous y
        int dir = 1; //to store the direction for the next value

        //for this question, the sequence of the loop is n - 1 times for both row and column
        //then reduce the time of loop by 1, n - 2 -> n - 3 -> ...-> 1
        //direction of the value add will change for the next loop

        //loop for the first column of the matrix
        for (int i = 0; i < n - 1; i++)
        {
            arr[i + 1, 0] = arr[i, 0] + 1;
        }

        //loop for the folloing lines of the matrix
        //there are n - 1 times each row and column length
        for (int i = 1; i <= n - 1; i++)
        {
            for (int j = i; j <= n - 1; j++) //loop for row according to current length
            {
                ypre = ypos;
                ypos = ypos + dir;
                arr[xpos, ypos] = arr[xpre, ypre] + 1;
            }
            ypre = ypos; //change the current y to previous y for the next loop (column)
            for (int j = i; j <= n - 1; j++) //loop for column according to current length
            {
                xpre = xpos;
                xpos = xpos - dir;
                arr[xpos, ypos] = arr[xpre, ypre] + 1;
            }
            xpre = xpos; //change the current x to previous x for the next loop (row)
            dir *= -1; //change the direction of the next added value (e.g. for row, from left to right -> right to left
        }

        //print out the final matrix
        Console.WriteLine("The matrix is:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}