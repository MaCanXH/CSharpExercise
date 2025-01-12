class Ch13Q21
{
	static void ans()
    {
        string s = "AbbA join laamaal key baba shs exe shy heyy kiibi wahtthaw";
        Console.WriteLine("The string is \n {0}", s);
        string[] arr = s.Split(" ");
        Console.WriteLine("Palindrome texts are ");
        for (int i = 0; i < arr.Length; i++)
        {
            Palin(arr[i]);
        }
    }
    static void Palin(string pa)
    {
        int len = pa.Length;
        bool checker = true;
        for (int i = 0; i < len; i++)
        {
            if(pa[i] != pa[len - 1 - i])
            {
                checker = false;
                break;
            }
        }
    if (checker == true)
        {
            Console.Write(pa + " ");
        }
    }
}
