class Q2
{
    // Q2. Write a program to remove from a sequence all the integers, 
    // which appear odd number of times. For instance, for the sequence 
    // {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6} the output would be 
    // {5, 3, 3, 5}.
    static void ans()
    {
        int[] arr = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6};
        Dictionary<int, int> oddsNum = new Dictionary<int, int>();

        foreach(int i in arr)
        {
            oddsNum[i] = 0; 
        }
        foreach(int i in arr)
        {
            int count = oddsNum[i];
            oddsNum[i] = count + 1;
        }

        List<int> evenList = new List<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(oddsNum[arr[i]] % 2 == 0)
            {
                evenList.Add(arr[i]);
            }
        }

        Console.WriteLine("The even number sequence is ");
        foreach(int res in evenList)
        {
            Console.Write(res + " ");
        }
    }
}