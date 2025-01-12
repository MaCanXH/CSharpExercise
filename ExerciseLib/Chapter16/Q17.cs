class Q17
{
    static void ans()
    {
        string path = @"C:\Users\User\Desktop\CSharp Exercises\Hello World";
        DirectoryInfo p = new DirectoryInfo(path);
        DFS(p, string.Empty);
    }
    static void DFS(DirectoryInfo path, string s)
    {
        Console.WriteLine(s + path.FullName);
        s = s + "   ";
        DirectoryInfo[] children = path.GetDirectories();
        
        foreach (DirectoryInfo child in children)
        {
            DFS(child, s);
        }
    }
}