//Stack<T> Methods and Properties:


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize a Stack
        Stack<int> stack = new Stack<int>();

        // Push elements onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Peek at the top element (without removing it)
        int topElement = stack.Peek();
        Console.WriteLine($"Top element: {topElement}");

        // Pop elements from the stack and print them
        Console.WriteLine("\nStack Elements (pop):");
        while (stack.Count > 0)
        {
            int poppedElement = stack.Pop();
            Console.WriteLine(poppedElement);
        }

        // Check if stack is empty after popping all elements
        Console.WriteLine($"\nStack is empty: {stack.Count == 0}");

        // Attempting to pop from an empty stack (throws InvalidOperationException)
        // int invalidPop = stack.Pop();
    }
}

//Methods:
//Push(T item): Adds an item to the top of the Stack<T>.
//Pop(): Removes and returns the item at the top of the Stack<T>.
//Peek(): Returns the item at the top of the Stack<T> without removing it.
//Clear(): Removes all items from the Stack<T>.
//Contains(T item): Determines whether an item is in the Stack<T>, using equality by default.
//CopyTo(T[] array, int arrayIndex): Copies the elements of the Stack<T> to an array, starting at a particular array index.
//ToArray(): Copies the Stack<T> to a new array.
//TrimExcess(): Sets the capacity of the Stack<T> to the actual number of elements it contains, if that number is less than a threshold value.
//Properties:
//Count: Gets the number of elements contained in the Stack<T>.
//IsReadOnly: Gets a value indicating whether the Stack<T> is read-only.
//Capacity: Gets or sets the total number of elements the internal data structure can hold without resizing.