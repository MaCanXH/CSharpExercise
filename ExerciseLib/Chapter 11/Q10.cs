class Ch11Q10
{
    static void ans()
    {
        string before = "43 68 9 23 318";
        string[] after = before.Split(' ');
        int len = after.Length;
        int sum = 0;

        for (int i = 0; i < len; i++)
        {
            int temp = int.Parse(after[i]);
            sum += temp;
        }

        Console.WriteLine("The sum is " + sum);
    }
}
