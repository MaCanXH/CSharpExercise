class Q9
{
    static void ans9()
    {
        Console.Write("Please enter the first integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second integer: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please enter the third integer: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Please enter the fourth integer: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Please enter the fifth integer: ");
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine("Subset whose sum is 0 is");

        //check all 26 cases, excluding only single 0
        if (a + b == 0) { Console.WriteLine(a + " " + b); }
        if (a + c == 0) { Console.WriteLine(a + " " + c); }
        if (a + d == 0) { Console.WriteLine(a + " " + d); }
        if (a + e == 0) { Console.WriteLine(a + " " + e); }
        if (b + c == 0) { Console.WriteLine(b + " " + c); }
        if (b + d == 0) { Console.WriteLine(b + " " + d); }
        if (b + e == 0) { Console.WriteLine(b + " " + e); }
        if (c + d == 0) { Console.WriteLine(c + " " + d); }
        if (c + e == 0) { Console.WriteLine(c + " " + e); }
        if (d + e == 0) { Console.WriteLine(d + " " + e); }
        if (c + d + e == 0) { Console.WriteLine(c + " " + d + " " + e); }
        if (b + d + e == 0) { Console.WriteLine(b + " " + d + " " + e); }
        if (b + c + e == 0) { Console.WriteLine(b + " " + c + " " + e); }
        if (b + c + d == 0) { Console.WriteLine(b + " " + c + " " + d); }
        if (a + d + e == 0) { Console.WriteLine(a + " " + d + " " + e); }
        if (a + c + e == 0) { Console.WriteLine(a + " " + c + " " + e); }
        if (a + c + d == 0) { Console.WriteLine(a + " " + c + " " + d); }
        if (a + b + e == 0) { Console.WriteLine(a + " " + b + " " + e); }
        if (a + b + d == 0) { Console.WriteLine(a + " " + b + " " + d); }
        if (a + b + c == 0) { Console.WriteLine(a + " " + b + " " + c); }
        if (a + b + c + d == 0) { Console.WriteLine(a + " " + b + " " + c + " " + d); }
        if (a + b + c + e == 0) { Console.WriteLine(a + " " + b + " " + c + " " + e); }
        if (a + c + d + e == 0) { Console.WriteLine(a + " " + c + " " + d + " " + e); }
        if (b + c + d + e == 0) { Console.WriteLine(b + " " + c + " " + d + " " + e); }
        if (a + b + c + d + e == 0) { Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e); }
    }
}