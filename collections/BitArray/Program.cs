using System;
using System.Collections;

class Program
{
    /*
     * A BitArray in C# is a collection that efficiently stores and manipulates a compact array of bit values, 
     * represented as booleans. It is part of the System.Collections namespace.
     * Each bit is a boolean value: true (1) or false (0).

Key Features of BitArray:
Compact Storage: Stores boolean values in a compact array.
Efficient Manipulation: Provides methods for bitwise operations.
Dynamic Resizing: Can change size to accommodate different numbers of bits.
Common Methods and Properties:
Get(int index): Gets the value of the bit at a specific position.
Set(int index, bool value): Sets the bit at a specific position to the specified value.
SetAll(bool value): Sets all bits in the BitArray to the specified value.
And(BitArray value): Performs a bitwise AND operation between the elements of the current BitArray object and the elements in the specified BitArray object.
Or(BitArray value): Performs a bitwise OR operation between the elements of the current BitArray object and the elements in the specified BitArray object.
Xor(BitArray value): Performs a bitwise XOR operation between the elements of the current BitArray object and the elements in the specified BitArray object.
Not(): Inverts all the bit values in the current BitArray, changing elements set to true to false, and vice versa.
Length: Gets or sets the number of elements in the BitArray.
    */
    static void Main()
    {
        // Initialize a BitArray with an array of booleans
        bool[] initialValues = new bool[] { true, false, true, false, true };
        BitArray bitArray = new BitArray(initialValues);

        // Print initial BitArray
        Console.WriteLine("Initial BitArray:");
        PrintBitArray(bitArray);

        // Accessing elements
        Console.WriteLine("\nValue at index 2: " + bitArray.Get(2));

        // Modifying elements
        bitArray.Set(1, true);
        Console.WriteLine("\nBitArray after setting index 1 to true:");
        PrintBitArray(bitArray);

        // Setting all elements
        bitArray.SetAll(false);
        Console.WriteLine("\nBitArray after setting all elements to false:");
        PrintBitArray(bitArray);

        // Re-initialize the BitArray for further operations
        bitArray = new BitArray(initialValues);

        // Bitwise AND
        BitArray andArray = bitArray.And(new BitArray(new bool[] { true, true, false, false, true }));
        Console.WriteLine("\nBitwise AND result:");
        PrintBitArray(andArray);

        // Bitwise OR
        BitArray orArray = bitArray.Or(new BitArray(new bool[] { false, true, false, true, false }));
        Console.WriteLine("\nBitwise OR result:");
        PrintBitArray(orArray);

        // Bitwise XOR
        BitArray xorArray = bitArray.Xor(new BitArray(new bool[] { true, false, true, false, true }));
        Console.WriteLine("\nBitwise XOR result:");
        PrintBitArray(xorArray);

        // Bitwise NOT
        BitArray notArray = bitArray.Not();
        Console.WriteLine("\nBitwise NOT result:");
        PrintBitArray(notArray);

        // Changing length
        bitArray.Length = 10;
        Console.WriteLine("\nBitArray after changing length to 10:");
        PrintBitArray(bitArray);
    }

    static void PrintBitArray(BitArray bitArray)
    {
        foreach (bool bit in bitArray)
        {
            Console.Write(bit ? "1" : "0");
        }
        Console.WriteLine();
    }
}
