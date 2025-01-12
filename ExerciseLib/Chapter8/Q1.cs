class Q1
{
    static void ans()
    {
        int a = 151;
        int b = 35;
        int c = 43;
        int d = 251;
        int e = 1023;
        int f = 1024;

        Console.WriteLine("the number {0} in binary numeral system is", a);
        Console.WriteLine(BinSystem(a));
        Console.WriteLine("the number {0} in binary numeral system is", b);
        Console.WriteLine(BinSystem(b));
        Console.WriteLine("the number {0} in binary numeral system is", c);
        Console.WriteLine(BinSystem(c));
        Console.WriteLine("the number {0} in binary numeral system is", d);
        Console.WriteLine(BinSystem(d));
        Console.WriteLine("the number {0} in binary numeral system is", e);
        Console.WriteLine(BinSystem(e));
        Console.WriteLine("the number {0} in binary numeral system is", f);
        Console.WriteLine(BinSystem(f));

        static string BinSystem(int n)
        {
            string bin = null;
            if (n == 0)
            {
                bin = "0";
                return bin;
            }

            while (n / 2 != 0)
            {
                bin = (n % 2) + bin;

                n = n / 2;
            }
            if (n == 1) { bin = "1" + bin; }
            return bin;
        }
    }
}
