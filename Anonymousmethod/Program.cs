using System;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public delegate void Print(int value);
    public delegate void PrintDelegate();
    public static void PrintHelperMethod(Print printDel, int val)
    {
        val += 10;
        printDel(val);
    }
    public delegate int SquareDelegate(int x);
    public delegate int AddDelegate(int x, int y);
    static void Main(string[] args)
    {
        //Anonymous Method
      //  As the name suggests, an anonymous method is a method without a name.Anonymous methods
      //  in C# can be defined using the delegate keyword and can be assigned to a variable of delegate type.


        Print print = delegate (int val) {
            Console.WriteLine("Inside Anonymous method. Value: {0}", val);
        };
        print(100);

        // Anonymous methods can access variables defined in an outer function.]

        int i = 10;

        Print prnt = delegate (int val) {
            val += i;
            Console.WriteLine("Anonymous method: {0}", val);
        };
        prnt(100);

        //  Anonymous methods can also be passed to a method that accepts the delegate as a parameter.

        PrintHelperMethod(delegate (int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);

        //       Anonymous Method Limitations
        //       It cannot contain jump statement like goto, break or continue.
        //       It cannot access ref or out parameter of an outer method.
        //        It cannot have or access unsafe code.
        //       It cannot be used on the left side of the is operator.
        //Points to Remember:
        //       Anonymous method can be defined using the delegate keyword
        //       Anonymous method must be assigned to a delegate.
        //       Anonymous method can access outer variables or functions.
        //       Anonymous method can be passed as a parameter.
        //       Anonymous method can be used as event handlers.





        // Lambda expressions in C# provide a concise way to represent anonymous methods.
        // They are a powerful feature that simplifies the syntax for writing inline methods and are often used with delegates,
        // events, and LINQ (Language-Integrated Query).


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Use a lambda expression to define the criteria for the Where method
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

        SquareDelegate square = x => x * x;
        int result = square(5);
        Console.WriteLine("Square of 5: " + result);

        AddDelegate add = (x, y) => x + y;
        int result1 = add(3, 4);
        Console.WriteLine("Sum of 3 and 4: " + result1);



        PrintDelegate print1 = () => Console.WriteLine("Hello, Lambda!");
        print1();

    }
}