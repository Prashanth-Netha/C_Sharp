using System;
using System.Collections;

class Program
{

    /*
     * A SortedList in C# is a collection of key/value pairs that are sorted 
     * by the keys and are accessible by key and by index. It is part of the System.Collections
     * namespace and provides efficient lookups, insertions, and deletions.
     * */
    static void Main()
    {
        // Create and initialize a SortedList
        SortedList sortedList = new SortedList();

        // Adding key/value pairs
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");

        // Accessing elements by key
        Console.WriteLine("Value with key 2: " + sortedList[2]);

        // Accessing elements by index
        Console.WriteLine("Value at index 0: " + sortedList.GetByIndex(0));
        Console.WriteLine("Key at index 0: " + sortedList.GetKey(0));

        // Checking if a key exists
        Console.WriteLine("Contains key 1: " + sortedList.ContainsKey(1));

        // Checking if a value exists
        Console.WriteLine("Contains value 'Two': " + sortedList.ContainsValue("Two"));

        // Iterating through keys and values
        Console.WriteLine("\nIterating through SortedList:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }

        // Removing elements by key
        sortedList.Remove(2);
        Console.WriteLine("\nAfter removing key 2:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }

        // Removing elements by index
        sortedList.RemoveAt(0);
        Console.WriteLine("\nAfter removing element at index 0:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }

        // Getting keys and values
        Console.WriteLine("\nKeys:");
        foreach (var key in sortedList.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("\nValues:");
        foreach (var value in sortedList.Values)
        {
            Console.WriteLine(value);
        }

        // Getting count and capacity
        Console.WriteLine("\nCount: " + sortedList.Count);
        Console.WriteLine("Capacity: " + sortedList.Capacity);
    }
}
