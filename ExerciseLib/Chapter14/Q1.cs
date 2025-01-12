using System.Diagnostics.Contracts;
class Q1toQ7
{
    static void ans()
    {
        StudentTest.CountStudent();
    }
}
class StudentTest
{
    private static Student max;
    private static Student john;
    private static Student ken;
    static StudentTest()
    {
        max = new Student("Max", "CS50", "Computer Science", "Harvard U", "max@gmail.com", "213987719");
        john = new Student("John", "CS50", "Computer Science", "Harvard U", "john@gmail.com", "213987719");
        ken = new Student("Ken", "CS50", "Computer Science", "Harvard U", "ken@gmail.com", "213987719");
    }
    public static void CountStudent()
    {
        max.info();
        john.info();
        ken.info();
        Console.WriteLine("The number of student is " + Student.counter);
    }
}
class Student
{
    private string fullName;
    private string course;
    private string subject;
    private string university;
    private string email;
    private string phoneNo;
    public static int counter = 0;

    public Student():this(null)
    {
    }
    public Student(string fullName):this(fullName, null)
    {
    }
    public Student(string fullName, string course):this(fullName, course, null)
    {
    }
    public Student(string fullName, string course, string subject):this(fullName, course, subject, null)
    {
    }
    public Student(string fullName, string course, string subject, string university):this(fullName, course, subject, university, null)
    {
    }
    public Student(string fullName, string course, string subject, string university, string email):this(fullName, course, subject, university, email, null)
    {
    }
    public Student(string fullName, string course, string subject, string university, string email, string phoneNo)
    {
        this.fullName = fullName;
        this.course = course;
        this.subject = subject;
        this.university = university;
        this.email = email;
        this.phoneNo = phoneNo;
        counter += 1;
    }

    public string FullName
    {
        get{return this.fullName;}
    }
    public string Course
    {
        get{return this.course;}
    }
    public string Subject
    {
        get{return this.subject;}
    }
    public string University
    {
        get{return this.university;}
    }
    public string Email
    {
        get{return this.email;}
    }
    public string PhoneNo
    {
        get{return this.phoneNo;}
    }
    public void info()
    {
        Console.WriteLine("Name: " + FullName);
        Console.WriteLine("Course: " + Course);
        Console.WriteLine("Subject: " + Subject);
        Console.WriteLine("University: " + University);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Phone no: " + PhoneNo);
    }
}