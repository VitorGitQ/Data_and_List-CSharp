using ModelPerson;
using ModelCourse;
using System.Security.Cryptography;
using PMC;


// STACK

Console.WriteLine("-----Stack-----");

Stack<int> stack = new Stack<int>();

stack.Push(1);
stack.Push(4);
stack.Push(3);
stack.Push(2);

foreach(int item in stack)
{
    Console.WriteLine(item);
}

stack.Pop();

Console.WriteLine("----------");
foreach(int item in stack)
{
    Console.WriteLine(item);
}



// QUEUE
Console.WriteLine("-----Queue-----");

Queue<int> queue = new Queue<int>();

queue.Enqueue(1);
queue.Enqueue(4);
queue.Enqueue(3);
queue.Enqueue(2);

foreach(int item in queue)
{
    Console.WriteLine(item);
}

queue.Dequeue();

Console.WriteLine("----------");
foreach(int item in queue)
{
    Console.WriteLine(item);
}

// new ExampleException().Method1();




// try // If occurred a wrong, your program doesn't stop and takes care of that error
// {

//     string[] lines = File.ReadAllLines("Folders/FileRead.txt");

//     foreach(string line in lines)
//     {
//         Console.WriteLine(line);
//     }

// } 
// catch(FileNotFoundException ex) 
// {
//     Console.WriteLine($"An error occurred while reading the file. File doesn't found. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex) 
// {
//     Console.WriteLine($"An error occurred while reading the file. Directory doesn't found. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"A generic exception occurred: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine($"IT GOT HERE!!!");
// }





















// Person p1 = new Person(name: "Vitor", middleName: "Queiroz Nunes");
// Person p2 = new Person(name: "Jack", middleName: "Madrigal");


// Course English = new Course();
// English.Name = "English";
// English.Students = new List<Person>();

// English.AddStudent(p1);
// English.AddStudent(p2);
// English.ListStudents();
