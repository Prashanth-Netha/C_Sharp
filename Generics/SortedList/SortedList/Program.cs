using System;
using System.Collections;

class Program
{

    /*
     * In C#, SortedList<T> is a generic collection class that represents a collection of key/value pairs that are 
     * sorted by the keys. It maintains the elements in ascending order of the keys based on the associated 
     * IComparer<T> implementation or the default comparer for the key type. Here's a detailed definition and 
     * explanation:
     * */
    static void Main()
    {
        // Initialize a SortedList<TKey, TValue>
        SortedList<string, int> sortedList = new SortedList<string, int>();

        // Adding elements
        sortedList.Add("one", 1);
        sortedList.Add("two", 2);
        sortedList.Add("three", 3);

        // Accessing elements
        Console.WriteLine("Value associated with key 'two': " + sortedList["two"]);

        // Modifying elements
        sortedList["three"] = 33;

        // Removing elements
        sortedList.Remove("one");

        // Count and Capacity
        Console.WriteLine("Count: " + sortedList.Count);

        // Iterating through keys and values
        Console.WriteLine("Keys and Values:");
        foreach (var key in sortedList.Keys)
        {
            Console.WriteLine("Key: " + key + ", Value: " + sortedList[key]);
        }

        // Checking existence
        Console.WriteLine("Contains key 'two': " + sortedList.ContainsKey("two"));
        Console.WriteLine("Contains value 33: " + sortedList.ContainsValue(33));

        // Indexing
        int index = sortedList.IndexOfKey("three");
        Console.WriteLine("Index of key 'three': " + index);

        // Clearing the SortedList
        sortedList.Clear();
        Console.WriteLine("Count after clearing: " + sortedList.Count);
    }
}

/*Properties:
Capacity: Gets or sets the number of elements that the SortedList<TKey, TValue> can contain.
Count: Gets the number of key/value pairs contained in the SortedList<TKey, TValue>.
Methods:
Adding and Removing Elements:
Add(TKey key, TValue value): Adds an element with the specified key and value into the SortedList<TKey, TValue>.
Clear(): Removes all elements from the SortedList<TKey, TValue>.
Remove(TKey key): Removes the element with the specified key from the SortedList<TKey, TValue>.
Searching Elements:
ContainsKey(TKey key): Determines whether the SortedList<TKey, TValue> contains a specific key.
ContainsValue(TValue value): Determines whether the SortedList<TKey, TValue> contains a specific value.
IndexOfKey(TKey key): Retrieves the zero-based index of the specified key in the SortedList<TKey, TValue>.
IndexOfValue(TValue value): Retrieves the zero-based index of the specified value in the SortedList<TKey, TValue>.
Accessing Elements:
Keys: Gets a collection containing the keys in the SortedList<TKey, TValue>, ordered by their associated values.
Values: Gets a collection containing the values in the SortedList<TKey, TValue>, ordered by their associated keys.
this[TKey key]: Gets or sets the value associated with the specified key in the SortedList<TKey, TValue>.
Iterating and Modifying:
GetEnumerator(): Returns an enumerator that iterates through the SortedList<TKey, TValue>.
RemoveAt(int index): Removes the element at the specified index of the SortedList<TKey, TValue>.
TrimExcess(): Sets the capacity to the actual number of elements in the SortedList<TKey, TValue>, if it is less than 90 percent of the current capacity.
Copying and Converting:
Clone(): Creates a shallow copy of the SortedList<TKey, TValue>.
CopyTo(Array array, int arrayIndex): Copies the elements of the SortedList<TKey, TValue> to an Array, starting at a particular Array index.
Sorting and Searching:
ContainsKey(TKey key): Determines whether the SortedList<TKey, TValue> contains a specific key.
ContainsValue(TValue value): Determines whether the SortedList<TKey, TValue> contains a specific value.
GetByIndex(int index): Gets the value at the specified index of the SortedList<TKey, TValue>.
IndexOfKey(TKey key): Searches for the specified key and returns the zero-based index within the entire SortedList<TKey, TValue>.
IndexOfValue(TValue value): Searches for the specified value and returns the zero-based index of the first occurrence within the entire SortedList<TKey, TValue>.
IndexOfValue(TValue value, int startIndex): Searches for the specified value and returns the zero-based index of the first occurrence within the range of elements in the SortedList<TKey, TValue> that starts at the specified index.
IndexOfValue(TValue value, int startIndex, int count): Searches for the specified value and returns the zero-based index of the first occurrence within the range of elements in the SortedList<TKey, TValue> that contains the specified number of elements and starts at the specified index.
IndexOfValue(TValue value, int startIndex, int count, IEqualityComparer<TValue> comparer): Searches for the specified value and returns the zero-based index of the first occurrence within the range of elements in the SortedList<TKey, TValue> that starts at the specified index and contains the specified number of elements, using the specified equality comparer.
*/