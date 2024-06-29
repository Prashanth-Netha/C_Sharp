using System;


namespace ClassExamples
{
    //A class is a blueprint for creating objects.It defines a type by 
    //    bundling data and methods that work on the data into one single
    //    unit.Here’s how you can define a simple class in C#:

    //An object is an instance of a class. When a class is defined, 
    //    no memory is allocated until an object of that class is created.Here’s 
    //    how you can create an object from the Person class:

    // 1. Concrete Class
    //              Concrete classes are the standard classes that are used to
    //create objects directly.They contain fields, properties, methods, and
    //constructors
    public class Dog
    {
        public string Name { get; set; }
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }

    // 2. Abstract Class

    //Abstract classes cannot be instantiated directly.They are meant to be inherited by 
    //    other classes. Abstract classes can contain abstract methods, which are methods
    //    without implementation that must be implemented by derived classes.


    public abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // 3. Sealed Class
    //Sealed classes cannot be inherited.This is 
    //    useful when you want to prevent other classes from deriving from your class.
    public sealed class SealedClass
    {
        public void Display()
        {
            Console.WriteLine("This is a sealed class.");
        }
    }

    // 4. Static Class
    //Static classes cannot be instantiated or inherited.
    //    All members of a static class must be static.
    //    They are often used to create utility or helper classes.
    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    // 5. Partial Class
    //Partial classes allow a class definition to be split into multiple files.
    //    This is useful for organizing code, especially in large projects. 
    //    All parts must be marked with the partial keyword.
    public partial class PartialClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
    }

    public partial class PartialClass
    {
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    // 6. Nested Class
    //A nested class is a class defined within another class. 
    //    Nested classes are typically used to encapsulate helper classes 
    //    that are only relevant to the containing class.
    public class OuterClass
    {
        public void Message()
        {
            Console.WriteLine("This is a Outer class.");
        }
        public class NestedClass
        {
            public void Display()
            {
                Console.WriteLine("This is a nested class.");
            }
        }
    }

    // 7. Generic Class
    //Generic classes allow you to define classes with placeholders 
    //    for the type of its fields, methods, parameters, etc.They provide a 
    //    way to create classes that can work with any data type.
    public class GenericClass<T>
    {
        private T? data;
        public void SetData(T value)
        {
            data = value;
        }

        public T GetData()
        {
            return data;
        }
    }

    // Singleton Class: A class that ensures only one instance is created.
    public class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }

    // Immutable Object: An object that cannot be modified after creation.
    public class ImmutablePoint
    {
        public int X { get; }
        public int Y { get; }

        public ImmutablePoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    //Anonymous classes are used to create objects without explicitly
    //    defining a class. They are often used for convenience in LINQ 
    //    queries or for temporary data structures.

    // Program Entry Point
    public class Program
    {
        public static void Main()
        {
            // Concrete Class
            Dog dog = new Dog { Name = "Buddy" };
            dog.Bark();  // Output: Woof!

            // Abstract Class
            Cat cat = new Cat();
            cat.MakeSound();  // Output: Meow
            cat.Sleep();  // Output: Sleeping

            // Sealed Class
            SealedClass sealedClass = new SealedClass();
            sealedClass.Display();  // Output: This is a sealed class.

            // Static Class
            int sum = MathHelper.Add(5, 10);
            Console.WriteLine($"Sum: {sum}");  // Output: Sum: 15

            // Partial Class
            PartialClass partialClass = new PartialClass();
            partialClass.Method1();  // Output: Method1
            partialClass.Method2();  // Output: Method2

            // Nested Class
            OuterClass outerClass = new OuterClass();
            outerClass.Message();   // Output: This is a outer class.
            OuterClass.NestedClass nestedClass = new OuterClass.NestedClass();
            nestedClass.Display();  // Output: This is a nested class.

            // Generic Class
            GenericClass<int> genericClass = new GenericClass<int>();
            genericClass.SetData(100);
            Console.WriteLine($"Generic Class Data: {genericClass.GetData()}");  // Output: Generic Class Data: 100

            // Anonymous Class
            var anonymousClass = new { Title = "Developer", Salary = 60000 };
            Console.WriteLine($"Title: {anonymousClass.Title}, Salary: {anonymousClass.Salary}");  // Output: Title: Developer, Salary: 60000

            // Singleton Object: Demonstrates that only one instance is created.
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Console.WriteLine($"Singleton Object - Are instances equal: {object.ReferenceEquals(s1, s2)}"); // Output: True

            // Immutable Object: Demonstrates an object that cannot be modified after creation.
            ImmutablePoint ip = new ImmutablePoint(10, 20);
            Console.WriteLine($"Immutable Object - Point X: {ip.X}, Y: {ip.Y}"); // Output: X: 10, Y: 20

        }
    }
}
