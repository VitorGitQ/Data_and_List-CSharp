namespace ModelPerson;

public class Person
{
    public Person()
    {

    }

    public Person(string name, string middleName)
    {
        Name = name;
        MiddleName = middleName;
    }

    private string _name; // Just Private property/field can access (We call encapsulation)

    private int _age; // Field is just a variable

    public string Name // Just Private property/field can access
    {
         get => _name;
         

         set
         {
            if (value == "")
            {
                throw new ArgumentException("The name can't be empty");
            }

            _name = value;
         }
    }


    public string MiddleName{ get; set; }


    public string FullName => $"{Name} {MiddleName}".ToUpper(); // Method (Method is like an action)

    public int Age // Property have get or set or both
    { 
        get => _age;

        set // Method 
        {
            if (value < 0) 
            {
                throw new ArgumentException("The Age can't be less than Zero");
            }

            _age = value;
        }
        
    }

    public void Introduce() // Method (Method is like an action)
    {
        Console.WriteLine($"Name:{FullName} and Age:{Age}");
    }

}
