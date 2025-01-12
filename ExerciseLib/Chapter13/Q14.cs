class Ch13Q14
{
	static void ans()
    {
        string s = "C# is not C++ and PHP is not Delphi";
        string[] arr = s.Split(' ');

        for (int i = arr.Length - 1; i >=0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
