using System;
/*
 * Recursion is a programming technique where a method calls itself in order to solve
 * a problem. Recursion can simplify complex problems by breaking them down into
 * smaller, more manageable subproblems. In C#, recursion can be used for tasks 
 * such as traversing data structures, performing mathematical computations, and 
 * solving algorithmic challenges.

Key Concepts of Recursion
Base Case: The condition under which the recursion ends.
            Without a base case, recursion would result in infinite loops 
               and eventually a stack overflow.

Recursive Case: The part of the function where it calls itself with modified 
                    parameters.
*/
public class RecursionExamples
{
    public int Factorial(int n)
    {
        // Base case: factorial of 0 is 1
        if (n == 0)
        {
            return 1;
        }
        // Recursive case: n! = n * (n-1)!
        else
        {
            return n * Factorial(n - 1);
        }
    }

    public static void Main()
    {
        RecursionExamples example = new RecursionExamples();
        int number = 5;
        Console.WriteLine($"Factorial of {number} is {example.Factorial(number)}");
    }
}

