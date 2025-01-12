class Q12
{
    // Q12. Define classes File {string name, int size} and Folder 
    // {string name, File[] files, Folder[] childFolders}. Using 
    // these classes, build a tree that contains all files and 
    // directories on your hard disk, starting from C:\Windows\. 
    // Write a method that calculates the sum of the sizes of files 
    // in a sub-tree and a program that tests this method. To crawl 
    // the directories use recursively crawl depth (DFS).
    static void ans()
    {
        Folder folder = new Folder(@"C:\Users\User\Desktop\CSharp Exercises\Exercises");
        double folderSize = SizeCalDFS(folder);
        Console.WriteLine("The size of this folder is {0:0.00} KB.", folderSize);
        Console.WriteLine("The size of this folder is {0:0.00} MB.", (double)folderSize/1024);
    }

    // DFS method to calculate the size of the folder
    static double SizeCalDFS(Folder folder)
    {
        double size = 0;
        foreach(File s in folder.files)
        {
            size += (double)s.Size/1024;
        }
        for(int i = 0; i < folder.childFolders.Count; i++)
        {
            size += SizeCalDFS(folder.childFolders[i]);
        }
        return size;
    }

    // a class File to store the infomation of a file
    // including nmae, size.
    class File
    {
        private string name;
        private int size;

        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }
        public string Name
        {
            get{return this.name;}
        }
        public int Size
        {
            get{return this.size;}
        }
    }

    // a tree class Folder storing infomation of the folder
    // including infomation of files and sub-folder
    class Folder
    {
        public string name; // folder name
        public List<File> files; // list of files in the current folder
        public List<Folder> childFolders; // list of sub-folders of the current folder
        public Folder(string name)
        {
            this.name = name;
            this.files = this.GetFiles(name);
            this.childFolders = GetChildFolders(name);
        }
        // private method to get the files in the current folder
        // return a list of files
        private List<File> GetFiles(string name)
        {
            DirectoryInfo info = new DirectoryInfo(name);
            FileInfo[] fileinfo = info.GetFiles();
            List<File> files = new List<File>();
            for(int i = 0; i < fileinfo.Length; i++)
            {
                files.Add(new File(fileinfo[i].Name, (int)fileinfo[i].Length));
            }
            return files;
        }
        // private method to get the sub-folders of the current folder
        // return a list of sub-folders
        private List<Folder> GetChildFolders(string name)
        {   
            DirectoryInfo info = new DirectoryInfo(name);
            DirectoryInfo[] dir = info.GetDirectories();
            List<Folder> folders = new List<Folder>();
            for(int i = 0; i < dir.Length; i++)
            {
                folders.Add(new Folder(dir[i].FullName));
            }
            return folders;
        }
    }
}