class Q2
{
    static void ans()
    {
        int[] array1 = { 1, 2, 3, 5, 8, 15, 66 };
        int[] array2 = { 1, 2, 3, 5, 8, 15, 66 };
        bool lengthEqual = array1.Length == array2.Length;
        bool equal = true;

        if (lengthEqual)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    equal = false;
                    break;
                }
            }
        }
        else { equal = false; }

        Console.WriteLine("Equal array? " + equal);

    }
}