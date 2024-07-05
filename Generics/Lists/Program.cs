using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    //List<T>
    //A List<T> is a dynamic array that provides methods to add, remove, and search for items.
    static void Main()
    {
        // Initialize a List
        List<string> list = new List<string> { "Apple", "Banana", "Cherry", "Banana" };

        // Adding elements
        list.Add("Durian");
        list.AddRange(new string[] { "Elderberry", "Fig" });

        // Accessing elements
        Console.WriteLine("Element at index 1: " + list[1]);

        // Searching elements
        Console.WriteLine("Index of 'Banana': " + list.IndexOf("Banana"));
        Console.WriteLine("Last index of 'Banana': " + list.LastIndexOf("Banana"));
        Console.WriteLine("Contains 'Apple': " + list.Contains("Apple"));

        // Modifying elements
        list.Insert(1, "Blueberry");
        list.Remove("Banana");
        list.RemoveAt(0);
        list.RemoveAll(item => item.StartsWith("E"));

        // Converting and copying elements
        var array = list.ToArray();
        list.CopyTo(array);

        // Iterating through elements
        Console.WriteLine("List elements:");
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }

        // Other operations
        list.Sort();
        Console.WriteLine("After Sorting");
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
        list.Reverse();
        Console.WriteLine("List elements: After Reversing");
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
        list.TrimExcess();
       
        // Properties
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("Capacity: " + list.Capacity);
    }
}


/*Certainly! The List<T> class in C# is a versatile and widely used generic collection. Here is a comprehensive list of its methods and properties:

Properties:
Capacity: Gets or sets the total number of elements the internal data structure can hold without resizing.
Count: Gets the number of elements contained in the List<T>.
Methods:
Adding Elements:
Add(T item): Adds an object to the end of the List<T>.
AddRange(IEnumerable<T> collection): Adds the elements of the specified collection to the end of the List<T>.
Accessing Elements:
this[int index]: Gets or sets the element at the specified index.
Searching Elements:
BinarySearch(T item): Searches the entire sorted List<T> for an element using the default comparer and returns the zero-based index of the element.
BinarySearch(T item, IComparer<T> comparer): Searches the entire sorted List<T> for an element using the specified comparer and returns the zero-based index of the element.
BinarySearch(int index, int count, T item, IComparer<T> comparer): Searches a range of elements in the sorted List<T> for an element using the specified comparer and returns the zero-based index of the element.
Contains(T item): Determines whether an element is in the List<T>.
Find(Predicate<T> match): Searches for an element that matches the conditions defined by the specified predicate and returns the first occurrence within the entire List<T>.
FindAll(Predicate<T> match): Retrieves all the elements that match the conditions defined by the specified predicate.
FindIndex(Predicate<T> match): Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the first occurrence within the entire List<T>.
FindIndex(int startIndex, Predicate<T> match): Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the first occurrence within the range of elements in the List<T> that extends from the specified index to the last element.
FindIndex(int startIndex, int count, Predicate<T> match): Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the first occurrence within the range of elements in the List<T> that starts at the specified index and contains the specified number of elements.
FindLast(Predicate<T> match): Searches for an element that matches the conditions defined by the specified predicate and returns the last occurrence within the entire List<T>.
FindLastIndex(Predicate<T> match): Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the last occurrence within the entire List<T>.
FindLastIndex(int startIndex, Predicate<T> match): Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the last occurrence within the range of elements in the List<T> that extends from the first element to the specified index.
FindLastIndex(int startIndex, int count, Predicate<T> match): Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the last occurrence within the range of elements in the List<T> that starts at the specified index and contains the specified number of elements.
IndexOf(T item): Searches for the specified object and returns the zero-based index of the first occurrence within the entire List<T>.
IndexOf(T item, int index): Searches for the specified object and returns the zero-based index of the first occurrence within the range of elements that extends from the specified index to the last element.
IndexOf(T item, int index, int count): Searches for the specified object and returns the zero-based index of the first occurrence within the range of elements that starts at the specified index and contains the specified number of elements.
LastIndexOf(T item): Searches for the specified object and returns the zero-based index of the last occurrence within the entire List<T>.
LastIndexOf(T item, int index): Searches for the specified object and returns the zero-based index of the last occurrence within the range of elements that extends from the first element to the specified index.
LastIndexOf(T item, int index, int count): Searches for the specified object and returns the zero-based index of the last occurrence within the range of elements that contains the specified number of elements and ends at the specified index.
Converting and Copying Elements:
AsReadOnly(): Returns a read-only ReadOnlyCollection<T> wrapper for the current collection.
CopyTo(T[] array): Copies the entire List<T> to a compatible one-dimensional array, starting at the beginning of the target array.
CopyTo(T[] array, int arrayIndex): Copies the entire List<T> to a compatible one-dimensional array, starting at the specified index of the target array.
CopyTo(int index, T[] array, int arrayIndex, int count): Copies a range of elements from the List<T> to a compatible one-dimensional array, starting at the specified index of the target array.
ToArray(): Copies the elements of the List<T> to a new array.
Modifying Elements:
Clear(): Removes all elements from the List<T>.
Insert(int index, T item): Inserts an element into the List<T> at the specified index.
InsertRange(int index, IEnumerable<T> collection): Inserts the elements of a collection into the List<T> at the specified index.
Remove(T item): Removes the first occurrence of a specific object from the List<T>.
RemoveAll(Predicate<T> match): Removes all the elements that match the conditions defined by the specified predicate.
RemoveAt(int index): Removes the element at the specified index of the List<T>.
RemoveRange(int index, int count): Removes a range of elements from the List<T>.
Reverse(): Reverses the order of the elements in the entire List<T>.
Reverse(int index, int count): Reverses the order of the elements in the specified range.
Sort(): Sorts the elements in the entire List<T> using the default comparer.
Sort(IComparer<T> comparer): Sorts the elements in the entire List<T> using the specified comparer.
Sort(Comparison<T> comparison): Sorts the elements in the entire List<T> using the specified comparison delegate.
Sort(int index, int count, IComparer<T> comparer): Sorts the elements in a range of elements in the List<T> using the specified comparer.
TrimExcess(): Sets the capacity to the actual number of elements in the List<T>, if that number is less than a threshold value.
*/