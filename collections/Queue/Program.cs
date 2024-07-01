using System;
using System.Collections;

class Program
{   /*
     * A Queue in C# is a collection that represents a first-in, first-out (FIFO) structure. It is part of the System.Collections namespace. Elements are added to the end of the queue and removed from the beginning. Here are some key features, methods, and properties of Queue, along with a comprehensive example.

Key Features of Queue:
FIFO Structure: Elements are processed in a first-in, first-out order.
Non-generic: Can store elements of any data type, but type safety is not enforced.
Dynamic Resizing: Automatically resizes to accommodate new elements.
Common Methods and Properties:
Enqueue(object obj): Adds an object to the end of the queue.
Dequeue(): Removes and returns the object at the beginning of the queue.
Peek(): Returns the object at the beginning of the queue without removing it.
Contains(object obj): Determines whether an element is in the queue.
Clear(): Removes all objects from the queue.
ToArray(): Copies the queue to a new array.
Count: Gets the number of elements in the queue.
    */
    static void Main()
    {
        // Create and initialize a Queue
        Queue queue = new Queue();

        // Adding elements
        queue.Enqueue(10);
        queue.Enqueue("Hello");
        queue.Enqueue(3.14);

        // Accessing the front element without removing it
        Console.WriteLine("Front element: " + queue.Peek());

        // Removing elements
        Console.WriteLine("Dequeued element: " + queue.Dequeue());
        Console.WriteLine("Dequeued element: " + queue.Dequeue());

        // Checking the remaining elements
        Console.WriteLine("Front element after dequeuing: " + queue.Peek());

        // Checking if the queue contains an element
        bool contains10 = queue.Contains(10);
        Console.WriteLine("Queue contains 10: " + contains10);

        // Iterating through elements
        Console.WriteLine("\nRemaining elements:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        // Converting queue to array
        object[] array = queue.ToArray();
        Console.WriteLine("\nArray created from queue:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        // Clearing the queue
        queue.Clear();
        Console.WriteLine("\nQueue after clearing:");
        Console.WriteLine("Count: " + queue.Count);
    }
}
