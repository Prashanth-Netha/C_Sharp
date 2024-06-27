using System;

class Program
{
    static void Main()
    {
        // Create and initialize an array
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };

        // Static methods
        // Clear: Sets a range of elements in the array to their default value (0 for int)
        Array.Clear(array, 2, 3);
        Console.WriteLine("After Clear: " + string.Join(", ", array)); // Output: 3, 1, 0, 0, 0, 9, 2, 6, 5

        // Copy: Copies elements from one array to another
        int[] destinationArray = new int[10];
        Array.Copy(array, destinationArray, array.Length);
        Console.WriteLine("After Copy: " + string.Join(", ", destinationArray)); // Output: 3, 1, 0, 0, 0, 9, 2, 6, 5, 0

        // CreateInstance: Creates a new instance of an array
        Array newArray = Array.CreateInstance(typeof(int), 5);
        Console.WriteLine("New Array Length: " + newArray.Length); // Output: 5


        /* Suppose we want to create an array dynamically based on user input
        Console.Write("Enter the element type (int/float/string): ");
        string typeInput = Console.ReadLine();
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        Type elementType;
        switch (typeInput.ToLower())
        {
            case "int":
                elementType = typeof(int);
                break;
            case "float":
                elementType = typeof(float);
                break;
            case "string":
                elementType = typeof(string);
                break;
            default:
                Console.WriteLine("Invalid type.");
                return;
        }

        Array dynamicArray = Array.CreateInstance(elementType, size);
        Console.WriteLine($"Created a {typeInput} array of size {size}.");

        // Display the type and length of the created array
        Console.WriteLine($"Array Type: {dynamicArray.GetType().GetElementType()}");
        Console.WriteLine($"Array Length: {dynamicArray.Length}");
        */


        // Find: Finds the first element that matches the condition
        int foundElement = Array.Find(array, element => element == 1);
        Console.WriteLine("Found Element: " + foundElement); // Output: 1

        // FindAll: Finds all elements that match the condition
        int[] foundElements = Array.FindAll(array, element => element == 1);
        Console.WriteLine("Found All Elements: " + string.Join(", ", foundElements)); // Output: 1, 1

        // FindIndex: Finds the index of the first element that matches the condition
        int foundIndex = Array.FindIndex(array, element => element == 1);
        Console.WriteLine("Found Index: " + foundIndex); // Output: 1

        // FindLast: Finds the last element that matches the condition
        int foundLastElement = Array.FindLast(array, element => element == 1);
        Console.WriteLine("Found Last Element: " + foundLastElement); // Output: 1

        // FindLastIndex: Finds the index of the last element that matches the condition
        int foundLastIndex = Array.FindLastIndex(array, element => element == 1);
        Console.WriteLine("Found Last Index: " + foundLastIndex); // Output: 1

        // IndexOf: Finds the index of the first occurrence of an element
        int indexOfElement = Array.IndexOf(array, 9);
        Console.WriteLine("Index Of Element: " + indexOfElement); // Output: 5

        // LastIndexOf: Finds the index of the last occurrence of an element
        int lastIndexOfElement = Array.LastIndexOf(array, 5);
        Console.WriteLine("Last Index Of Element: " + lastIndexOfElement); // Output: 8

        // Reverse: Reverses the array
        Array.Reverse(array);
        Console.WriteLine("After Reverse: " + string.Join(", ", array)); // Output: 5, 6, 2, 9, 0, 0, 0, 1, 3

        // Sort: Sorts the array
        Array.Sort(array);
        Console.WriteLine("After Sort: " + string.Join(", ", array)); // Output: 0, 0, 0, 1, 2, 3, 5, 6, 9

        // BinarySearch: Searches the array for an element using binary search
        // Array should be sorted otherwise results may vary
        int binarySearchIndex = Array.BinarySearch(array, 3);
        Console.WriteLine("Binary Search Index: " + binarySearchIndex); // Output: 5

        // Resize: Changes the size of the array
        Array.Resize(ref array, 12);
        Console.WriteLine("After Resize: " + string.Join(", ", array)); // Output: 0, 0, 0, 1, 2, 3, 5, 6, 9, 0, 0, 0

        // Exists: Checks if an element exists in the array
        bool exists = Array.Exists(array, element => element == 5);
        Console.WriteLine("Exists: " + exists); // Output: True

        // Instance methods
        
        int[] clonedArray = (int[])array.Clone();
        Console.WriteLine("Cloned Array: " + string.Join(", ", clonedArray)); // Output: 0, 0, 0, 1, 2, 3, 5, 6, 9, 0, 0, 0

        // CopyTo: Copies elements from this array to another array
        int[] anotherDestinationArray = new int[15];
        array.CopyTo(anotherDestinationArray, 3);
        Console.WriteLine("After CopyTo: " + string.Join(", ", anotherDestinationArray)); // Output: 0, 0, 0, 0, 0, 0, 1, 2, 3, 5, 6, 9, 0, 0, 0

        // GetEnumerator: Returns an enumerator for the array
        var enumerator = array.GetEnumerator();
        Console.Write("Array Elements: ");
        while (enumerator.MoveNext())
        {
            Console.Write(enumerator.Current + " ");
        }
        Console.WriteLine(); // Output: 0 0 0 1 2 3 5 6 9 0 0 0

        // GetLength: Gets the number of elements in the specified dimension specifically used in multidimenstional array
        int length = array.GetLength(0);
        Console.WriteLine("Array Length: " + length); // Output: 12

        // GetLowerBound: Gets the lower bound(manimum index number in dimention) of the specified dimension specifically used in multidimenstional array
        int lowerBound = array.GetLowerBound(0);
        Console.WriteLine("Lower Bound: " + lowerBound); // Output: 0

        // GetUpperBound: Gets the upper bound(maximum index number in dimention) of the specified dimension specifically used in multidimenstional array
        int upperBound = array.GetUpperBound(0);
        Console.WriteLine("Upper Bound: " + upperBound); // Output: 11

        // GetValue: Gets the value at the specified position
        int valueAtPosition = (int)array.GetValue(4);
        Console.WriteLine("Value at Position 4: " + valueAtPosition); // Output: 2

        // SetValue: Sets the value at the specified position
        array.SetValue(7, 4);
        Console.WriteLine("After SetValue: " + string.Join(", ", array)); // Output: 0, 0, 0, 1, 7, 3, 5, 6, 9, 0, 0, 0
    }
}
