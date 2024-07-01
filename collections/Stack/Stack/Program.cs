using System;
using System.Collections;

class Program
{
    /*
     * A Stack in C# is a collection that represents a last-in, first-out (LIFO) structure. It is part of the System.Collections namespace. Elements are added to and removed from the top of the stack. Here are some key features, methods, and properties of Stack, along with a comprehensive example.

Key Features of Stack:
LIFO Structure: Elements are processed in a last-in, first-out order.
Non-generic: Can store elements of any data type, but type safety is not enforced.
Dynamic Resizing: Automatically resizes to accommodate new elements.
Common Methods and Properties:
Push(object obj): Adds an object to the top of the stack.
Pop(): Removes and returns the object at the top of the stack.
Peek(): Returns the object at the top of the stack without removing it.
Contains(object obj): Determines whether an element is in the stack.
Clear(): Removes all objects from the stack.
ToArray(): Copies the stack to a new array.
Count: Gets the number of elements in the stack.
    */
    static void Main()
    {
        // Create and initialize a Stack
        Stack stack = new Stack();

        // Adding elements
        stack.Push(10);
        stack.Push("Hello");
        stack.Push(3.14);

        // Accessing the top element without removing it
        Console.WriteLine("Top element: " + stack.Peek());

        // Removing elements
        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Popped element: " + stack.Pop());

        // Checking the remaining elements
        Console.WriteLine("Top element after popping: " + stack.Peek());

        // Checking if the stack contains an element
        bool contains10 = stack.Contains(10);
        Console.WriteLine("Stack contains 10: " + contains10);

        // Iterating through elements
        Console.WriteLine("\nRemaining elements:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        // Converting stack to array
        object[] array = stack.ToArray();
        Console.WriteLine("\nArray created from stack:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        // Clearing the stack
        stack.Clear();
        Console.WriteLine("\nStack after clearing:");
        Console.WriteLine("Count: " + stack.Count);
    }
}
