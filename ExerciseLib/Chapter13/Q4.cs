using System.Data;

class Q4
{
    static void ans()
    {
        string arr = "coco\\max\\chan\\hello";

        Console.WriteLine(arr);

        string[] narr = arr.Split('\\');

        for (int i = 0; i < narr.Length; i++)
        {
            Console.Write(narr[i] + " ");
        }
    }
}

//the answer is two.