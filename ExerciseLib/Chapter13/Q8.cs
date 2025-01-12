using System.Text;
class Ch13Q8
{
	static void ans()
    {
        Console.Write("Enter a text: ");
        string n = Console.ReadLine();

        Console.WriteLine("The unicode of the text is: ");
        Console.WriteLine(ToUnicode(n));
        
    }
    static string ToUnicode(string s)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            sb.Append("\\u");
            sb.Append(String.Format("{0:x4}", (int)c));
        }
        return sb.ToString();
    }
}
