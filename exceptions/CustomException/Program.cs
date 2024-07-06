
public class MyCustomException : Exception
{
    // Constructor that takes a message and passes it to the base Exception class
    public MyCustomException(string message) : base(message)
    {
    }

    // You can add more custom properties and methods as needed
    public int ErrorCode { get; set; }
}
class Program
{
    static void Main()
    {
        DataProcessor processor = new DataProcessor();

        try
        {
            processor.ProcessData(-1);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught: {ex.Message} and error code is  {ex.ErrorCode}");
            // Handle the exception, log, or perform any necessary actions
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
public class DataProcessor
{
    public void ProcessData(int value)
    {
        if (value < 0)
        {
            throw new MyCustomException("Value cannot be negative");
        }
        // Process the data
    }
}