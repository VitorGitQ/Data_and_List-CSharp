using ModelPerson;
using ModelCourse;
using System.Security.Cryptography;


try // If occurred a wrong, your program doesn't stop and takes care of that error
{

    string[] lines = File.ReadAllLines("Folders/File_Read.txt");

    foreach(string line in lines)
    {
        Console.WriteLine(line);
    }

} catch(Exception ex)
{
    Console.WriteLine($"A generic exception occurred: {ex.Message}");
}


Console.WriteLine($"IT GOT HERE!!!");


















// Person p1 = new Person(name: "Vitor", middleName: "Queiroz Nunes");
// Person p2 = new Person(name: "Jack", middleName: "Madrigal");


// Course English = new Course();
// English.Name = "English";
// English.Students = new List<Person>();

// English.AddStudent(p1);
// English.AddStudent(p2);
// English.ListStudents();
