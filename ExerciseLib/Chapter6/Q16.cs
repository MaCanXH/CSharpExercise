using System.Collections;

class Q16
{
    static void ans()
    {
        Console.Write("Please enter N: ");
        int N = int.Parse(Console.ReadLine());

        ArrayList group = new ArrayList(N);

        for (int i = 1; i <= N; i++)
        {
            group.Add(i);
        }

        while (group.Count > 0)
        {
            //size of the vector
            int n = group.Count;

            //making sure the number is within the index range
            Random rnd = new Random();
            int index = (rnd.Next(n));

            //store the number in index
            int num = (int)group[index];

            //swap the [n - 1] number to the index
            //then remove the [n - 1] number
            group[index] = (int)group[n - 1];
            group.Remove(group[n - 1]);

            //print out the index number
            Console.Write(num + " ");
        }
    }
}