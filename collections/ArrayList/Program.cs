using System;
using System.Collections;
using System.Collections.Generic;


/*In C#, ArrayList is a non-generic collection class that allows storing elements of any data type.
 * Here are some key points about ArrayList:

Dynamic Resizing: ArrayList internally uses an array that dynamically resizes itself 
as elements are added or removed. Initially, it starts with a small capacity and grows as needed when more elements are added.

Element Access: Elements in an ArrayList are accessed using zero-based indexing, similar to arrays.

Boxing and Unboxing: Since ArrayList can hold elements of any type, value types (like int, float, etc.)
are automatically boxed (converted to reference types) when added to an ArrayList, and unboxed 
(converted back to value types) when retrieved.

Methods and Properties: ArrayList provides methods for adding, inserting, removing, and manipulating
elements similar to the List<T> class. It also includes properties like Count (to get the number of elements) 
and Capacity (to get or set the current capacity).

Performance Considerations: Due to boxing/unboxing operations and potential resizing of the internal array,
performance may degrade when compared to strongly-typed collections like List<T> for value types.

Not Type-Safe: Unlike generics (List<T>), ArrayList does not provide type safety at compile-time,
which can lead to runtime errors if types are mismatched.
*/


class Program
{
    static void Main()
    {
        // Create a new List<int>
        ArrayList numbers = new ArrayList();

        // Add elements
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        Console.WriteLine("List elements:");
        PrintList(numbers);

        // Insert an element at index 2
        numbers.Insert(2, 25);
        Console.WriteLine("\nAfter inserting 25 at index 2:");
        PrintList(numbers);

        // Remove element 30
        numbers.Remove(30);
        Console.WriteLine("\nAfter removing element 30:");
        PrintList(numbers);

        // Remove element at index 4
        numbers.RemoveAt(4);
        Console.WriteLine("\nAfter removing element at index 4:");
        PrintList(numbers);

        // Check if list contains element 20
        bool contains20 = numbers.Contains(20);
        Console.WriteLine("\nList contains 20: " + contains20);

        // Find index of element 40
        int index = numbers.IndexOf(40);
        Console.WriteLine("Index of element 40: " + index);

        // Sort the list
        numbers.Sort();
        Console.WriteLine("\nSorted list:");
        PrintList(numbers);

        // Reverse the list
        numbers.Reverse();
        Console.WriteLine("\nReversed list:");
        PrintList(numbers);

        // Clear the list
        numbers.Clear();
        Console.WriteLine("\nList after clearing:");
        PrintList(numbers);

        // Add range of elements
        numbers.AddRange(new int[] { 100, 200, 300 });
        Console.WriteLine("\nAfter adding range [100, 200, 300]:");
        PrintList(numbers);

        // Convert list to array
        var array = numbers.ToArray();
        Console.WriteLine("\nArray created from list:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        // Get current count and capacity
        Console.WriteLine("\nCurrent count: " + numbers.Count);
        Console.WriteLine("Current capacity: " + numbers.Capacity);
    }

    static void PrintList( ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
