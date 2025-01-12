using System.Text;
    class Q2
// {
//     static void ans()
//     {
//         Console.Write("Enter a string: ");
//         string n = Console.ReadLine();
//         string reverse = null;

//         for (int i = n.Length - 1; i >= 0; i--)
//         {
//             reverse = reverse + n[i];
//         }

//         Console.WriteLine("The reverse of {0} is {1}.", n, reverse);
//     }
// }

//or

{
    static void ans()
    {
        Console.Write("Enter a string: ");
        string n = Console.ReadLine();
        
        Console.WriteLine("The reverse of {0} is {1}", n, reverse(n));
    }

    static string reverse(string n)
    {
        StringBuilder reverse = new StringBuilder();

        for (int i = n.Length - 1; i >= 0; i--)
        {
            reverse.Append(n[i]);
        }
        return reverse.ToString();
    }
}

