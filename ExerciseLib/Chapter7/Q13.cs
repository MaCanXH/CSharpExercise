class Q13
{
    static void ans()
    {                                                 
        int[,] arr =
        {
    { 0, 2, 4, 0, 9, 5 },
    { 7, 1, 3, 3, 2, 1 },
    { 1, 3, 9, 8, 5, 6 },
    { 4, 6, 7, 9, 1, 0 },
    { 7, 1, 3, 3, 2, 1 },
};
        int bestSum = 0, bestRow = 0, bestcol = 0, tempSum = 0;
        for (int row = 0; row < arr.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < arr.GetLength(1) - 2; col++)
            {
                tempSum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2]
                    + arr[row + 1, col] + arr[row + 1, col + 1] + arr[row + 1, col + 2]
                    + arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                if (tempSum > bestSum)
                {
                    bestSum = tempSum;
                    bestRow = row;
                    bestcol = col;
                }
            }
        }

        Console.WriteLine("the maximal 3x3 matrix is");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0,4}", arr[bestRow + i, bestcol + j]);
            }
            Console.WriteLine();
        }
        Console.Write("the maximal sum is " + bestSum);
    }
}