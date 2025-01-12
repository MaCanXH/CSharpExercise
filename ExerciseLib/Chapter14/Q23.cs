using System.Reflection.Metadata;

class Q23toQ24
{
	static void Main()
	{
		GenericList<int> k = new GenericList<int>(5);

        k.Add(0);
        k.Add(1);
        k.Add(2);
        k.Add(3);
        k.Insert(2, 4);
        k.Insert(2, 4);
        k.Insert(2, 4);
        k.Insert(2, 4);
        k.Insert(2, 4);


        Console.WriteLine(k.Index(1));

	}
}

class GenericList<T>
{
	private T[] Elist;
	private int counter = 0;
	private int len;

	public GenericList(int n)
	{
		this.Elist = new T[n];
		this.len = n;
	}

	public void Add(T ele)
	{
		this.Elist[counter] = ele;
        this.counter++;
        if(this.counter == this.len - 1)
        {
            this.Resize();
        }
	}

	public T Index(int n)
	{
		return this.Elist[n];
	}

	public void Remove(int n)
	{
		for(int i = n; i < this.len - 1; i++)
		{
			this.Elist[i] = this.Elist[i + 1];
		}
		this.Elist[this.len - 1] = default(T);
		this.counter--;
	}

	public void Insert(int idx, T k)
	{
		for(int i = this.len - 1; i > idx; i--)
		{
			this.Elist[i] = this.Elist[i - 1];
		}
		this.Elist[idx] = k;
		this.counter++;
		if(this.counter == this.len - 1)
		{
			this.Resize();
		}
	}

	public void Clear()
	{
		for(int i = 0; i <= len - 1; i++)
		{
			this.Elist[i] = default(T);
        }
	}

	// public int Search(T k)
	// {
	// 	for(int i = 0; i <= lastIdx; i++)
	// 	{
	// 		if(k == this.Elist[i])
	// 		{
	// 			return i;
	// 		}
	// 	}
	// 	return -1;
	// }

    private void Resize()
    {
        T[] temp = new T[this.len + 5];

        for (int i = 0; i <= this.len - 1; i++)
        {
            temp[i] = this.Elist[i];
        }
        this.len += 5;
        this.Elist = temp;
    }
}
