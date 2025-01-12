class Q21
{
    //this solution is a recursive approach

    static int sum = 14; //initialization of the wanted sum
    static bool solution = false; //initialization if there is a possible solution exist
    static int k; //initialize the number of wanted elements
    static void ans()
    {
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int[] subset = new int[arr.Length]; //create a subset to store the elements of possible solution

        Console.WriteLine("The set is");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("the sum is " + sum);

        Console.Write("Enter the number K: ");
        k = int.Parse(Console.ReadLine());

        //starting from left to right, check every combination of possible sum
        //(e.g. sum of any 2 element, any 3 elements, any 4 elements etc.)
        //i = 1 since the leftmost index of subset is 0,
        //i = 1 means at least subset[0] and subset[1] total of 2 elements
        for (int i = 1; i <= arr.Length; i++)
        {
            PossibleSum(arr, subset, 0, 0, i);
        }
        //if there is no possible solution
        if (!solution)
        {
            Console.WriteLine("the is no such subset.");
        }
    }

    //in PossibleSum, we check every possible combination sum within the checking array
    //int index is the checking index of the subset, int current is the different element in checking array
    //e.g. subset[2] could be any element in the checking array for the different sum combination
    //this method keeps calling itself until all possible sum combination has been checked
    //checking of the sum in subset element will be performed in method "checkSum"
    static void PossibleSum(int[] arr, int[] subset, int index, int current, int subsetelement)
    {
        if (index == subsetelement) //check if the element in a subset has reached the designated combo element. int subsetelement is the current combo number.
        {
            checkSum(subset, subsetelement);
            return;
        }

        for (int i = current; i < arr.Length; i++)
        {
            subset[index] = arr[i];
            PossibleSum(arr, subset, index + 1, i + 1, subsetelement);
        }
    }

    //in checkSum, the checking elements in the subset will be sum up all together
    //if the sum equal to the wanted sum, the subset element will be printed on screen
    static void checkSum(int[] subset, int subsetelement)
    {
        int subsetSum = 0;

        for (int i = 0; i < subsetelement; i++)
        {
            subsetSum += subset[i];
        }

        //if the sum in the subset is equal to the wanted sum
        //and number of elements in the subset is equal to the the wanted number of elements
        if (subsetSum == sum && subsetelement == k)
        {
            for (int i = 0; i < subsetelement; i++)
            {
                Console.Write(subset[i] + " ");
            }
            Console.WriteLine();
            solution = true; //to check if there are any possible solution
        }
    }
}

