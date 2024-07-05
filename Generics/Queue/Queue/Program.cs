using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize a Queue
        Queue<string> queue = new Queue<string>();

        // Enqueue elements
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        // Peek at the first element
        string firstElement = queue.Peek();
        Console.WriteLine($"First element: {firstElement}");

        // Dequeue elements and print
        Console.WriteLine("\nDequeue elements:");
        while (queue.Count > 0)
        {
            string dequeuedItem = queue.Dequeue();
            Console.WriteLine(dequeuedItem);
        }

        // Check if queue is empty after dequeueing all elements
        Console.WriteLine($"\nQueue is empty: {queue.Count == 0}");

        // Attempting to dequeue from an empty queue (throws InvalidOperationException)
        // string invalidDequeue = queue.Dequeue();
    }
}


//Queue<T> Methods and Properties:
//Methods:
//Enqueue(T item): Adds an item to the end of the Queue<T>.
//Dequeue(): Removes and returns the item at the beginning of the Queue<T>.
//Peek(): Returns the item at the beginning of the Queue<T> without removing it.
//Clear(): Removes all items from the Queue<T>.
//Contains(T item): Determines whether an item is in the Queue<T>, using equality by default.
//CopyTo(T[] array, int arrayIndex): Copies the elements of the Queue<T> to an array, starting at a particular array index.
//ToArray(): Copies the Queue<T> to a new array.
//Properties:
//Count: Gets the number of elements contained in the Queue<T>.
//IsReadOnly: Gets a value indicating whether the Queue<T> is read-only
//Capacity: Gets or sets the total number of elements the internal data structure can hold without resizing.