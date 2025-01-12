class Q12c
{
    static void ans()
    {
        Console.Write("Please enter size n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];

        //xpos and ypos to store the value of current arr value
        //var count is used indicate the length of next loop (diagonal line)
        int xpos, ypos, xpre, ypre, count = 1;

        //set the bottom left and top right value of the matrix
        arr[n - 1, 0] = 1;
        arr[0, n - 1] = n * n;

        //loop for the lower half (indicate by *) of the matrix value
        //e.g.
        //*xxx
        //**xx
        //***x
        //****
        //from arr[0,0] to the mid of arr
        for (int i = n - 2; i >= 0; i--)
        {
            arr[i, 0] = arr[i + 1, 0] + count;
            xpos = i;
            ypos = 0;
            for (int j = 0; j < count; j++)
            {
                xpre = xpos;
                ypre = ypos;
                xpos += 1;
                ypos += 1;
                arr[xpos, ypos] = arr[xpre, ypre] + 1; //add 1 to the diagonal value
            }
            count++; //count + 1 indicate the length of next diagonal increased by 1
        }
        count = 1; //initialize the count for the next loop

        //loop for the upper half (inidcate by *) of the matrix value
        //e.g.
        //x***
        //xx**
        //xxx*
        //xxxx
        //from arr[0, n - 1] to the mid of arr
        for (int i = 1; i <= n - 2; i++)
        {
            arr[i, n - 1] = arr[i - 1, n - 1] - count;
            xpos = i;
            ypos = n - 1;
            for (int j = 0; j < count; j++)
            {
                xpre = xpos;
                ypre = ypos;
                xpos -= 1;
                ypos -= 1;
                arr[xpos, ypos] = arr[xpre, ypre] - 1; //minus 1 to the diagonal value
            }
            count++; //count + 1 indicate the length of next diagonal increased by 1
        }

        //print the result
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