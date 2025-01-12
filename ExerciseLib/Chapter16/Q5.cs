class Q5
{
    static void ans()
    {
        //using list.Remove() in this case will shorten the list during the checking
        //which reassign a new index for each element, causing a bug to occur
        //instead, we add the postive number into a new list
        List<int> list = new List<int>{19, -10, 12, -6, -3, 34, -2, 5};
        List<int> ans = new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            if(list[i] >= 0)
            {
                ans.Add(list[i]);
            }
        }
        for(int i = 0; i < ans.Count; i++)
        {
            Console.Write(ans[i] + " ");
        }
    }
}