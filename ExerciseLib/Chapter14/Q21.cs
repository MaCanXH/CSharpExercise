class Q20toQ21
{
	static void ans()
	{
		Book book1 = new Book("The first", "Max", "Goodbook Publish", "10/15/2020", "192848192");
		Book book2 = new Book("The one", "Ken", "Goodbook Publish", "8/1/2002", "192844522");
		Book book3 = new Book("The man", "Josh", "Goodbook Publish", "1/26/1956", "192543692");
		Book book4 = new Book("BO Boy", "David", "Goodbook Publish", "12/14/2010", "193287892");
		Book book5 = new Book("Nice Day", "Max", "Goodbook Publish", "23/8/2019", "366848192");

		Library.AddBook(book1);
		Library.AddBook(book2);
		Library.AddBook(book3);
		Library.AddBook(book4);
		Library.AddBook(book5);

		//Library.BookList();
		
		//Library.RemoveBook(4);

		//Console.WriteLine("The New Book list is ");
		//Console.WriteLine();
		//Library.BookList();

		Library.SearchAuthor("Max");
	}
}

class Book
{
	private string title;
	private string author;
	private string publisher;
	private string rdate;
	private string ISBN;

	public Book():this(null){}
	public Book(string title):this(title, null){}
	public Book(string title, string author):this(title, author, null){}
	public Book(string title, string author, string publisher):this(title, author, publisher, null){}
	public Book(string title, string author, string publisher, string rdate):this(title, author, publisher, rdate, null){}
	public Book(string title, string author, string publisher, string rdate, string ISBN)
	{
		this.title = title;
		this.author = author;
		this.publisher = publisher;
		this.rdate = rdate;
		this.ISBN = ISBN;
	}
	public string Author
	{
		get{return this.author;}	
	}
	public void bookInfo()
	{
		Console.WriteLine("Book title: " + this.title);
		Console.WriteLine("Author: " + this.author);
		Console.WriteLine("Publisher: " + this.publisher);
		Console.WriteLine("Release date: " + this.rdate);
		Console.WriteLine("ISBN number: " + ISBN);
	}
}

class Library
{
	private static List<Book> shelf = new List<Book>();
	
	public static void AddBook(Book s)
	{
		shelf.Add(s);
	}
	
	public static void RemoveBook(int n)
	{
		shelf.RemoveAt(n - 1);
	}

	public static void BookList()
	{
		int c = 1;

		foreach(Book s in shelf)
		{
			Console.WriteLine("Book number: " + c);
			s.bookInfo();
			Console.WriteLine("-----------------");
			c++;
		}
	}

	public static void SearchAuthor(string name)
	{
		int c = 0;
		foreach(Book s in shelf)
		{
			if(s.Author == name)
			{
				s.bookInfo();
				Console.WriteLine("-----------------");
				c++;
			}
		}
		
	}
}
