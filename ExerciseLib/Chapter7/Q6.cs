class Q6
{
    static void ans()
    {
        //this is a loop and condition approach to solve the problem
        int[] arr = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
        int length = arr.Length;

        int[] Result = new int[length]; //new array is created to store the element of the LIS (longest increasing sequence)
        int maxLen = 0; //var maxLen is used to store the length of LIS

        for (int i = 0; i < length - 1; i++)
        {
            //initialization of the temporary var
            int tempLen = 1, tempidx = 1;
            int[] tempResult = new int[length];
            tempResult[0] = arr[i];

            for (int j = i + 1; j < length; j++)
            {
                //if the current element is larger than the previous element stored in tempResult
                //add this element into the tempResult
                if (tempResult[tempidx - 1] < arr[j])
                {
                    tempResult[tempidx] = arr[j];
                    tempLen++;
                    tempidx++;
                }
                //if the current element is smaller than the previous element stored in tempResult
                //but larger than previous - 1 element, change the previous element to current element (e.g. arr[j])
                //tempLen > 1 is to ensure the array not out of bound
                else if (tempLen > 1 && tempResult[tempidx - 1] > arr[j] && tempResult[tempidx - 2] < arr[j])
                {
                    tempResult[tempidx - 1] = arr[j];
                }
            }
            //compare every tempLen to get the LIS
            if (maxLen < tempLen)
            {
                maxLen = tempLen;
                Result = tempResult;
            }
        }

        Console.WriteLine("The aximal sequence of increasing elements is ");
        for (int i = 0; i < maxLen; i++)
        {
            Console.Write(Result[i] + " ");
        }
    }
}
//this is a recursive approach to solve the problem

/*static int LisAL(int[] arr, int L)
{
    //this is  the base case
    //when arr[0], LIS is 1
    if (L == 0)
    {
        return 1;
    }

    //initialize the max LIS
    int mx = 1;

    //consider all elements from left to L
    //at L, consider all element on the left and look for the max LIS
    for (int prev = 0; prev < L; prev++)
    {
        if (arr[L] > arr[prev])
        {
            mx = Math.Max(mx, LisAL(arr, prev) + 1); //compare the current max lIS with the previous element LIS
        }
    }
    return mx;
}

//check the LIS at subarray from left to the current index of array
static int LisSearch(int[] arr, int len)
{
    //initialize the LIS of the current index
    int res = 1;

    //from left to right, check every LIS for each index
    for (int i = 1; i < len; i++)
    {
        res = Math.Max(res, LisAL(arr, i));
    }
    return res;
}

int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };
int length = arr.Length;

Console.WriteLine("The array is ");
for (int i = 0; i < length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.WriteLine("The LIS is " + LisSearch(arr, length));*/