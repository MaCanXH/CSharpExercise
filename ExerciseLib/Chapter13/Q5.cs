class Q5
{
    static void ans()
    {
        string origin = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string text = origin.ToLower();
        string keyword = "in";
        
        int index = text.IndexOf(keyword);
        int counter = 0;

        while (index != -1)
        {
            ++counter;
            index = text.IndexOf(keyword, index + 1);
        }

        Console.WriteLine("The result is {0} occurences.", counter);
    }
}