class Q8
{
    static void ans8()
    {
        Console.WriteLine("indicate your choice (0 = integer, 1 = real number, 2 = text):");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 0)
        {
            Console.Write("enter an integer: ");
            int a = int.Parse(Console.ReadLine());
            a = a + 1;
            Console.WriteLine(a);
        }
        else if (choice == 1)
        {
            Console.Write("enter a real number: ");
            double b = double.Parse(Console.ReadLine());
            b = b + 1;
            Console.WriteLine(b);
        }
        else if (choice == 2)
        {
            Console.Write("enter the text: ");
            string s = Console.ReadLine();
            s = s + "*";
            Console.WriteLine(s);
        }
    }
}