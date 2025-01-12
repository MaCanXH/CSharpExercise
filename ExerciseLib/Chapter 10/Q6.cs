class Ch10Q6
{
    static void ans()
    {
        Console.Write("Enter the length of the array: ");
        int len = int.Parse(Console.ReadLine());

        int[] arr = new int[len];

        for (int i = 0; i < len; i++)
        {
            {
                Console.Write("Enter the number of arr[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            MergeSort(arr, 0, len - 1);
            Console.WriteLine();
            Console.WriteLine("The sorted array is ");
            PrintArray(arr);
        }

        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (right + left) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }
        static void Merge(int[] arr, int left, int mid, int right)
        {
            int len1 = mid - left + 1;
            int len2 = right - mid;

            int[] arr1 = new int[len1];
            int[] arr2 = new int[len2];
            int i = 0, j = 0;

            for (i = 0; i < len1; i++)
            {
                arr1[i] = arr[left + i];
            }
            for (j = 0; j < len2; j++)
            {
                arr2[j] = arr[mid + j + 1];
            }

            int k = left;
            i = 0; j = 0;

            while (i < len1 && j < len2)
            {
                if (arr1[i] <= arr2[j])
                {
                    arr[k] = arr1[i];
                    i++;
                }
                else if (arr1[i] > arr2[j])
                {
                    arr[k] = arr2[j];
                    j++;
                }
                k++;
            }

            while (i < len1)
            {
                arr[k] = arr1[i];
                i++;
                k++;
            }
            while (j < len2)
            {
                arr[k] = arr2[j];
                j++; k++;
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0, 4}", arr[i]);
            }
        }
    }
}