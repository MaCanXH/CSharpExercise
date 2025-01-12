class Q16
{
    static void ans()
    {
        int[] arr = { 1, 2, 4, 5, 7, 8, 12, 15, 16, 17, 18, 19, 20 };
        int low = 0, high = arr.Length - 1;
        int idx = 0;

        Console.WriteLine("enter an element: ");
        int x = int.Parse(Console.ReadLine());

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == x)
            {
                idx = mid;
                break;
            }
            else if (arr[mid] < x)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        Console.WriteLine("the index is " + idx);
    }
}
