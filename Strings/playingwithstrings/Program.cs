using System;

public class StringMethodsExample
{
    public static void Main()
    {
        string originalString = "   Hello, World!   ";

        // Accessing Characters and Substrings
        char firstChar = originalString[0];  // ' '
        string substring1 = originalString.Substring(3);  // "Hello, World!   "
        string substring2 = originalString.Substring(3, 5);  // "Hello"
        char[] charArray = originalString.ToCharArray();  // [' ', ' ', ' ', 'H', 'e', 'l', 'l', 'o', ',', ' ', 'W', 'o', 'r', 'l', 'd', '!', ' ', ' ', ' ']

        // Case Conversion
        string upperCaseString = originalString.ToUpper();  // "   HELLO, WORLD!   "
        string lowerCaseString = originalString.ToLower();  // "   hello, world!   "

        // Checking Conditions
        bool containsWorld = originalString.Contains("World");  // true
        bool endsWithExclamation = originalString.EndsWith("!");  // true
        bool startsWithHello = originalString.StartsWith("Hello");  // false
        bool isNullOrEmpty = string.IsNullOrEmpty(originalString);  // false
        bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(originalString);  // false

        // Indexing and Searching
        int indexOfComma = originalString.IndexOf(',');  // 7
        int lastIndexOfSpace = originalString.LastIndexOf(' ');  // 15
        int indexOfHello = originalString.IndexOf("Hello");  // 3
        int lastIndexOfWorld = originalString.LastIndexOf("World");  // 10

        // Manipulating Strings
        string concatenatedString = string.Concat("Hello", "World");  // "HelloWorld"
        string insertedString = originalString.Insert(5, "Beautiful ");  // "   Hello, Beautiful World!   "
        string paddedLeftString = originalString.PadLeft(20);  // "     Hello, World!   "
        string paddedRightString = originalString.PadRight(20);  // "   Hello, World!     "
        string removedString = originalString.Remove(3);  // "Hello, World!   "
        string replacedString = originalString.Replace("Hello", "Greetings");  // "   Greetings, World!   "

        // Splitting and Joining
        string[] splitString = originalString.Split(',');  // ["   Hello", " World!   "]
        string[] splitStringWithOptions = originalString.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);  // ["Hello,", "World!"]
        string joinedString = string.Join("-", splitStringWithOptions);  // "Hello--World!"

        // Formatting and Manipulating Strings (Static methods)
        string formattedString = string.Format("My name is {0}.", "Alice");  // "My name is Alice."
        int compareResult1 = string.Compare("abc", "ABC", StringComparison.OrdinalIgnoreCase);  // 0
        int compareResult2 = string.CompareOrdinal("abc", "ABC");  // 32

        // Comparing Strings
        bool isEqual = originalString.Equals("   Hello, World!   ");  // true
        bool isEqualIgnoreCase = originalString.Equals("   hello, world!   ", StringComparison.OrdinalIgnoreCase);  // true

        // Miscellaneous
        string internedString = string.Intern(originalString);  // "   Hello, World!   "
        string internedString2 = string.IsInterned(originalString);  // "   Hello, World!   "

        // Output results
        Console.WriteLine($"Original String: '{originalString}'");
        Console.WriteLine($"First Character: '{firstChar}'");
        Console.WriteLine($"Substring from index 3: '{substring1}'");
        Console.WriteLine($"Substring from index 3 with length 5: '{substring2}'");
        Console.WriteLine($"Character Array: '{string.Join(", ", charArray)}'");
        Console.WriteLine($"Uppercase String: '{upperCaseString}'");
        Console.WriteLine($"Lowercase String: '{lowerCaseString}'");
        Console.WriteLine($"Contains 'World'?: {containsWorld}");
        Console.WriteLine($"Ends with '!': {endsWithExclamation}");
        Console.WriteLine($"Starts with 'Hello': {startsWithHello}");
        Console.WriteLine($"Is Null or Empty: {isNullOrEmpty}");
        Console.WriteLine($"Is Null or WhiteSpace: {isNullOrWhiteSpace}");
        Console.WriteLine($"Index of ',': {indexOfComma}");
        Console.WriteLine($"Last Index of ' ': {lastIndexOfSpace}");
        Console.WriteLine($"Index of 'Hello': {indexOfHello}");
        Console.WriteLine($"Last Index of 'World': {lastIndexOfWorld}");
        Console.WriteLine($"Concatenated String: '{concatenatedString}'");
        Console.WriteLine($"Inserted String: '{insertedString}'");
        Console.WriteLine($"Left Padded String: '{paddedLeftString}'");
        Console.WriteLine($"Right Padded String: '{paddedRightString}'");
        Console.WriteLine($"Removed String: '{removedString}'");
        Console.WriteLine($"Replaced String: '{replacedString}'");
        Console.WriteLine($"Split String:");
        foreach (var item in splitString)
        {
            Console.WriteLine($"- '{item}'");
        }
        Console.WriteLine($"Split String with options:");
        foreach (var item in splitStringWithOptions)
        {
            Console.WriteLine($"- '{item}'");
        }
        Console.WriteLine($"Joined String: '{joinedString}'");
        Console.WriteLine($"Formatted String: '{formattedString}'");
        Console.WriteLine($"Compare Result (ignore case): {compareResult1}");
        Console.WriteLine($"Compare Ordinal Result: {compareResult2}");
        Console.WriteLine($"Is Equal: {isEqual}");
        Console.WriteLine($"Is Equal (ignore case): {isEqualIgnoreCase}");
        Console.WriteLine($"Interned String: '{internedString}'");
        Console.WriteLine($"Is Interned String: '{internedString2}'");

        Console.ReadLine();
    }
}
