using System;
using System.Collections.Generic;

class Program
{
    /*
     * In C#, Dictionary<TKey, TValue> is a generic collection class that represents 
     * a collection of key/value pairs where keys must be unique within the dictionary. 
     * 
     * 
     * It provides fast lookups, insertions, and deletions based on the keys using hashing. */
    static void Main()
    {
        // Initialize a Dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Adding elements
        dictionary.Add("one", 1);
        dictionary.Add("two", 2);
        dictionary.Add("three", 3);

        // Accessing elements
        Console.WriteLine("Value at key 'two': " + dictionary["two"]);

        // Modifying elements
        dictionary["three"] = 33;

        // Removing elements
        dictionary.Remove("one");

        // Iterating through keys and values
        Console.WriteLine("Keys and Values:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }

        // Checking existence
        Console.WriteLine("Contains key 'two': " + dictionary.ContainsKey("two"));
        Console.WriteLine("Contains value 33: " + dictionary.ContainsValue(33));

        // Count
        Console.WriteLine("Count: " + dictionary.Count);
        // Get enumerator and iterate through dictionary
        IEnumerator<KeyValuePair<string, int>> enumerator = dictionary.GetEnumerator();

        while (enumerator.MoveNext())
        {
            KeyValuePair<string, int> pair = enumerator.Current;
            Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
        }

        // Dispose enumerator (if needed)
        enumerator.Dispose();
    }
}

/*
 * Methods:
Adding and Removing Elements:
Add(TKey key, TValue value): Adds an element with the specified key and value into the Dictionary<TKey, TValue>.
Clear(): Removes all keys and values from the Dictionary<TKey, TValue>.
Remove(TKey key): Removes the element with the specified key from the Dictionary<TKey, TValue>.
Checking for Existence:
ContainsKey(TKey key): Determines whether the Dictionary<TKey, TValue> contains a specific key.
ContainsValue(TValue value): Determines whether the Dictionary<TKey, TValue> contains a specific value.
Accessing Elements:
Keys: Gets a collection containing the keys in the Dictionary<TKey, TValue>.
Values: Gets a collection containing the values in the Dictionary<TKey, TValue>.
this[TKey key]: Gets or sets the value associated with the specified key in the Dictionary<TKey, TValue>.
Iterating and Modifying:
GetEnumerator(): Returns an enumerator that iterates through the Dictionary<TKey, TValue>.
Count: Gets the number of key/value pairs contained in the Dictionary<TKey, TValue>.
Copying and Converting:
ToArray(): Copies the Dictionary<TKey, TValue> to a new array of key/value pairs.
CopyTo(KeyValuePair<TKey, TValue>[] array, int index): Copies the elements of the Dictionary<TKey, TValue> to an array of KeyValuePair<TKey, TValue> starting at the specified index.
Properties:
Count: Gets the number of key/value pairs contained in the Dictionary<TKey, TValue>.
Keys: Gets a collection containing the keys in the Dictionary<TKey, TValue>.
Values: Gets a collection containing the values in the Dictionary<TKey, TValue>.*/