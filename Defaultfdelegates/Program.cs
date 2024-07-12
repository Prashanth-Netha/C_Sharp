using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;



//Benefits of Using Default Delegates
//Simplification: They simplify the declaration and usage of delegates.
//Readability: They make code more readable by reducing the need for custom delegate definitions.
//Consistency: They provide a consistent way to handle common delegate scenarios.
public class Program
{
    public static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static bool IsPositive(int number)
    {
        return number > 0;
    }
    public static bool IsEven(int number)
    {
        bool result = number % 2 == 0;
        Console.WriteLine("IsEven: " + result);
        return result;
    }

    public static void PrintMessage1(string message)
    {
        Console.WriteLine("Message 1: " + message);
    }

    public static void PrintMessage2(string message)
    {
        Console.WriteLine("Message 2: " + message);
    }

    public static int AddOne(int number)
    {
        int result = number + 1;
        Console.WriteLine("AddOne: " + result);
        return result;
    }

    public static int AddTwo(int number)
    {
        int result = number + 2;
        Console.WriteLine("AddTwo: " + result);
        return result;
    }

    public static void Main()
    {

//        Action Delegates:

//Used for methods that do not return a value.
//Can take 0 to 16 parameters
        Action<string> actionDelegate = PrintMessage;
        actionDelegate("Hello, Action Delegate!");


//        Func Delegates:

//Used for methods that return a value.
//Can take 0 to 16 parameters, with the last type parameter representing the return type.

        Func<int, int, int> funcDelegate = Add;
        int result = funcDelegate(3, 4);
        Console.WriteLine("Result: " + result);


        //Predicate Delegates:

        // Used for methods that take one parameter and return a boolean.

        Predicate<int> predicateDelegate = IsPositive;
        bool result1 = predicateDelegate(5);
        Console.WriteLine("Is positive: " + result1);



        Action<string> actionDelegate1 = PrintMessage1;
        actionDelegate1 += PrintMessage2;

        actionDelegate1("Hello, Multicast Action!");



        Func<int, int> funcDelegate1 = AddOne;
        funcDelegate1 += AddTwo;

        int finalResult = funcDelegate1(5);
        Console.WriteLine("Final Result: " + finalResult);


        Predicate<int> predicateDelegate1 = IsPositive;
        predicateDelegate1 += IsEven;

        bool finalResult1 = predicateDelegate1(4);
        Console.WriteLine("Final Result: " + finalResult1);
    }
}
