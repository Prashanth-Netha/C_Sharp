using System;

class Program
{
    static void Main()
    {
        try
        {
            // Code that may throw an exception
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]);  // Accessing an index that doesn't exist
        }
        catch (IndexOutOfRangeException ex)
        {
            // Catch block to handle specific exception types
            Console.WriteLine($"Index out of range exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Catch block to handle any other exceptions
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            // Finally block for cleanup actions, always executed
            Console.WriteLine("Inside finally block");
        }

        // Code continues after the try-catch-finally block
        Console.WriteLine("Program continues after exception handling");
    }
}


//try: Contains the code that may throw exceptions, such as accessing an array index out of range.
//catch: Handles specific exceptions(IndexOutOfRangeException in this case) and more general exceptions(Exception).
//finally: Executes cleanup code, regardless of whether an exception was thrown or caught.