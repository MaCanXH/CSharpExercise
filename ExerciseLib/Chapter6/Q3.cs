class Q3
{
    static void ans()
    {
        int[] serie = { 12, 4132, 534, 356, 6, -1, -54 };
        int biggest = 0;
        int smallest = 0;


        for (int i = 0; i < 7; i++)
        {
            if (biggest < serie[i])
            {
                biggest = serie[i];
            }
            if (smallest > serie[i])
            {
                smallest = serie[i];
            }
        }
        Console.WriteLine("biggest = " + biggest);
        Console.WriteLine("smallest = " + smallest);
    }
}