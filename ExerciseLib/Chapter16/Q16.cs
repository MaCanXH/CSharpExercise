class Q16
{
    static void ans()
    {
        string path = @"C:\Users\User\Desktop\CSharp Exercises\Exercises\Chapter16";
        BFS(path);
    }
    static void BFS(string path)
    {
        Queue<DirectoryInfo> Q = new Queue<DirectoryInfo>();
        Q.Enqueue(new DirectoryInfo(path));
        while (Q.Count > 0)
        {
            DirectoryInfo current = Q.Dequeue();   
            Console.WriteLine(current.FullName);
            
            DirectoryInfo[] children = current.GetDirectories();
            foreach(DirectoryInfo child in children)
            {
                Q.Enqueue(child);
            }
        }
    }
}