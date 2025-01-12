using System.Diagnostics.Contracts;
using System.Text;

class Q6
{
    static string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
    static void ans()
    {
        Console.WriteLine(text);
        Console.WriteLine(FindTag(text));
    }

    static string FindTag(string text)
    {
        int index = text.IndexOf("<upcase>");
        int lastIndex = text.IndexOf("</upcase>");
        string temp = null;
        StringBuilder txt = new StringBuilder(text);
        while (index != -1)
        {
            int length = lastIndex - 1 - (index + 7);
            temp = text.Substring(index + 8, length);
            txt = UpperCase(txt, temp);
            index = text.IndexOf("<upcase>", index + 1);
            lastIndex = text.IndexOf("</upcase>", lastIndex + 1);
        }
        return txt.ToString();
    }
    static StringBuilder UpperCase(StringBuilder txt, string temp)
    {
        return txt.Replace("<upcase>" + temp + "</upcase>", temp.ToUpper());
    }
}
