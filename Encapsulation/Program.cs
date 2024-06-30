using System;

namespace EncapsulationExample
{
    class Person
    {
        // Private field
        private string name;

        // Public property with a private setter
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        // Public property
        public int Age { get; set; }

        // Protected property
        protected string Nationality { get; set; }

        // Internal property
        internal string Occupation { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.Age = age;
        }

        // Internal constructor
        internal Person(string name)
        {
            this.name = name;
        }

        // Protected constructor
        protected Person() { }

        // Public method
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Private method
        private void DisplaySecret()
        {
            Console.WriteLine("This is a secret method.");
        }

        // Protected method
        protected void DisplayNationality()
        {
            Console.WriteLine($"Nationality: {Nationality}");
        }
    }

    class Employee : Person
    {
        public Employee(string name, int age) : base(name, age) { }

        public void DisplayEmployeeInfo()
        {
            // Can access protected members of the base class
            Nationality = "American";
            DisplayNationality();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 30);
            person.DisplayInfo();
            // person.DisplaySecret(); // Error: Inaccessible due to its protection level

            Employee employee = new Employee("Alice", 28);
            employee.DisplayEmployeeInfo();

            // Internal constructor usage within the same assembly
            Person internalPerson = new Person("InternalPerson");
            internalPerson.DisplayInfo();
        }
    }
}
