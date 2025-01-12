class Ch12Q8
{
    static void Main()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enther start: ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter End: ");
        int end = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            arr[i] = ReadNumber(start, end);
        }
        PrintArr(arr);
    }
    static int ReadNumber(int start, int end)
    {
        int n = 0;
        try
        {
            if (start > end)
            {
                throw new ArgumentOutOfRangeException ("Start value is less than End value!");
            }
            if (start + 10 > end)
            {
                throw new ArgumentOutOfRangeException ("The range is less than 10!");
            }
        
            n = int.Parse(Console.ReadLine());

            if (n < start || n > end)
            {
                throw new ArgumentOutOfRangeException ("The input out of range!");
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
        return n;
    }
    static void PrintArr(int[] arr)
    {
        Console.WriteLine("The enter element is: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}