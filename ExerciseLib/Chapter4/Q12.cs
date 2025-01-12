class Q12
{
    static void ans12()
    {
        double oldSum = 0;
        double newSum = 1;
        int multi = 1;
        double counter = 2;

        Console.WriteLine("The sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 +... is");
        while (Math.Abs(newSum - oldSum) > 0.001)
        {
            oldSum = newSum;
            newSum = newSum + multi * 1 / counter;
            multi = multi * (-1);
            counter++;
        }
        Console.WriteLine("{0:F5}", newSum);
    }
}
