using System;
using System.Net.NetworkInformation;
using System.Threading;


//Threads are the backbone of any software application. In simple terms,
//    a thread is a single sequence of instructions that a process can execute.
//    In C#, the System.Threading namespace offers classes that allow you to manipulate threads. 


public class Program
{
    public static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    private static readonly object _lock = new object();
    private static int _counter = 0;

    public static void IncrementCounter()
    {
        for (int i = 0; i < 5; i++)
        {
            lock (_lock)
            {
                _counter++;
                Console.WriteLine($"Counter: {_counter}");
            }
            Thread.Sleep(500);
        }
    }

    public static void Main()
    {
        Thread newThread = new(PrintNumbers);
       // newThread.Start();

        // Main thread continues while newThread runs
        Console.WriteLine("Main thread does some work, then waits.");
      //
      //newThread.Join(); // Wait for newThread to finish
        Console.WriteLine("New thread has finished.");


        //When multiple threads access shared resources, you need to ensure thread safety.This can be achieved using locks.
        Thread thread1 = new Thread(IncrementCounter);
        Thread thread2 = new Thread(IncrementCounter);

        thread1.Start();
        Console.WriteLine("first thread started.");
        thread2.Start();
        Console.WriteLine("second thread started.");
        thread1.Join();
        Console.WriteLine("first thread joined.");
        thread2.Join();
        Console.WriteLine("second thread joined.");
        Console.WriteLine("Both threads have finished.");


      //  Using the Task class from the System.Threading.Tasks namespace is often preferred over directly using Thread.
            Task.Run(() =>
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i);
                    Task.Delay(1000).Wait();
                }
            }).Wait();
       

}
}