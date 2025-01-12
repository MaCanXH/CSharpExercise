class Q3
{
    static void ans()
    {
        char[] a = { 'a', 'b', 'c', 'd', 'e', 'f' };
        char[] b = { 'a', 'b', 'c', 'd', 'e', 'f' };
        bool equal = true; //initialize the bool equal
        int compar;

        //to check which array is shorter, then use the short length for comparison
        if (a.Length != b.Length)
        {
            if (a.Length > b.Length) { compar = b.Length; }
            else { compar = a.Length; }
        }
        else { compar = a.Length; }


        //comparison of char in the two array
        for (int i = 0; i < compar; i++)
        {
            if (a[i] > b[i])
            {
                equal = false;
                Console.WriteLine("Array b is first in lexicographical order");
                break;
            }
            else if (a[i] < b[i])
            {
                equal = false;
                Console.WriteLine("Array a is first in lexicographical order");
                break;
            }
        }

        //if the char in two arrays are equal, then check the length of arrays
        if (equal)
        {
            if (a.Length > b.Length) { Console.WriteLine("Array b is first in lexicographical order"); }
            else if (a.Length < b.Length) { Console.WriteLine("Array a is first in lexicographical order"); }
            else { Console.WriteLine("the two arrays are equal."); }
        }
    }
}