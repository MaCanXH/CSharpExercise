using System.Text;

class Q1
{
    static void ans()
    {
        StringBuilder words = new StringBuilder();
        words.Append("this ");
        words.Append("is ");
        words.Append("just ");
        words.Append("a ");
        words.Append("test.");
        Console.WriteLine(words);
        
        Console.WriteLine(words.Substring(2, 5));
    }
    
}
public static class StringBuilderExtension
{
    public static string Substring(this StringBuilder str, int index, int length)
    {
        string input = str.ToString();
        string result = input.Substring(index, length);
        return result;
    }
}