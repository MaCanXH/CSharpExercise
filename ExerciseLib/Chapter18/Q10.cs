class Q10
{
    // Q10. We are given three sequences of numbers, defined by the formulas:
    // f1(0) = 1; f1(k) = 2*f1(k-1) + 3; f1 = {1, 5, 13, 29, …}
    // f2(0) = 2; f2(k) = 3*f2(k-1) + 1; f2 = {2, 7, 22, 67, …}
    // f3(0) = 2; f3(k) = 2*f3(k-1) - 1; f3 = {2, 3, 5, 9, …}
    // Write a program to find the intersection and union of sets of 
    // sequences’ elements within the range [0; 100000]:
    // f1 * f2; f1 * f3; f2 * f3; f1 * f2 * f3;
    // f1 + f2; f1 + f3; f2 + f3; f1 + f2 + f3. 
    // Here + and * mean respectively union and intersection of sets.
    static void ans()
    {
        HashedSet<int> set1 = new HashedSet<int>();
        HashedSet<int> set2 = new HashedSet<int>();
        HashedSet<int> set3 = new HashedSet<int>();

        // initialization of set f1
        int f = 1;
        while(f <= 100000)
        {
            set1.Add(f);
            f = 2 * f + 3;
        }
        Console.WriteLine("Set f1:");
        printSet(set1);

        // initialization of set f2
        f = 2;
        while(f <= 100000)
        {
            set2.Add(f);
            f = 3 * f + 1;
        }
        Console.WriteLine("Set f2:");
        printSet(set2);

        // initialization of set f3
        f = 2;
        while(f <= 100)
        {
            set3.Add(f);
            f = 2 * f - 1;
        }
        Console.WriteLine("Set f3:");
        printSet(set3);

        HashedSet<int> f1xf2 = new HashedSet<int>();
        f1xf2.Union(set1);
        f1xf2.Intersect(set2);

        Console.WriteLine("Set for f1*f2 is ");
        printSet(f1xf2);


        HashedSet<int> f1xf3 = new HashedSet<int>();
        f1xf3.Union(set1);
        f1xf3.Intersect(set3);
        
        Console.WriteLine("Set for f1*f3 is ");
        printSet(f1xf3);


        HashedSet<int> f2xf3 = new HashedSet<int>();
        f2xf3.Union(set2);
        f2xf3.Intersect(set3);

        Console.WriteLine("Set for f2*f3 is ");
        printSet(f2xf3);

        HashedSet<int> f1uf2 = new HashedSet<int>();
        f1uf2.Union(set1);
        f1uf2.Union(set2);

        Console.WriteLine("Set for f1+f2 is ");
        printSet(f1uf2);


        HashedSet<int> f1uf3 = new HashedSet<int>();
        f1uf3.Union(set1);
        f1uf3.Union(set3);
        
        Console.WriteLine("Set for f1+f3 is ");
        printSet(f1uf3);


        HashedSet<int> f2uf3 = new HashedSet<int>();
        f2uf3.Union(set2);
        f2uf3.Union(set3);

        Console.WriteLine("Set for f2+f3 is ");
        printSet(f2uf3);
    }
    // helper function to print the set
    static void printSet(HashedSet<int> set)
    {
        Console.Write("{ ");
        foreach(var i in set)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("}");
    }
}