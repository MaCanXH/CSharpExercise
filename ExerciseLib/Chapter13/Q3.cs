class Q3
{
    static void ans()
    {
        Console.Write("Enter an arithmetic expression: ");
        string arith = Console.ReadLine();

        int counter = 0;

        for (int i = 0; i < arith.Length; i++)
        {
            if (counter >= 0 && i < arith.Length)
            {
                if (arith[i] == '(')
                {
                    counter++;
                }
                else if (arith[i] == ')')
                {
                    counter--;
                }
            }
            if (counter < 0)
            {
                Console.WriteLine("incorrect expression!");
                break;
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("correct expression!");
        }
        else if (counter > 0)
        {
            Console.WriteLine("incorrect expression!");
        }
    }
}