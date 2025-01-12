class Q3
{
    static void ans3()
    {
        Console.Write("Please enter the company name: ");
        string company = Console.ReadLine();
        Console.Write("Please enter the company address: ");
        string companyAdd = Console.ReadLine();
        Console.Write("Please enter the company phone: ");
        int companyPh = int.Parse(Console.ReadLine());
        Console.Write("Please enter the company fax no: ");
        int companyFx = int.Parse(Console.ReadLine());
        Console.Write("Please enter the company web: ");
        string companyWb = Console.ReadLine();
        Console.Write("Please enter the manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter the manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Please enter the manager phone no: ");
        int manPh = int.Parse(Console.ReadLine());

        Console.WriteLine("The {0} company is located at {1}. " +
            "The phone no and fax no as follow: {2} and {3}. \n" +
            "Website is {4} and manager is {5} {6}. \n" +
            "Phone no is {7}.", company, companyAdd, companyPh, companyFx,
            companyWb, firstName, lastName, manPh);
        

    }
}