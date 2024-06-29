using System;

namespace ObjectTypesExample
{
    public class Program
    {

        // Supporting Class Definitions

        // 1. Instance Object class
        public class Car
        {
            public string Model { get; set; }
        }

        // 2. Static Object class
        public static class MathHelper
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
        }

        // 6. Value Type Object struct
        //A struct is a value type in C#. Structs are useful for representing lightweight 
        //    objects that have a small amount of data and do not require inheritance.
        //    Structs are allocated on the stack rather than the heap, 
        //    which can provide performance benefits.
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        // 7. Reference Type Object class
        public class Person
        {
            public string Name { get; set; }
        }

        // 8. Immutable Object class
        //immutable refers to objects whose state (the values of its properties or
        //fields) cannot be modified after the object is created. Once an immutable
        //object is instantiated, its internal state remains fixed for its entire
        //lifetime.
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

        // 9. Disposable Object class

        //In C#, the concept of disposable typically refers to objects that implement
        //the IDisposable interface. This interface provides a mechanism for releasing
        //unmanaged resources used by an object, such as file handles, database
        //connections, or memory buffers. Managing these resources ensures efficient
        //memory usage and prevents resource leaks.


        public class ResourceHolder : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Resources released.");
            }
        }

        // 10. Singleton Object class
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
        public static void Main()
        {
            // 1. Instance Object: An object created from a class using the `new` keyword.
            Car myCar = new Car { Model = "Toyota" };
            Console.WriteLine($"Instance Object - Car Model: {myCar.Model}"); // Output: Toyota

            // 2. Static Object: Objects are not instantiated, they belong to the class itself.
            int sum = MathHelper.Add(5, 10);
            Console.WriteLine($"Static Object - Sum: {sum}"); // Output: 15

            // 3. Anonymous Object: An object created without defining a class.
            var anonymousObject = new { Name = "John", Age = 30 };
            Console.WriteLine($"Anonymous Object - Name: {anonymousObject.Name}, Age: {anonymousObject.Age}"); // Output: Name: John, Age: 30

            // 4. Dynamic Object: An object whose type is determined at runtime.
            dynamic dynamicObject = new System.Dynamic.ExpandoObject();
            dynamicObject.Name = "John";
            dynamicObject.Age = 35;
            Console.WriteLine($"Dynamic Object - Name: {dynamicObject.Name}"); // Output: John
            Console.WriteLine($"Dynamic Object - Age: {dynamicObject.Age}"); // Output: 35

            // 5. Tuple: A lightweight data structure to hold multiple values.
            var tuple = (Name: "John", Age: 30);
            Console.WriteLine($"Tuple - Name: {tuple.Name}, Age: {tuple.Age}"); // Output: Name: John, Age: 30

            // 6. Value Type Object: An object of a value type such as a struct.
            Point p = new Point { X = 10, Y = 20 };
            Console.WriteLine($"Value Type Object - Point X: {p.X}, Y: {p.Y}"); // Output: X: 10, Y: 20

            // 7. Reference Type Object: An object of a reference type such as a class.
            //A reference object refers to any object of a reference type.In C#, 
            //    classes are reference types, which means when you create an object
            //    of a class, the variable you use to store the object holds a 
            //reference to the memory location where the object data is actually stored.
            //This is in contrast to value types (like int, struct, etc.),
            //where the variable holds the actual data directly.
            Person person = new Person { Name = "John" };
            Person person2 = person;
            person2.Name = "prashanth";
            // Here Person2 is refernce to person holding address of person any changes in person2
            // will change the data in person
            Console.WriteLine($"Reference Type Object - Person Name: {person.Name}"); // Output: John

            // 8. Immutable Object: An object that cannot be modified after creation.
            ImmutablePoint ip = new ImmutablePoint(10, 20);
            Console.WriteLine($"Immutable Object - Point X: {ip.X}, Y: {ip.Y}"); // Output: X: 10, Y: 20

            // 9. Disposable Object: An object that implements IDisposable to release unmanaged resources.
            using (ResourceHolder holder = new ResourceHolder())
            {
                // Use the resource
            } // holder.Dispose() is called automatically here

            // 10. Singleton Object: An object that ensures only one instance is created.
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Console.WriteLine($"Singleton Object - Are instances equal: {object.ReferenceEquals(s1, s2)}"); // Output: True
        }
    }

}
