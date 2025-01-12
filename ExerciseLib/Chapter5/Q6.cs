class Q6
{
    static void ans6()
    {
        int a = 1;
        int b = -5;
        int c = -14;
        double checker = b * b - 4 * a * c;
        double root1;
        double root2;

        Console.WriteLine("the quadratic equation: {0}x^2 + {1}x + {2}", a, b, c);

        if (checker < 0)
        {
            Console.WriteLine("The equation has no root.");
        }
        else if (checker == 0)
        {
            Console.Write("The equation has one root: ");
            root1 = -b / (2 * a);
            Console.WriteLine(root1);
        }
        else if (checker > 0)
        {
            Console.Write("The equation has two roots: ");
            root1 = (-b + Math.Sqrt(checker)) / (2 * a);
            root2 = (-b - Math.Sqrt(checker)) / (2 * a);

            Console.WriteLine(root1 + " and " + root2);
        }

    }
}