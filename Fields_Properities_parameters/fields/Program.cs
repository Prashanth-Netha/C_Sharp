using System;

public class Person
{
    // Fields
    //Fields (name and age): Store the internal state of the Person class.
    private string name;
    private int age;

    // Properties
    //Properties (Name and Age): Provide controlled access to the fields,
    //allowing validation or additional logic if needed.
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Constructor with parameters
    //Constructor (Person(string name, int age)):
    //Initializes the object with initial values provided as parameters.
    public Person(string name, int age)
    {
        Name = name; // Using property setter
        Age = age;   // Using property setter
    }

    // Method using parameters
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    // Method with parameters
    //Parameters: Define data expected by methods or constructors,
    //enabling methods to perform actions using specific values provided at runtime.
    public void UpdateInfo(string newName, int newAge)
    {
        Name = newName; // Using property setter
        Age = newAge;   // Using property setter
    }
}

public class Program
{
    public static void Main()
    {
        // Creating an instance of Person with constructor parameters
        Person person = new Person("Alice", 30);

        // Displaying initial information using method
        person.DisplayInfo(); // Output: Name: Alice, Age: 30

        // Updating information using method with parameters
        person.UpdateInfo("Bob", 25);

        // Displaying updated information using method
        person.DisplayInfo(); // Output: Name: Bob, Age: 25
    }
}
