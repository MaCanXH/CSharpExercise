
class Q17
{
    static void ans()
    {
        Console.Write("Enter the first integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int b = int.Parse(Console.ReadLine());

        int GCD = 1;

        int greater;
        int smaller;

        if (a > b) { greater = a; smaller = b; }
        else { greater = b; smaller = a; }

        for (int i = smaller; i > 0; i--)
        {
            if ((greater % i == 0) && (smaller % i == 0))
            {
                GCD = i;
                break;
            }
        }

        int LCM = Math.Abs(a * b) / GCD;

        Console.WriteLine("the GCD is " + GCD);
        Console.WriteLine("the LCM is " + LCM);
    }
}
//or check out the Euclidean algorithm
/*class GFG
{

    // Recursive method to 
    // return gcd of a and b
    static int gcd(int a, int b)
    {
        if (a == 0)
            return b;
        return gcd(b % a, a);
    }

    // method to return 
    // LCM of two numbers
    static int lcm(int a, int b)
    {
        return (a / gcd(a, b)) * b;
    }

    // Driver method
    public static void Main()
    {
        int a = 15, b = 20;
        Console.WriteLine("LCM of " + a +
         " and " + b + " is " + lcm(a, b));
    }
}*/