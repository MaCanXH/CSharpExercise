class Q6
{
    static void ans()
    {
        List<int> list = new List<int>{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};
        List<int> ans = new List<int>();
        int count;

        for(int i = 0; i < list.Count; i++)
        {
            count = 0;
            for(int j = 0; j < list.Count; j++)
            {
                if (list[i] == list[j])
                {
                    count++;
                }
            }
            if(count % 2 == 0)
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