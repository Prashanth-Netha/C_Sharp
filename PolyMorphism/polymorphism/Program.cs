//Polymorphism is a concept in programming that allows objects of different types to be treated as objects of a common base type.
//It means "many forms" and allows methods to do different things based on the object it is acting upon.
//This makes your code more flexible and reusable.

//Types of Polymorphism

using System;

// Base class
public class Animal
{
    // Virtual method to allow overriding in derived classes
    public virtual void Speak()
    {
        Console.WriteLine("Animal is making a sound.");
    }

    // Non-virtual method to demonstrate method hiding
    public void Move()
    {
        Console.WriteLine("Animal is moving.");
    }

    // Method overloading: same method name with different parameters
    //Method Overloading:

    //This allows a class to have multiple methods with the same name but different parameters.
    //Example: If a class has multiple Eat methods with different parameters (e.g., Eat(), Eat(string food), Eat(int amount)), the appropriate method is called based on the arguments provided.

    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"Animal is eating {food}.");
    }
}

// Derived class
public class Dog : Animal
{
    // Overriding the virtual method from the base class
    //Method Overriding:

    //This allows a subclass to provide a specific implementation of a method that is already defined in its superclass.
    //Example: If you have a base class Animal with a method Speak(), and a derived class Dog that overrides Speak() to bark, calling Speak() on a Dog object will result in a bark.

    public override void Speak()
    {
        Console.WriteLine("Dog is barking.");
    }

    // Hiding the non-virtual method from the base class
    //Method Hiding:

    //This occurs when a subclass defines a method with the same name as one in its superclass but does not override it (usually not marked as virtual in the base class).
    //Example: If the base class Animal has a method Move(), and the derived class Dog also has a method Move(), the method called depends on the reference type.

    public new void Move()
    {
        Console.WriteLine("Dog is running.");
    }

    // Overloading the Eat method from the base class

    public void Eat(int amount)
    {
        Console.WriteLine($"Dog is eating {amount} units of food.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Dog myDog = new Dog();

        // Method overriding
        myAnimal.Speak(); // Output: Animal is making a sound.
        myDog.Speak();    // Output: Dog is barking.

        // Method hiding
        myAnimal.Move();  // Output: Animal is moving.
        myDog.Move();     // Output: Dog is running.

        // Method overloading
        myAnimal.Eat();           // Output: Animal is eating.
        myAnimal.Eat("grass");    // Output: Animal is eating grass.
        myDog.Eat();              // Output: Animal is eating.
        myDog.Eat("meat");        // Output: Animal is eating meat.
        myDog.Eat(3);             // Output: Dog is eating 3 units of food.

        // Demonstrating polymorphism
        Animal myPolymorphicDog = new Dog();
        myPolymorphicDog.Speak(); // Output: Dog is barking.
        myPolymorphicDog.Move();  // Output: Animal is moving.
    }
}

//1.Direct Instantiation
//You create an instance of a derived class and assign it to a variable of the same derived type.
//Dog myDog = new Dog();
//myDog.Speak(); // Dog-specific method


//2.Using Base Class Reference
//You create an instance of a derived class but assign it to a variable of the base class type.
//This is the most common way to leverage polymorphism.


//Animal myAnimal = new Dog();
//myAnimal.Speak(); // Calls Dog's Speak method if overridden