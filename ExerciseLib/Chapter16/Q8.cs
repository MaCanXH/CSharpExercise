class Q8
{
    static void ans()
    {
        int[] arr = {2, 2, 3, 3, 2, 3, 4, 3, 3};
        int counter = 0;
        int majorant = 0;
        
        // add up the counter if the next element is same as the current one
        // subtract it if different
        // when counter is 0, change the "majorant" to the current element
        for(int i = 0; i < arr.Length; i++)
        {
            if(counter == 0 )
            {
                majorant = arr[i];
            }
            if(arr[i] == majorant)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }

        // count the occurance of "majorant"
        // if it is greater than N/2 + 1
        // then this is the true majorant
        counter = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] ==majorant)
            {
                counter++;
            }
        }
        if(counter > arr.Length / 2)
        {
            Console.WriteLine("The majorant is " + majorant);
        }
        else{
            Console.WriteLine("Ther is no majorant");
        }
    }
}