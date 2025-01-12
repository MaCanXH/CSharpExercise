class Q23
{
    //recursion is applied in this solution
    static int[] vari; //array combo will be used to store different variation temporary
    static void ans()
    {
        Console.WriteLine("Enter the N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the K: ");
        int k = int.Parse(Console.ReadLine());

        vari = new int[k]; //initialization of combo

        Console.WriteLine("The variations are:");
        Variation(n, k, 0);
    }
    // method Variation will recall itself until it reaches the length k
    // comboidx is used to indicate the current index of the combo
    static void Variation(int n, int k, int variidx)
    {
        //to check if the number of elements in combo has reaches to limit k or not
        //if k = 0, it means it has stored k elements in the combo
        //then proceed to printing combo by method comboPrint
        if (k == 0)
        {
            comboPrint(vari);
            return;
        }
        //there are n variations for every elements in the combo
        //therefore for every index, we create a combo for n times 
        for (int i = 1; i <= n; i++)
        {
            vari[variidx] = i;
            Variation(n, k - 1, variidx + 1);
        }
    }
    //comboPrint is simply a method to print every combo result
    static void comboPrint(int[] vari)
    {
        for (int i = 0; i < vari.Length; i++)
        {
            Console.Write(vari[i] + " ");
        }
        Console.WriteLine();
    }
}
