public class Course
{
    public string Name;
    public int MaxSeats;
    public List<Student> Students = new List<Student>();

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public void Enroll(Student student)
    {
        if (Students.Contains(student))
        {
            return;
        }

        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine("Kursen är full");
            return;
        }

        Students.Add(student);

        if (!student.Courses.Contains(this))
        {
            student.Courses.Add(this);
        }
    }

    public void Remove(Student student)
    {
        if (!Students.Contains(student))
        {
            return;
        }

        Students.Remove(student);

        if (student.Courses.Contains(this))
        {
            student.Courses.Remove(this);
        }
    }

    public void RollCall()
    {
        Console.WriteLine("Studerande i " + Name + ":");
        foreach (Student s in Students)
        {
            Console.WriteLine("- " + s);
        }
    }

    public override string ToString()
    {
        return Name + " (" + Students.Count + "/" + MaxSeats + " platser)";
    }
}