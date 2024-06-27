using System;
using System.Text;
using System.Threading.Channels;

class Program
{

    /*
     * StringBuilder in C# is a class that provides mutable string operations
     * with better performance compared to directly manipulating strings using 
     * the string class. It is particularly useful when you need to concatenate multiple 
     * strings in a loop or when you want to modify a string repeatedly without creating a
     * new string object each time. Here's an overview of StringBuilder:
     * */
    static void Main()
    {
        // Initialize a StringBuilder with a capacity
        StringBuilder sb = new StringBuilder("Hello", 50); // initial capacity of 50 characters

        // Append strings
        sb.Append(" World");
        sb.AppendLine("!"); // Appends the new line terminator

        // Insert at a specific position
        sb.Insert(6, "C# ");

        // Replace a substring
        sb.Replace("World", "Universe");

        // Remove characters
        sb.Remove(11, 1); // Remove '!' character

        // Output the final string
        Console.WriteLine(sb.ToString()); // Outputs: Hello C# Universe!
    }
}

//Key Features and Usage:
//Mutable Strings:

//Unlike the string class, which is immutable(its value cannot be changed once it is created), StringBuilder allows you to modify the contents of a string without creating a new string object each time.
//Performance:

//StringBuilder is more efficient when performing multiple string manipulations, such as concatenations or replacements, especially in loops. This is because it minimizes the number of memory allocations and copies.
//StringBuilder Methods:

//Append: Adds a string representation of an object to the end of the StringBuilder.
//AppendLine: Adds a line terminator (Environment.NewLine) after appending the string.
//Insert: Inserts a string representation of an object into the StringBuilder at the specified position.
//Remove: Removes a specified number of characters from the StringBuilder starting at a specified position.
//Replace: Replaces all occurrences of a specified substring with another substring in the StringBuilder.
//Clear: Removes all characters from the StringBuilder.
//Capacity:

//StringBuilder dynamically adjusts its internal buffer to accommodate the data being appended. You can set an initial capacity to avoid frequent reallocations.
//ToString Method:

//Converts the current StringBuilder object to a string.