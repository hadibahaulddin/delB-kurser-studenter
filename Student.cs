public class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();

    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        course.Enroll(this);
    }

    public void Leave(Course course)
    {
        course.Remove(this);
    }

    public void Schedule()
    {
        Console.WriteLine(Name + " går på:");
        foreach (Course c in Courses)
        {
            Console.WriteLine("- " + c);
        }
    }

    public override string ToString()
    {
        return Name;
    }
}