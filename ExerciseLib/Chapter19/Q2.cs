// Q2. Implement a data structure, which can quickly do the following 
// two operations: add an element and extract the smallest element. 
// The structure should accept adding duplicated elements.

using System.Runtime.InteropServices;

class Q2
{
    static void ans()
    {
        SortedSet<int> Set = new SortedSet<int>();
        Set.Add(1);
        Set.Add(-2);
        Set.Add(3);
        Set.Add(4);
        Set.Add(7);
        Set.Add(1);

        int min = Set.First();

        Console.WriteLine("The smallest element is " + min);
        Console.WriteLine("The total number of element in the set is " + Set.Count);
    }
}