
//Inheritance is a fundamental object-oriented programming (OOP) concept that allows a class (known as a derived or subclass) to inherit characteristics (methods and properties) from another class (known as a base or superclass).

//Here are some key points about inheritance:
//Relationship: It establishes an "is-a" relationship between classes, where the subclass is a specialized version of the superclass.
//Code Reuse: It promotes code reuse by allowing subclasses to inherit methods and properties from their superclass without re-implementing them.
//Extensibility: Subclasses can extend the behavior of the superclass by adding new methods, properties, or overriding existing ones
//Hierarchy: Inheritance supports the creation of class hierarchies, where classes can be organized into parent-child relationships.



// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Single Inheritence
// Derived class inheriting from Animal
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

//MultiLevel Inheritence
//Multi-level inheritance allows classes to inherit from other derived classes, creating a
//hierarchical relationship where each subclass inherits characteristics from its immediate
//superclass and all the way up the chain to the root base class.
// Another derived class inheriting from Dog
public class Labrador : Dog
{
    public void Swim()
    {
        Console.WriteLine("Labrador is swimming.");
    }
}

//Hierarchical inherience is found when multiple classes are are derived from same base class
public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}



//Multiple Ihneritence
//in C3 multiple inheritence  is achieved by using Interfaces
public interface IAnimal
{
    void Run();
}

// Interface 2
public interface IPet
{
    void Play();
}
public class Pitbull : Animal,IAnimal, IPet
{
   
    public void Play()
    {
        Console.WriteLine("Pit is playing.");
    }
    public void Run()
    {
        Console.WriteLine("Pit is barking.");
    }
}
class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Eat();  // Accessing method from the base class
        myDog.Bark(); // Accessing method from the derived class

        Labrador myLabrador = new Labrador();
        myLabrador.Eat();   // Accessing method from Animal (base class)
        myLabrador.Bark();  // Accessing method from Dog (immediate base class)
        myLabrador.Swim();  // Accessing method from Labrador (derived class)


        Cat myCat = new Cat();
        myCat.Eat();  // Accessing method from the base class
        myCat.Meow(); // Accessing method from the derived class


        Pitbull pit = new Pitbull();
        pit.Eat();  // Method from Animal class
        pit.Play(); // Method from IPet interface
        pit.Run(); //Method from Animal interface
    }
}
