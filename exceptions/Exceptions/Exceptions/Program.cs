using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;
using System.Xml;
using System.Collections;

namespace ExceptionHandlingDemo
{
   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HandleExceptions();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Exception: {ex.GetType()}: {ex.Message}");
            }
        }

        static void HandleExceptions()
        {
            try
            {
                // SystemException
                throw new SystemException("SystemException occurred.");
            }
            catch (SystemException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // ArgumentException
                throw new ArgumentException("ArgumentException occurred.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                string id = null;
                int ans = int.Parse(id);
                //  throw new ArgumentNullException("ArgumentNullException occurred.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // ArgumentOutOfRangeException
                PrintArrayElement(new int[] { 1, 2, 3, 4, 5 }, 10);
                //throw new ArgumentOutOfRangeException("ArgumentOutOfRangeException occurred.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // ArithmeticException
                throw new ArithmeticException("ArithmeticException occurred.");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // DivideByZeroException
                int zero = 0;
                int result = 1 / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // OverflowException
                checked
                {
                    int maxInt = int.MaxValue;
                    int overflow = maxInt + 1;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // ArrayTypeMismatchException
                object[] objects = new string[1];
                objects[0] = 1;
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // BadImageFormatException
               
                LoadAssembly("InvalidAssembly.dll");
            }
            catch (BadImageFormatException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
            try
            {
                // FormatException
                int.Parse("InvalidInteger");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // IndexOutOfRangeException
                int[] array = new int[1];
                Console.WriteLine(array[2]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // InvalidCastException
                object obj = "String";
                int invalidCast = (int)obj;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // InvalidOperationException
                ProcessQueue();
                //throw new InvalidOperationException("InvalidOperationException occurred.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // NullReferenceException
                object nullObject = null;
                nullObject.ToString();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // OutOfMemoryException
                //throw new OutOfMemoryException("OutOfMemoryException occurred.");
                int[] largeArray = new int[int.MaxValue];
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

         

            try
            {
                 throw new TypeInitializationException("TypeName", new Exception("Inner exception"));
            }
            catch (TypeInitializationException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // IOException
                throw new IOException("IOException occurred.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // DirectoryNotFoundException
                Directory.GetFiles("NonExistentDirectory");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Exception: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // FileNotFoundException
                File.ReadAllText("NonExistentFile.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Exception: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // PathTooLongException
                string longPath = new string('a', 260);
                File.ReadAllText(longPath);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Exception: {ex.GetType()}: {ex.Message}");
            }


            try
            {
                // EndOfStreamException
                using (var stream = new MemoryStream())
                using (var reader = new StreamReader(stream))
                {
                    reader.ReadToEnd();
                }
            }
            catch (EndOfStreamException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Exception: {ex.GetType()}: {ex.Message}");
            }
            try
            {
                // ThreadAbortException
                Thread thread = new Thread(() => { Thread.Sleep(1000); });
                thread.Start();
                thread.Abort();
                thread.Join();
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // ThreadInterruptedException
                Thread thread = new Thread(() => { Thread.Sleep(1000); });
                thread.Start();
                thread.Interrupt();
                thread.Join();
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // ThreadStateException
                Thread thread = new Thread(() => { });
                thread.Start();
                thread.Start();
            }
            catch (ThreadStateException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // SecurityException
                throw new SecurityException("SecurityException occurred.");
            }
            catch (SecurityException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // UnauthorizedAccessException
                File.Open("Errors and Exceptions.docx", FileMode.Open, FileAccess.ReadWrite);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Exception: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // AmbiguousMatchException
                typeof(Program).GetMethod("HandleExceptions", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            }
            catch (AmbiguousMatchException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // TargetException
                MethodInfo method = typeof(Program).GetMethod("HandleExceptions");
                method.Invoke(null, new object[] { });
            }
            catch (TargetException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // TargetInvocationException
                typeof(Program).InvokeMember("NonExistentMethod", BindingFlags.InvokeMethod, null, new Program(), null);
            }
            catch (TargetInvocationException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // TargetParameterCountException
                MethodInfo method = typeof(Program).GetMethod("HandleExceptions");
                method.Invoke(null, new object[] { "ExtraParameter" });
            }
            catch (TargetParameterCountException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // SerializationException
                throw new SerializationException("SerializationException occurred.");
            }
            catch (SerializationException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

         

            try
            {
                // WebException
                throw new WebException("WebException occurred.");
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // XmlException
                throw new XmlException("XmlException occurred.");
            }
            catch (XmlException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // NotSupportedException
                throw new NotSupportedException("NotSupportedException occurred.");
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // KeyNotFoundException
                var dictionary = new Dictionary<int, string>();
                string value = dictionary[1];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // TimeoutException
                throw new TimeoutException("TimeoutException occurred.");
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }

            try
            {
                // InvalidTimeZoneException
                throw new InvalidTimeZoneException("InvalidTimeZoneException occurred.");
            }
            catch (InvalidTimeZoneException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
            try
            {
                // StackOverflowException
                RecursiveMethod();
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine($"Caught: {ex.GetType()}: {ex.Message}");
            }
        }

        static void RecursiveMethod()
        {
            RecursiveMethod();
        }

        static void PrintArrayElement(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), index, "Index is out of range");
            }

            Console.WriteLine($"Element at index {index}: {array[index]}");
        }

        static void ProcessQueue()
        {
            Queue<int> queue = new Queue<int>();

            // Uncomment the following line to add an item to the queue
            // queue.Enqueue(1);

            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Cannot dequeue from an empty queue.");
            }

            int item = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {item}");
        }


        static void LoadAssembly(string assemblyPath)
        {
            try
            {
                // Attempt to load an assembly
                Assembly assembly = Assembly.LoadFrom(assemblyPath);
            }
            catch (BadImageFormatException ex)
            {
                // Handle the exception if the assembly is not valid
                throw new BadImageFormatException($"The file '{assemblyPath}' is not a valid assembly.", ex);
            }
        }


    }
  
}
