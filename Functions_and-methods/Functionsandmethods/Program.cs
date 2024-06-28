using System;

public class MathUtilities
{
    // Static method (function)
/*
 * Function (Static Method)
A static method is a function that
belongs to the class itself rather than
any instance of the class.
*/
public static int Add(int a, int b)
{
    return a + b;
}
}
public class Calculator
{
// Instance method
/*
 * Method (Instance Method)
An instance method is a method that belongs
to an instance of a class. You need to create an
instance of the class to call the method.
*/
public int Multiply(int a, int b)
{
    return a * b;
}
}

public class Program
{
public static void Main()
{
    // Calling the static method (function) without creating an instance of MathUtilities
    int result = MathUtilities.Add(5, 3);
    Console.WriteLine("Result of Add function: " + result);

    Calculator calculator = new Calculator();

    // Calling the instance method on the created instance
    int result1 = calculator.Multiply(5, 3);
    Console.WriteLine("Result of Multiply method: " + result1);
}
}
