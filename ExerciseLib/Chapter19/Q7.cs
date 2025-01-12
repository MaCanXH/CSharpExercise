// Q7. Implement the data structure PriorityQueue<T>, which offers quick 
// execution of the following operations: adding an element, extracting 
// the smallest element.

// C# code to implement Priority Queue 
// using Binary heap

using System.ComponentModel;
using System.Runtime.ExceptionServices;

class Q7
{
    static void ans()
    {
    /*              45
                /     \
            31      14
            / \     / \
            13  20   7   11
        / \
        12  7
        Create a priority queue shown in 
        example in a binary max heap form.
        Queue will be represented in the
        form of array as:
        45 31 14 13 20 7 11 12 7 */

        PriorityQueue<int> NewQ = new PriorityQueue<int>();
        NewQ.insert(45);
        NewQ.insert(20);
        NewQ.insert(14);
        NewQ.insert(12);
        NewQ.insert(31);
        NewQ.insert(7);
        NewQ.insert(11);
        NewQ.insert(13);
        NewQ.insert(7);

        Console.Write("Priority Queue: ");
        NewQ.PrintQueue();
        Console.WriteLine();
        Console.WriteLine("Node with maximun priority: " + NewQ.extractMax());
        Console.Write("Priority queue after extracting maxi: ");
        NewQ.PrintQueue();
        Console.WriteLine();
        Console.Write("Priority queue after priority change: ");
        NewQ.changePriority(2, 49);
        NewQ.PrintQueue();
        Console.WriteLine();
        Console.Write("Priority queue after removing the element: ");
        NewQ.Remove(3);
        NewQ.PrintQueue();
        // PriorityQueue<char> NewQ = new PriorityQueue<char>();
        // NewQ.insert('i');
        // NewQ.insert('s');
        // NewQ.insert('a');
        // NewQ.insert('p');
        // NewQ.insert('q');
        // NewQ.insert('j');
        // NewQ.insert('a');
        // NewQ.insert('b');
        // NewQ.insert('k');

        // Console.Write("Priority Queue: ");
        // NewQ.PrintQueue();
        // Console.WriteLine();
        // Console.WriteLine("Node with maximun priority: " + NewQ.extractMax());
        // Console.Write("Priority queue after extracting maxi: ");
        // NewQ.PrintQueue();
        // Console.WriteLine();
        // Console.Write("Priority queue after priority change: ");
        // NewQ.changePriority(2, '8');
        // NewQ.PrintQueue();
        // Console.WriteLine();
        // Console.Write("Priority queue after removing the element: ");
        // NewQ.Remove(3);
        // NewQ.PrintQueue();
    }

}
class PriorityQueue<T> where T: IComparable<T> //implement IComparable in the class
{
    private T[] queue; //queue array of T
    private int size = -1; //default size
    /// <summary>
    /// Size property to return the size
    /// </summary>
    public int Size
    {
        get{return this.size;}
    }
    /// <summary>
    /// empty constructor, default size 10
    /// </summary>
    public PriorityQueue()
    {
        this.queue = new T[10];
    } 
    /// <summary>
    /// constructor, user define size
    /// </summary>
    /// <param name="n">input queue size</param>
    public PriorityQueue(int n)
    {
        this.queue = new T[n];
    }
    /// <summary>
    /// helper method to return the parent node index
    /// </summary>
    /// <param name="i">input node index</param>
    /// <returns>parent index of the node</returns>
    private int parent(int i)
    {
        return ((i - 1)/2);
    }
    /// <summary>
    /// helper method to return the left child node index
    /// </summary>
    /// <param name="i">input node index</param>
    /// <returns>left child index of the node</returns>
    private int leftChild(int i)
    {
        return ((2 * i) + 1);
    }
    /// <summary>
    /// helper method to return the right child node index
    /// </summary>
    /// <param name="i">input node index</param>
    /// <returns>right child node index</returns>
    private int rightChild(int i)
    {
        return ((2 * i) + 2);
    }
    /// <summary>
    /// helper method to shift up the input index node unitl smaller than its parent
    /// </summary>
    /// <param name="i">nput node index</param>
    private void shiftUp(int i)
    {
        while (i > 0 && queue[parent(i)].CompareTo(queue[i]) < 0)
        {
            swap(parent(i), i);
            i = parent(i);
        }
    }
    /// <summary>
    /// helper method to recurssively shift down the input index node until bigger than its child
    /// </summary>
    /// <param name="i">input node index</param>
    private void shiftDown(int i)
    {
        int maxIdx = i;
        int l = leftChild(i);
        if(l <= size && queue[l].CompareTo(queue[maxIdx]) > 0)
        {
           maxIdx = l;
        }
        int r = rightChild(i);
        if(r <= size && queue[r].CompareTo(queue[maxIdx]) > 0)
        {
            maxIdx = r;
        }
        if(i != maxIdx)
        {
            swap(i, maxIdx);
            shiftDown(maxIdx);
        }
    }
    /// <summary>
    /// method to insert T element into the queue
    /// </summary>
    /// <param name="p">input node value</param>
    public void insert(T p)
    {
        this.size++;
        queue[size] = p;
        shiftUp(size);
    }
    /// <summary>
    /// method to return the highest priority node (root) and remove the node
    /// </summary>
    /// <returns>highest priorit node</returns>
    public T extractMax()
    {
        T result = queue[0];
        queue[0] = queue[size];
        size--;
        shiftDown(0);
        return result;
    }
    /// <summary>
    /// method to change the priority of the input node
    /// </summary>
    /// <param name="i">input node index</param>
    /// <param name="p">input node value</param>
    public void changePriority(int i, T p)
    {
        T oldP = queue[i];
        queue[i] = p;
        if(queue[i].CompareTo(oldP) > 0)
        {
            shiftUp(i);
        }
        else if(queue[i].CompareTo(oldP) < 0)
        {
            shiftDown(i);
        }
    }
    /// <summary>
    /// method to get the highest priority node(root)
    /// </summary>
    /// <returns>root of the binary heap</returns>
    public T getMax()
    {
        return this.queue[0];
    }
    public void Remove(int i)
    {
        queue[i] = getMax();
        shiftUp(i);
        extractMax();
    }
    /// <summary>
    /// method to print the binary heap
    /// </summary>
    public void PrintQueue()
    {
        for(int i = 0; i <= this.size; i++)
        {
            Console.Write(queue[i] + " ");
        }
    }
    /// <summary>
    /// helper method to swap the input node
    /// </summary>
    /// <param name="i">first input node index</param>
    /// <param name="j">second input node index</param>
    private void swap(int i, int j)
    {
        T temp = queue[i];
        queue[i] = queue[j];
        queue[j] = temp;
    }
}