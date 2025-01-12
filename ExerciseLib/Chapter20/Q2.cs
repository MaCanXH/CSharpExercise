class Q2
{
    
}
class Human
{
    private string firstName;
    private string lastName;
    public Human(): this("null", "null")
    {}
    public Human(string firstName, string lastName)    
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public string FirstName
    {
        get{return this.firstName;}
    }
    public string LastName
    {
        get{return this.lastName;}
    }
}
class Student: Human
{
    private int mark;
    public Student()
    {
        
    }
}