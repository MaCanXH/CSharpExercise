class Q14
{
    static void ans()
    {
        string[,] arr = {
    {"ha", "ho", "ho", "hi"},
    {"fo", "ho", "hi", "xx"},
    {"xxx", "xxx", "ho", "xxx"},
    {"hi", "ho", "ha", "ho"},
    {"hi", "ho", "ha", "ha"}};
        int n = arr.GetLength(0);
        int m = arr.GetLength(1);
        int Len = 1, tempLen = 1;
        int xidx = 0, yidx = 0;

        //loop to check the sequence in each row
        //i is the row, j is the column
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {

                if (arr[i, j] != arr[i, j + 1])
                {
                    tempLen = 1;
                    break;
                }
                else { tempLen++; }
                if (tempLen > Len)
                {
                    Len = tempLen;
                    xidx = i;
                    yidx = j;
                }
            }
            tempLen = 1; //initialize the tempLen for next iteration
        }

        //loop to check the sequence in each column
        //j is row, i is column this time
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {

                if (arr[j, i] != arr[j + 1, i])
                {
                    tempLen = 1;
                    break;
                }
                else { tempLen++; }
                if (tempLen > Len)
                {
                    Len = tempLen;
                    xidx = j;
                    yidx = i;
                }
            }
            tempLen = 1; //initialize the tempLen for next iteration
        }

        //loop to check the positive diagonal (top left to bottom right)
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                for (int row = i, col = j; row < n - 1 && col < m - 1; row++, col++)
                {
                    if (arr[row, col] == arr[row + 1, col + 1])
                    {
                        tempLen++;
                    }
                    else { tempLen = 1; }
                    if (tempLen > Len)
                    {
                        Len = tempLen;
                        xidx = row;
                        yidx = col;
                    }
                }
                tempLen = 1; //initialize the tempLen for next iteration
            }
        }
        //loop to check the negative diagonal (top right to bottom left)
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = m - 1; j > 0; j--)
            {
                for (int row = i, col = j; row < n - 1 && col > 0; row++, col--)
                {
                    if (arr[row, col] == arr[row + 1, col - 1])
                    {
                        tempLen++;
                    }
                    else { tempLen = 1; }
                    if (tempLen > Len)
                    {
                        Len = tempLen;
                        xidx = row;
                        yidx = col;
                    }
                }
                tempLen = 1; //initialize the tempLen for next iteration
            }
        }

        Console.WriteLine("The longest sequence of equal string elements is " + arr[xidx, yidx]);
        Console.WriteLine(Len + " times.");

    }
}