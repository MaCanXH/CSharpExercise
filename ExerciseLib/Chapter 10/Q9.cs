class Ch10Q9
{
    //in this approach, the method will find all the subsets of the given in the worst case
    //time complexity will be exponential
    static void ans()
    {
        int[] arr = { 3, 34, 4, 12, 5, 2 };
        int len = arr.Length;

        Console.Write("Enter the sum: ");
        int sum = int.Parse(Console.ReadLine());

        if (SubsetSum(arr, len, sum) == true)
        {
            Console.WriteLine("Subset sum found!");
        }
        else
        {
            Console.WriteLine("Subset sum not found!");
        }
    }
    //this method consider the "last" (e.g. n - 1) element in the subset
    //there are two cases:
    //a) including the last element in the calculate sum (e.g. n - 1 and sum - arr[n - 1]
    //b) excluding the last element in the calculate sum (e.e. n - 1 and sum)
    static bool SubsetSum(int[] arr, int n, int sum)
    {
        if (sum == 0) //if sum == 0, subset sum is found
        {
            return true;
        }
        if (n == 0) //if n == 0, all element has been tried and sum not found
        {
            return false;
        }

        if (arr[n - 1] > sum) //if the last element (n - 1) is larger than the sum, then ignore it
        {
            return SubsetSum(arr, n - 1, sum);
        }
            return (SubsetSum(arr, n - 1, sum) || SubsetSum(arr, n - 1, sum - arr[n - 1]));
    }
}