using AbstractionExample;
using System;
using System.ComponentModel;

namespace AbstractionExample
{
    // Abstract Class
    //Abstract Classes: These cannot be instantiated and may contain abstract methods (without implementation)'
    //and non-abstract methods (with implementation).

    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void MakeSound();

        // Regular method
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    // Derived class (inherited from Animal)
    class Dog : Animal
    {
        // Implementing the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    // Interface]
   // Interfaces: These cannot contain any implementation at all; they define a contract that
   // other classes must implement.

    interface IVehicle
    {
        // Abstract methods (no implementation)
        void Start();
        void Stop();
    }

    // Class implementing the interface
    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using abstract class
            Animal myDog = new Dog();
            myDog.MakeSound(); // Output: Woof! Woof!
            myDog.Sleep();     // Output: Sleeping...

            // Using interface
            IVehicle myCar = new Car();
            myCar.Start(); // Output: Car started.
            myCar.Stop();  // Output: Car stopped.
        }
    }
}
//Explanation:
//Abstract Class(Animal):

//Contains an abstract method MakeSound that has no implementation.
//Contains a regular method Sleep with implementation.
//The derived class Dog implements the abstract method MakeSound.
//Interface(IVehicle):

//Contains two abstract methods Start and Stop, which have no implementation.
//The class Car implements both methods defined in the IVehicle interface.
//In this example, abstraction is achieved through the use of abstract classes and
//interfaces, allowing us to define essential behaviors (MakeSound, Start, Stop) without exposing complex implementation details.


