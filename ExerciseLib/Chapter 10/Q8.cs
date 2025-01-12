using System.Buffers;

class Ch10Q8
{
    static int[] arr = { 2, 3, 1, -1 };
    static int len = arr.Length;
    static void ans()
    {
        Console.Write("Enter the number N: ");
        int sum = int.Parse(Console.ReadLine());
        Console.WriteLine("The subsets are: ");

        FindSum(len, sum);
    }
    static void FindSum(int n, int sum)
    {
        if (n == 0)
        {
            return;
        }
        int[] temp = new int[n];
        FindSum(n - 1, sum);
        CalSum(temp, 0, 0, n, sum);
    }
    static void CalSum(int[] temp, int start, int idx, int end, int sum)
    {
        if (idx == end)
        {
            if(SubsetSum(temp) == sum)
            {
                PrintArray(temp);
            }
            return;
        }

        for (int i = start; i < len; i++)
        {
            temp[idx] = arr[i];
            start = start + 1;
            CalSum(temp, start, idx + 1, end, sum);
        }
    }
    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();
    }
    static int SubsetSum(int[] temp)
    {
        int sum = 0;
        for (int i = 0; i < temp.Length; i++)
        {
            sum += temp[i];
        }
        return sum;
    }
}