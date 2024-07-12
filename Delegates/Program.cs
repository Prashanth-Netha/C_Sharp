using System;

public class Program
{
    // Declare a delegate
    public delegate void Test(string message);

    // Method that matches the delegate signature
    public static void HelloMessage(string message)
    {
        Console.WriteLine("Hello, " + message);
    }
    public static void GreetMessage(string message)
    {
        Console.WriteLine("Good Morning, " + message);
    }

    public static void ByeMessage(string message)
    {
        Console.WriteLine("Bye, " + message);
    }

    public  class testprogram
    {
        Test t1;

        public void test(Test t ) {
            this.t1 = t;

            t1("prashanth");
         }
    }

    public static void Main()
    {
        // Instantiate the delegate
        Test messageDelegate = new Test(HelloMessage);
        messageDelegate += GreetMessage;
        messageDelegate += ByeMessage;

        testprogram testprogram = new testprogram();
            testprogram.test(messageDelegate);

        // Call the delegate
        messageDelegate("World");
    }
}
