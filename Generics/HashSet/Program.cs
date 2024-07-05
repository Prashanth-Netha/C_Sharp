//HashSet<T> is a collection class that represents a set of unique elements.
//    It does not allow duplicate elements and provides high-performance set operations like adding,
//    removing, and checking for existence of elements. Here's an overview of HashSet<T> in C#:

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize a HashSet
        HashSet<int> set = new HashSet<int>();

        // Add elements to the set
        set.Add(1);
        set.Add(2);
        set.Add(3);

        // Try adding a duplicate element
        bool addedDuplicate = set.Add(2); // Returns false since 2 is already in the set

        // Remove an element
        set.Remove(3);

        // Check if an element exists
        bool containsElement = set.Contains(1);

        // Print all elements in the set
        Console.WriteLine("Elements in the set:");
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }

        // Clear the set
        set.Clear();

        // Check count after clearing
        Console.WriteLine("Count after clearing: " + set.Count);
    }
}
/*
 * Key Features:
Unique Elements:

HashSet<T> stores only unique elements. Adding a duplicate element has no effect.
Set Operations:

Efficient operations such as union, intersection, and difference are supported.
No Indexing:

Elements in a HashSet<T> cannot be accessed by index. Use Contains() to check for existence.
Hash-Based Storage:

Uses hashing for fast insertion, deletion, and lookup operations (average time complexity of O(1)).
No Order:

Elements are not stored in any particular order.
Methods:
Add(T item): Adds an element to the HashSet<T>.
Remove(T item): Removes the specified element from the HashSet<T>.
Clear(): Removes all elements from the HashSet<T>.
Contains(T item): Determines whether the HashSet<T> contains a specific element.
UnionWith(IEnumerable<T> other): Modifies the current set to contain all elements that are present in itself, in the specified collection, or in both.
IntersectWith(IEnumerable<T> other): Modifies the current set to contain only elements that are present in both the current set and the specified collection.
ExceptWith(IEnumerable<T> other): Modifies the current set to contain only elements that are present in the current set but not in the specified collection.
SymmetricExceptWith(IEnumerable<T> other): Modifies the current set to contain only elements that are present either in the current set or in the specified collection, but not both.
IsSubsetOf(IEnumerable<T> other): Determines whether the HashSet<T> is a subset of a specified collection.
IsSupersetOf(IEnumerable<T> other): Determines whether the HashSet<T> is a superset of a specified collection.
IsProperSubsetOf(IEnumerable<T> other): Determines whether the HashSet<T> is a proper subset of a specified collection.
IsProperSupersetOf(IEnumerable<T> other): Determines whether the HashSet<T> is a proper superset of a specified collection.
IsSubsetOf(IEnumerable<T> other): Determines whether the HashSet<T> is a subset of a specified collection.
Overlaps(IEnumerable<T> other): Determines whether the HashSet<T> overlaps with the specified collection.
SetEquals(IEnumerable<T> other): Determines whether the current HashSet<T> object and a specified collection contain the same elements.
Properties:
Count: Gets the number of elements contained in the HashSet<T>.
IsReadOnly: Gets a value indicating whether the HashSet<T> is read-only.
*/