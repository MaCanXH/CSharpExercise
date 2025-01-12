class Ch9Q12
{
    static void Main()
    {
        Console.WriteLine("Polynomial 1: ax^2 + bx + c");
        Console.Write("Enter the coefficient a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient c: ");
        int c = int.Parse(Console.ReadLine());

        int[] arr1 = { c, b, a };

        Console.WriteLine("Polynomial 2: ax + b");
        Console.Write("Enter the coefficient a: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient b: ");
        int e = int.Parse(Console.ReadLine());

        int[] arr2 = { e, d, 0 };

        PolySum(arr1, arr2);
    }

    static void PolySum(int[] arr1, int[] arr2)
    {
        int len = arr1.Length;
        int[] temp = new int[len];

        for (int i = 0; i < len; i++)
        {
            temp[i] = arr1[i] + arr2[i];
        }

        Console.WriteLine("The sum is ({0})x^2 + ({1})x + ({2})", temp[2], temp[1], temp[0]);
    }
}
