using System;

class ControlFlowExample
{
    static void Main()
    {
        // If-else statement
        int a = 10;
        if (a > 5)
        {
            Console.WriteLine("a is greater than 5");
        }
        else
        {
            Console.WriteLine("a is not greater than 5");
        }

        // Switch statement
        int option = 2;
        switch (option)
        {
            case 1:
                Console.WriteLine("Option 1 selected");
                break;
            case 2:
                Console.WriteLine("Option 2 selected");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

        // While loop
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine($"While loop iteration {i}");
            i++;
        }

        // Do-while loop
        int j = 0;
        do
        {
            Console.WriteLine($"Do-while loop iteration {j}");
            j++;
        } while (j < 5);

        // For loop
        for (int k = 0; k < 5; k++)
        {
            Console.WriteLine($"For loop iteration {k}");
        }

        // Foreach loop (on an array)
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)
        {
            Console.WriteLine($"Foreach loop iteration {num}");
        }

        // Method call
        SayHello("Alice");

        // Method with return value
        int sum = AddNumbers(3, 5);
        Console.WriteLine($"Sum of 3 and 5 is {sum}");
    }

    // Example method
    static void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    // Example method with return value
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}
