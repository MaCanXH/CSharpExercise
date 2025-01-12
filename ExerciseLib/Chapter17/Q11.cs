class Q11
{
    // Q11. Write a program that searches the directory 
    // C:\Windows\ and all its subdirectories recursively 
    // and prints all the files which have extension *.exe.
    static void ans()
    {
        DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\Desktop\CSharp Exercises\Exercises");
        traverseDFS(dir);
    }
    // method to traverse the directory
    static void traverseDFS(DirectoryInfo dir)
    {
        FileInfo[] f = dir.GetFiles();
        foreach(FileInfo file in f)
        {
            // check if the file is *.exe extension
            string s = file.ToString();
            if(s.Contains(".exe"))
            {
                Console.WriteLine(s);
            }
        }

        DirectoryInfo[] child = dir.GetDirectories();
        foreach(DirectoryInfo d in child)
        {
            traverseDFS(d);
        }
    }
    // method to traverse the directory by DFS and print the file with *.exe extension

}