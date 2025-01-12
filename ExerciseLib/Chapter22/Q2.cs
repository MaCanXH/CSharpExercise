class Q2
{
    static void Main()
    {
        List<int> list = new List<int>() {20, 1, 4, 8, 9, 44};
        Console.WriteLine(list.Min<int>());
        Console.WriteLine(list.Max<int>());
    }
}

public static class IEnumerableExtensions
{
    public static T Min<T> (this IEnumerable<T> elements) where T : IComparable<T>
    {
        T minValue = elements.First<T>();

        foreach (T item in elements)
        {
            if(item.CompareTo(minValue) < 0)
            {
                minValue = item;
            }
        }
        return minValue;
    }
    public static T Max<T> (this IEnumerable<T> elements) where T : IComparable<T>
    {
        T maxValue = elements.First<T>();

        foreach (T item in elements)
        {
            if(item.CompareTo(maxValue) > 0)
            {
                maxValue = item;
            }
        }
        return maxValue;
    }
}