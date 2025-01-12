// Q3. It is given a text file students.txt containing information about 
// students and their specialty in the following format:
// Steven Davis | Computer Science
// Joseph Johnson | Software Engeneering
// Helen Mitchell | Public Relations
// Nicolas Carter | Computer Science
// Susan Green | Public Relations
// William Johnson | Software Engeneering

// Using SortedDictionary<K,T> print on the console the specialties in 
// an alphabetical order and for each of them print the names of the 
// students, firstly sorted by family name and secondly – by first name, 
// as shown:
// Computer Sciences: Nicolas Carter, Steven Davis
// Public Relations: Susan Green, Helen Mitchell
// Software Engeneering: Joseph Johnson, William Johnson

using System.Data.SqlTypes;

class Q3
{
    static void ans()
    {
        Dictionary<string, List<Student>> courses = new Dictionary<string, List<Student>>();
        StreamReader read = new StreamReader("Q3.txt");
        using(read)
        {
            string line = read.ReadLine();
            while(line != null)
            {
                string[] entry = line.Split(new char[]{'|'});
                string[] name = entry[0].Split(" ");
                string firstName = name[0].Trim();
                string lastName = name[1].Trim();
                string course = entry[1].Trim();

                List<Student> students;
                if(!courses.TryGetValue(course, out students))
                {
                    students = new List<Student>();
                    courses.Add(course, students);
                }
                Student student = new Student(firstName, lastName);
                students.Add(student);
                line = read.ReadLine();
            }
        }
        PrintTable(courses);
    }
    static void PrintTable(Dictionary<string, List<Student>> courses)
    {
        foreach(string course in courses.Keys)
        {
            List<Student> students = courses[course];
            students.Sort();
            Console.Write("{0}: ",course);
            Console.WriteLine(String.Join(", ",students));
            // foreach(Student s in students)
            // {
            //     Console.Write(s + ", ");
            // }
        }
    }
}

public class Student : IComparable<Student>
{
    private string firstName;
    private string lastName;
    public Student (string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    public int CompareTo(Student student)
    {
        int result = lastName.CompareTo(student.lastName);
        if(result == 0)
        {
            result = firstName.CompareTo(student.firstName);
        }
        return result;
    }
    public override string ToString()
    {
        return firstName + " " + lastName;
    }
}