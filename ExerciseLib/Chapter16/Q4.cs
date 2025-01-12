class Q4
{
    static void ans()
    {
        List<int> list = new List<int>{2, 2, 4, 4, 4, 3};
        List<int> ans = LSL(list);
        foreach(int i in ans)
        {
            Console.WriteLine(i);
        }

    }
    static List<int> LSL(List<int> list)
    {
        int start = 0;
        int length = 1;
        int maxStart = 0;
        int maxLen = 1;
        int current = list[0];

        for(int i = 1; i < list.Count; i++)
        {
            if (current == list[i])
            {
                length++;
                if(length > maxLen)
                {
                    maxLen = length;
                    maxStart = start;
                }
            }
            else
            {
                length = 1;
                start = i;
                current = list[i];
            }
        }

        List<int> result = new List<int>();
        for (int i = 0; i < maxLen; i++)
        {
            result.Add(list[maxStart]);
        }
        return result;
    }
}