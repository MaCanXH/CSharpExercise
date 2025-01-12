using System.Text.RegularExpressions;
using System.Text;
class Ch13Q26a
{
	static void ans()
{
	Console.WriteLine("Enter the html document: ");
	string doc = Console.ReadLine();

	string stgRex = @"\<(\W)*(\w)*\>";
	
	Console.WriteLine("The document without tag: ");
	Console.WriteLine(Regex.Replace(doc, stgRex, ""));
}
}

class Ch13Q26b
{
	static void ans()
{
	Console.WriteLine("Enter the html document: ");
	string doc = Console.ReadLine();

	Console.WriteLine("The document without tag: ");
Console.WriteLine(CheckTag(doc));
}

static string CheckTag(string txt)
{
	bool OpenTag = false;
	StringBuilder sb = new StringBuilder();
	for (int i = 0; i < txt.Length; i++)
{
	if (txt[i] == '<'){OpenTag = true;}
	else if (txt[i] == '>'){OpenTag = false;}

	if (OpenTag == false && txt[i] != '>')
{
	sb.Append(txt[i]);
}
}
return sb.ToString();
}
}
