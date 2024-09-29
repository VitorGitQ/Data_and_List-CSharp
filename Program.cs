using ModelPerson;
using ModelCourse;
using System.Security.Cryptography;



Person p1 = new Person(name: "Vitor", middleName: "Queiroz Nunes");
Person p2 = new Person(name: "Jack", middleName: "Madrigal");


Course English = new Course();
English.Name = "English";
English.Students = new List<Person>();

English.AddStudent(p1);
English.AddStudent(p2);
English.ListStudents();
