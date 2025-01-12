class Q24
{
    static int[] combo;
    static void ans()
    {
        Console.WriteLine("Enter the N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the K: ");
        int k = int.Parse(Console.ReadLine());

        combo = new int[k];

        Console.WriteLine("The combinations are:");
        Combination(n, k, 0, 1);
    }

    static void Combination(int n, int k, int comboidx, int flag)
    {

        if (k == 0)
        {
            comboPrint(combo);
            return;
        }

        for (int i = flag; i <= n; i++)
        {
            combo[comboidx] = i;
            //difference between ++flag, flag++ and flag + 1 is
            //++flag: add 1 to var flag itself before the arithmetic process (change the value of flag)
            //flag++: add 1 to var flag itself after the arithmetic process
            //flag + 1: add 1 var flag of current process and proceed to next process (without changing the value of flag)
            Combination(n, k - 1, comboidx + 1, ++flag);
        }
    }

    static void comboPrint(int[] combo)
    {
        for (int i = 0; i < combo.Length; i++)
        {
            Console.Write(combo[i] + " ");
        }
        Console.WriteLine();
    }
}
