public class TreeNode
{
    private int value;
    private bool hasParent;
    private List<TreeNode> children;
    public TreeNode(int value)
    {
        if (value == null)
        {
            throw new ArgumentException("cannot inser null value!");
        }
        this.value = value;
        this.children = new List<TreeNode>();
    } 
    public int Value
    {
        get{return this.value;}
        set{this.value = value;}
    }
    public int ChildrenCount
    {
        get{return this.children.Count;}
    }
    public void AddChild(TreeNode child)
    {  
        if (child == null)
        {
            throw new ArgumentException("cannot insert null value!");
        }
        if (child.hasParent)
        {
            throw new ArgumentException("this node already has parent!");
        }
        child.hasParent = true;
        this.children.Add(child);
    }
    public TreeNode GetChild(int index)
    {
        return this.children[index];
    }
}
public class Tree
{
    private TreeNode root;
    public Tree (int value)
    {
        if(value == null)
        {
            throw new ArgumentException("Cannot inset null value!");
        }
        this.root = new TreeNode(value);
    }
    public Tree (int value, params Tree[] children):this(value)
    {
        foreach (Tree child in children)
        {
            this.root.AddChild(child.root);
        }
    }
    public TreeNode Root
    {
        get{return this.root;}
    }
    private void PrintDFS(TreeNode root, string spaces)
    {
        if(this.root == null)
        {
            return;
        }
        Console.WriteLine(spaces + root.Value);
        TreeNode child = null;
        for(int i = 0; i < root.ChildrenCount; i++)
        {
            child = root.GetChild(i);
            PrintDFS(child, spaces + "   ");
        }
    }
    public void TraverseDFS()
    {
        PrintDFS(this.root, string.Empty);
    }
    private int OccurenceDFS(TreeNode root, int target, int counter)
    {
        if(this.root == null)
        {
            return counter;
        }
        if(root.Value == target)
        {
            // Console.WriteLine("inside counter");
            counter++;
        }
        TreeNode child = null;
        for(int i = 0; i < root.ChildrenCount; i++)
        {
            child = root.GetChild(i);
            // Console.WriteLine("this is " + child.Value);
            // Console.WriteLine(counter);
            counter = OccurenceDFS(child, target, counter);
        }
        return counter;
    }
    public int Occurence(int target)
    {
        int counter = 0;
        int times = OccurenceDFS(this.root, target, counter);
        return times;
    }
}

public class BinaryTree<T>
{
    public T Value {get; set;}
    public BinaryTree<T> leftChild {get; private set;}
    public BinaryTree<T> rightChild{get; private set;}
    public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
    {
        this.Value = value;
        this.leftChild = leftChild;
        this.rightChild = rightChild;
    }
    public BinaryTree(T value):this(value, null, null)
    {
    }
    public void PrintInOrder()
    {
        if(this.leftChild != null)
        {
            this.leftChild.PrintInOrder();
        }
        Console.Write(this.Value + " ");
        if(this.rightChild != null)
        {
            this.rightChild.PrintInOrder();
        }
    }
}
public class Graph
{
    private List<int>[] childNodes;
    public Graph(int size)
    {
        this.childNodes = new List<int>[size];
        for(int i = 0; i < size; i++)
        {
            childNodes[i] = new List<int>();
        }
    }
    public Graph(List<int>[] childNodes)
    {
        this.childNodes = childNodes;
    }
    public int Size
    {
        get{return this.childNodes.Length;}
    }
    public void AddEdge(int u, int v)
    {
        childNodes[u].Add(v);
    }
    public void RemoveEdge(int u, int v)
    {
        childNodes[u].Remove(v);
    }
    public bool HasEdge(int u, int v)
    {
        bool hasEdge = childNodes[u].Contains(v);
        return hasEdge;
    }
    public List<int> GetSuccessors(int v)
    {
        return childNodes[v];
    }
}