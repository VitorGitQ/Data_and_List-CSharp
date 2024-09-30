using ModelPerson;
namespace ModelCourse;

public class Course
{

    public string Name { get; set; }
    public List<Person> Students { get; set; }

    public void AddStudent(Person student) // Method (Method is like an action)
    {
        Students.Add(student);
    }


    public int ReturnStudentsList() 
    {
        int langth = Students.Count;
        return langth;
    }

    public void RemoveStudents(Person student)
    {
        Students.Remove(student);
    }

    public void ListStudents()
    {
        Console.WriteLine($"Students of {Name} course:");


        for (int count = 0; count < Students.Count; count++)
        {
            string text = $"N°{count + 1} - {Students[count].FullName}";
            Console.WriteLine(text);
        }
    }
}


