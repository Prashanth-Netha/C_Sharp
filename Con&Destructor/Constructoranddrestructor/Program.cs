using System;

public class MyClass
{
    private string name;
    private int age;

    // Default constructor
    public MyClass()
    {
        Console.WriteLine("Default constructor called");
        name = "Unknown";
        age = 0;
    }

    // Parameterized constructor
    public MyClass(string name, int age)
    {
        Console.WriteLine("Parameterized constructor called");
        this.name = name;
        this.age = age;
    }

    // Destructor (finalizer)
    ~MyClass()
    {
        // Clean up unmanaged resources here
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

public class Program
{
    public static void Main()
    {
        // Creating objects using different constructors
        MyClass obj1 = new MyClass(); // Calls default constructor
        obj1.DisplayInfo(); // Output: Name: Unknown, Age: 0

        MyClass obj2 = new MyClass("Alice", 30); // Calls parameterized constructor
        obj2.DisplayInfo(); // Output: Name: Alice, Age: 30

     
        // Objects are automatically cleaned up by the garbage collector
    }
}
