class Q17
{
    //recursion was applied in this problem
    static void Main()
    {
        //merge is a method to merge the divided element back together
        //meanwhile, it also perform the sort function
        //the first element of the left and right part was compared
        //e.g. left[0] and right[0]
        //the smaller one will replace the original element in arr[]
        //then it moves on to the next element for comparison
        static void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] left = new int[n1]; //create the left array
            int[] right = new int[n2]; //create the right array

            int i = 0, j = 0;
            //input the element from arr[] to left and right respectively
            for (i = 0; i < n1; i++)
            {
                left[i] = arr[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                right[j] = arr[m + 1 + j];
            }

            i = 0; j = 0;

            int k = l; //sorting begins from leftmost index e.g. l

            while (i < n1 && j < n2) //loop until the shortest length reached
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++; //move to next element
            }

            //input the remaining element to the arr[]
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        //mergeSort is a recursive method to recall itself again and again
        //in this method, the array is split by half in two part as left and right
        //the split goes on until it the the two part contains only 1 element
        static void mergeSort(int[] arr, int left, int right)
        {
            if (left < right) //to check if left and right are of the same element
            {
                int mid = (left + right) / 2;
                mergeSort(arr, left, mid); //next split for the left part of array
                mergeSort(arr, mid + 1, right); //next split for the right part of array

                merge(arr, left, mid, right); //this is a method to "merge" and "sort" the divided elements

            }
        }

        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,4}", arr[i]);
            }
        }


        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("the given array is");
        printArray(arr);
        mergeSort(arr, 0, arr.Length - 1);
        Console.WriteLine();
        Console.WriteLine("the sorted array is");
        printArray(arr);
    }
}
