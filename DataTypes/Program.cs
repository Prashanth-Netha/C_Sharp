using System;

class Program
{
    public static void Main(string[] args)
    {
        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99D;  // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";
        float myfloat = 2.55f;
        Console.WriteLine($"{myText} \n {myNum} \n {myLetter} \n {myBool} \n {myDoubleNum} \n {myfloat}");

        //Data Conversions
        // implicit conversion

        float convertedint = myNum;
        Console.WriteLine("converted int to float " + convertedint);
        double converteddouble = myNum;
         Console.WriteLine("converted int to double " + converteddouble);
        double convertedtodouble = myfloat;
        Console.WriteLine("float converted to double " + converteddouble);

        // explici conversions

        // Numeric Conversions
        double d = 1234.56;
        int i = (int)d; // from double to int
        Console.WriteLine(i);

        long l = 9876543210;
        short s = (short)l; // from long to short
        Console.WriteLine(s);

        decimal dec = 100.5m;
        float f = (float)dec; // from decimal to float
        Console.WriteLine(f);

        // Integral Types to Smaller Integral Types
        uint ui = 300;
        byte b = (byte)ui; // from uint to byte
        Console.WriteLine(b);

        // Floating-point to Integral Types
        float fl = 123.45f;
        int intFromFloat = (int)fl; // from float to int
        Console.WriteLine(intFromFloat);

        // Reference Type Conversions
        object obj = "Hello, world!";
        string str = (string)obj; // from object to string
        Console.WriteLine(str);

        // Base to Derived (downcasting)
        Animal animal = new Dog();
        Dog dog = (Dog)animal; // from Animal to Dog
        dog.Bark();

        // Interface Conversions
        List<int> list = new List<int> { 1, 2, 3 };
        IEnumerable<int> enumerable = (IEnumerable<int>)list; // from List<int> to IEnumerable<int>
        foreach (var item in enumerable)
        {
            Console.WriteLine(item);
        }

        // Unboxing Conversions
        object boxedInt = 123;
        int unboxedInt = (int)boxedInt; // from object to int
        Console.WriteLine(unboxedInt);

        // User-defined Conversions
        var customType = new CustomType();
        int customToInt = (int)customType; // explicit user-defined conversion from CustomType to int
        Console.WriteLine(customToInt);

        //parsing methods  is used to convert a string to specific datatype

        int number = int.Parse("123");
        double floatingPoint = double.Parse("123.45");
        DateTime date = DateTime.Parse("2024-06-25");
        bool flag = bool.Parse("true");

        /*  TRY parse
         * These methods attempt to convert a string representation 
         * of a value to a specific type. They return a boolean indicating whether
         * the conversion was successful, and they do not throw exceptions on failure.
         * */
        if (int.TryParse("123", out int number1))
        {
            Console.WriteLine($"Parsed number: {number1}");
        }
        else
        {
            Console.WriteLine("Failed to parse number.");
        }

        //To string
        int number2 = 123;
        string numberString = number2.ToString();

        DateTime date2 = DateTime.Now;
        string dateString = date2.ToString("yyyy-MM-dd");

        //convert
/*
 * The Convert class provides methods to convert between different types.

Convert.ToInt32(object): Converts an object to an integer.
Convert.ToDouble(object): Converts an object to a double.
Convert.ToBoolean(object): Converts an object to a boolean.
Convert.ToDateTime(object): Converts an object to a DateTime.
*/

string numberString1 = "123";
int number3 = Convert.ToInt32(numberString1);

string floatingPointString = "123.45";
double floatingPoint1 = Convert.ToDouble(floatingPointString);

string booleanString = "true";
bool flag1 = Convert.ToBoolean(booleanString);

string dateString3 = "2024-06-25";
DateTime date3 = Convert.ToDateTime(dateString);


}

}
class Animal { }

class Dog : Animal
{
public void Bark()
{
Console.WriteLine("Woof!");
}
}

class CustomType
{
public static explicit operator int(CustomType ct)
{
return 42;
}
}