using System;

public class Calculator
{
    // Method with regular parameters and a return type
    public int Add(int a, int b)
    {
        return a + b;
    }


    // Overloaded method to add three integers
/*
 * Definition: Method overloading is defining multiple methods 
 * with the same name but with different parameter lists in the same class.
 * */
public int Add(int a, int b, int c)
{
    return a + b + c;
}

// Overloaded method to add two doubles
public double Add(double a, double b)
{
    return a + b;
}

// Overloaded method to add three doubles
public double Add(double a, double b, double c)
{
    return a + b + c;
}

// Overloaded method to add two strings
public string Add(string a, string b)
{
    return a + b;
}
// Method using ref parameters
public void Square(ref int number)
{
    number *= number;
}

// Method using out parameters
public void Divide(int dividend, int divisor, out int quotient, out int remainder)
{
    quotient = dividend / divisor;
    remainder = dividend % divisor;
}
}

/*
 * Method overriding in C# is a feature of object-oriented
 * programming that allows a subclass to provide a specific
 * implementation of a method that is already defined in its superclass.
 *This is particularly useful for runtime polymorphism, where the method
 *to be invoked is determined at runtime based on the actual object type.
 * */

public class Animal
{
    // Virtual method in the base class
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    // Override method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Animal
{
    // Override method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}
public class Program
{
public static void Main()
{
    Calculator calculator = new Calculator();

    // Using a method with regular parameters and return type
    int sum = calculator.Add(5, 3);
    Console.WriteLine("Sum: " + sum); // Output: Sum: 8



    // Using a method with ref parameter
    //The code works on the sent parameter refernce
    int number = 4;
    calculator.Square(ref number);
    Console.WriteLine("Squared Number: " + number); // Output: Squared Number: 16

    // Using a method with out parameters
    //THe out parameter is used when we need to get multiple return parameters from a single method
    int dividend = 10;
    int divisor = 3;
    calculator.Divide(dividend, divisor, out int quotient, out int remainder);
    Console.WriteLine("Quotient: " + quotient);   // Output: Quotient: 3
    Console.WriteLine("Remainder: " + remainder); // Output: Remainder: 1

    int sum1 = calculator.Add(5, 3);                 // Calls Add(int, int)
    int sum2 = calculator.Add(5, 3, 2);              // Calls Add(int, int, int)
    double sum3 = calculator.Add(5.5, 3.3);          // Calls Add(double, double)
    double sum4 = calculator.Add(5.5, 3.3, 2.2);     // Calls Add(double, double, double)
    string concatenated = calculator.Add("Hello, ", "World!"); // Calls Add(string, string)

    Console.WriteLine("Sum1: " + sum1);          // Output: Sum1: 8
    Console.WriteLine("Sum2: " + sum2);          // Output: Sum2: 10
    Console.WriteLine("Sum3: " + sum3);          // Output: Sum3: 8.8
    Console.WriteLine("Sum4: " + sum4);          // Output: Sum4: 11.0
    Console.WriteLine("Concatenated: " + concatenated); // Output: Concatenated: Hello, World!

        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        // Call the Speak method on each instance
        myAnimal.Speak(); // Output: The animal makes a sound.
        myDog.Speak();    // Output: The dog barks.
        myCat.Speak();    // Output: The cat meows.
    }
}

//Differnt types of return used in Methods
/*
 * using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Example
{
    // Primitive types
    public int GetInt()
    {
        return 42;
    }

    public double GetDouble()
    {
        return 3.14;
    }

    public char GetChar()
    {
        return 'A';
    }

    public bool GetBool()
    {
        return true;
    }

    // String
    public string GetString()
    {
        return "Hello, World!";
    }

    // Complex types (Classes and Structs)
    public Person GetPerson()
    {
        return new Person { Name = "John Doe", Age = 30 };
    }

    public Point GetPoint()
    {
        return new Point { X = 10, Y = 20 };
    }

    // Collections
    public int[] GetIntArray()
    {
        return new int[] { 1, 2, 3, 4, 5 };
    }

    public List<string> GetStringList()
    {
        return new List<string> { "Apple", "Banana", "Cherry" };
    }

    public Dictionary<string, int> GetDictionary()
    {
        return new Dictionary<string, int>
        {
            { "One", 1 },
            { "Two", 2 },
            { "Three", 3 }
        };
    }

    // Nullable types
    public int? GetNullableInt()
    {
        return null; // or return some int value
    }

    // Tuples
    public (int, string) GetTuple()
    {
        return (42, "Hello");
    }

    public (int Sum, int Product) Calculate(int a, int b)
    {
        return (a + b, a * b);
    }

    // Enumerations
    public Color GetColor()
    {
        return Color.Green;
    }

    // Interfaces
    public IAnimal GetAnimal()
    {
        return new Dog();
    }

    // Void
    public void PrintMessage()
    {
        Console.WriteLine("Hello, World!");
    }

    // Asynchronous return types
    public async Task DoSomethingAsync()
    {
        await Task.Delay(1000);
    }

    public async Task<int> GetIntAsync()
    {
        await Task.Delay(1000);
        return 42;
    }

    public async ValueTask<int> GetIntValueTaskAsync()
    {
        await Task.Delay(1000);
        return 42;
    }
}

// Supporting classes, structs, enums, and interfaces
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

public enum Color
{
    Red,
    Green,
    Blue
}

public interface IAnimal
{
    void Speak();
}

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof");
    }
}

public class Program
{
    public static async Task Main()
    {
        Example example = new Example();

        // Primitive types
        Console.WriteLine("Int: " + example.GetInt());
        Console.WriteLine("Double: " + example.GetDouble());
        Console.WriteLine("Char: " + example.GetChar());
        Console.WriteLine("Bool: " + example.GetBool());

        // String
        Console.WriteLine("String: " + example.GetString());

        // Complex types (Classes and Structs)
        Person person = example.GetPerson();
        Console.WriteLine("Person: " + person.Name + ", Age: " + person.Age);

        Point point = example.GetPoint();
        Console.WriteLine("Point: X=" + point.X + ", Y=" + point.Y);

        // Collections
        int[] intArray = example.GetIntArray();
        Console.WriteLine("IntArray: " + string.Join(", ", intArray));

        List<string> fruits = example.GetStringList();
        Console.WriteLine("Fruits: " + string.Join(", ", fruits));

        Dictionary<string, int> dictionary = example.GetDictionary();
        foreach (var kvp in dictionary)
        {
            Console.WriteLine("Dictionary: Key=" + kvp.Key + ", Value=" + kvp.Value);
        }

        // Nullable types
        int? nullableInt = example.GetNullableInt();
        Console.WriteLine("Nullable Int: " + (nullableInt.HasValue ? nullableInt.Value.ToString() : "null"));

        // Tuples
        var tuple = example.GetTuple();
        Console.WriteLine("Tuple: " + tuple.Item1 + ", " + tuple.Item2);

        var calculated = example.Calculate(3, 4);
        Console.WriteLine("Calculated: Sum=" + calculated.Sum + ", Product=" + calculated.Product);

        // Enumerations
        Color color = example.GetColor();
        Console.WriteLine("Color: " + color);

        // Interfaces
        IAnimal animal = example.GetAnimal();
        animal.Speak();

        // Void
        example.PrintMessage();

        // Asynchronous return types
        await example.DoSomethingAsync();
        int asyncInt = await example.GetIntAsync();
        Console.WriteLine("Async Int: " + asyncInt);

        int asyncValueTaskInt = await example.GetIntValueTaskAsync();
        Console.WriteLine("Async ValueTask Int: " + asyncValueTaskInt);
    }
}
*/