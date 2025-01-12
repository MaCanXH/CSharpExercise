using System.Text;
class Ch13Q16
{
	static void ans()
    {
        Console.WriteLine("Enter a text: ");
        string s = Console.ReadLine();
        Console.WriteLine("The converted version is");
        Console.WriteLine(LinkConvert(s));
    }
    static string LinkConvert(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        sb.Replace("<a href=\"", "[URL=");
        sb.Replace("\">", "]");
        sb.Replace("</a>", "[/URL]");
        return sb.ToString();
    }
}
