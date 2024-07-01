using System;
using System.Collections;

class Program
{
    /*
     * A Hashtable in C# is a collection that stores key/value pairs in a way that allows for fast retrieval
     * using keys. It is part of the System.Collections namespace. The keys are hashed, and the resulting hash
     * code is used to locate the corresponding value quickly.

Key Features of Hashtable:
Key/Value Pairs: Stores data in key/value pairs.
Hashing: Uses hash codes for quick lookups.
Non-generic: Can store elements of any data type, but type safety is not enforced.
Dynamic Resizing: Automatically resizes to accommodate new elements.
Common Methods and Properties:
Add(object key, object value): Adds an element with the provided key and value.
Clear(): Removes all elements from the Hashtable.
Contains(object key): Determines whether the Hashtable contains a specific key.
ContainsKey(object key): Determines whether the Hashtable contains a specific key.
ContainsValue(object value): Determines whether the Hashtable contains a specific value.
Remove(object key): Removes the element with the specified key.
Keys: Gets an ICollection containing the keys in the Hashtable.
Values: Gets an ICollection containing the values in the Hashtable.
Count: Gets the number of key/value pairs contained in the Hashtable.
    */
    static void Main()
    {
        // Create and initialize a Hashtable
        Hashtable hashtable = new Hashtable();

        // Adding key/value pairs
        hashtable.Add(1, "One");
        hashtable.Add(2, "Two");
        hashtable.Add(3, "Three");

        // Accessing elements by key
        Console.WriteLine("Value with key 2: " + hashtable[2]);

        // Checking if the hashtable contains a specific key
        Console.WriteLine("Contains key 1: " + hashtable.ContainsKey(1));

        // Checking if the hashtable contains a specific value
        Console.WriteLine("Contains value 'Three': " + hashtable.ContainsValue("Three"));

        // Iterating through keys and values
        Console.WriteLine("\nIterating through Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }

        // Removing elements by key
        hashtable.Remove(2);
        Console.WriteLine("\nAfter removing key 2:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }

        // Getting keys and values
        Console.WriteLine("\nKeys:");
        foreach (var key in hashtable.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("\nValues:");
        foreach (var value in hashtable.Values)
        {
            Console.WriteLine(value);
        }

        // Getting count
        Console.WriteLine("\nCount: " + hashtable.Count);
    }
}
