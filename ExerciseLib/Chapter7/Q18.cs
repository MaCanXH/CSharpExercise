class Q18
{
    //recursion was applied in this problem
    static void ans()
    {
        //Swap is a method to swap the elements between two array
        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        //QuickSort is a recursive method to call itself again and again
        //a pivot will be selected within an array, it could be any element
        //all value smaller than the pivot will be sorted to the left
        //and value bigger than the pivot will be sorted to the right
        //new pivot will be selected on each side again and begin for the next sort
        //until there are no or only one element left on each side (e.g. start = end)
        static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                //index of pivot will be obatined and become the new start or end index
                int pivot = PivotSort(arr, start, end);

                QuickSort(arr, start, pivot - 1);//pivot is excluded from the new sort
                QuickSort(arr, pivot + 1, end);
            }
        }

        //in PivotSort, the pivot elment will be sorted to the final location of the sorted array
        //index of the pivot will be returned for further process
        //pivot could be any element in the array, in this case,
        //we will use the first element of each side.
        static int PivotSort(int[] arr, int s, int e)
        {
            int piv = arr[s]; //first element is selected as the pivot
            int sortidx = s; //index of the next sorted element

            for (int i = s + 1; i <= e; i++)
            {
                if (piv > arr[i]) //if the element is bigger than pivot, move to left
                {
                    sortidx++; //current sorting index
                    Swap(arr, i, sortidx);
                }
            }
            //aftte the loop above, all element smaller than the pivot will be sort to left of sortdix
            //however, pivot will still be at the start, therefore we need to swap it with the sortdix
            Swap(arr, s, sortidx); 
            return sortidx; //the pivot will be at the correct location of the final sorted array
        }

        int[] arr = { 10, 7, 8, 9, 1, 5 };

        Console.WriteLine("The array before quick sort is");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0,3}", arr[i]);
        }
        Console.WriteLine();

        QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("The array after quick sort is");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0,3}", arr[i]);
        }
    }
}
