﻿using ModelPerson;
using ModelCourse;
using System.Security.Cryptography;
using PMC;




//  DECONSTRUCT

Person p1 = new Person("Vitor", "Queiroz");

(string name, string middleName) = p1;
Console.WriteLine($"{name} {middleName}");




// TUPLAS

(int Id, string Name, string MiddleName, decimal Height) tupla = (2, "Vitor", "Queiroz", 10.5M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Name: {tupla.Name}");
Console.WriteLine($"Middle Name: {tupla.MiddleName}");
Console.WriteLine($"height: {tupla.Height}");


// SECOND TUPLAS

ReadFolder file = new ReadFolder();

var (sucesse, lines, _) = file.ReadingFile("Folders/FileRead.txt");

if (sucesse)
{
    //Console.WriteLine("Amount Lines of File:" + amountLines);
    foreach(string line in lines)
    {
        Console.WriteLine(line);
    }
}
else
{
    Console.WriteLine("Unable read the file!!!");
}

















// //  DICTIONARYS

// Dictionary<string, string> states = new Dictionary<string, string>
// ();

// states.Add("BA", "Bahia");
// states.Add("SP", "São Paulo");
// states.Add("MG", "Minas Gerais");

// foreach(KeyValuePair<string, string> item in states)
// {
//     Console.WriteLine($"Key:{item.Key}  Value:{item.Value}");
// }

// Console.WriteLine($"-------------");

// states.Remove("Ba");
// states["SP"] = "São Paulo - New";

// foreach(KeyValuePair<string, string> item in states)
// {
//     Console.WriteLine($"Key:{item.Key}  Value:{item.Value}");
// }

// Console.WriteLine($"-----------------------");

// string key = "RS";
// string value = "Rio Grande do Sul";
// Console.WriteLine($"Cheking Element {key}");

// if (states.ContainsKey(key)) 
// {
//     Console.WriteLine($"Value already exist: {key}");
// }
// else
// {
//     Console.WriteLine($"Value don't exist, It's safe add the key: {key}");
// }

// Console.WriteLine($"-----------------------");
// Console.WriteLine("Adding new Key and Value");
// states.Add(key, value );

// foreach(KeyValuePair<string, string> item in states)
// {
//     Console.WriteLine($"Key:{item.Key}  Value:{item.Value}");
// }


















// // STACK

// Console.WriteLine("-----Stack-----");

// Stack<int> stack = new Stack<int>();

// stack.Push(1);
// stack.Push(4);
// stack.Push(3);
// stack.Push(2);

// foreach(int item in stack)
// {
//     Console.WriteLine(item);
// }

// stack.Pop();

// Console.WriteLine("----------");
// foreach(int item in stack)
// {
//     Console.WriteLine(item);
// }



// // QUEUE
// Console.WriteLine("-----Queue-----");

// Queue<int> queue = new Queue<int>();

// queue.Enqueue(1);
// queue.Enqueue(4);
// queue.Enqueue(3);
// queue.Enqueue(2);

// foreach(int item in queue)
// {
//     Console.WriteLine(item);
// }

// queue.Dequeue();

// Console.WriteLine("----------");
// foreach(int item in queue)
// {
//     Console.WriteLine(item);
// }

// new ExampleException().Method1();






















// //EXCEPTIONS

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





















// // Person p1 = new Person(name: "Vitor", middleName: "Queiroz Nunes");
// // Person p2 = new Person(name: "Jack", middleName: "Madrigal");


// // Course English = new Course();
// // English.Name = "English";
// // English.Students = new List<Person>();

// // English.AddStudent(p1);
// // English.AddStudent(p2);
// // English.ListStudents();
