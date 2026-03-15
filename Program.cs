using System;
using System.Text.RegularExpressions;

internal class Program
{
  public static void Main(string[] args)
    {
        #region Q1
        // Q: What is the purpose of #region and #endregion directives in C#? 
        //    How do they help in code organization? 
        //an
        //How they help in code organization:

        //        Group related code such as variables, methods, or properties.

        //Improve readability by reducing visible code when sections are collapsed.

        //Make navigation easier in large files.

        //Keep code structured and organized during development.
        #endregion
        #region Q2

        //What is the difference between explicit and implicit variable
        //    declaration in C#? Provide examples of both.
        //an
        //1. Explicit Declaration

        //You manually specify the exact data type.
        //Syntax: int age = 25;

        //2. Implicit Declaration

        //You use the var keyword, and the compiler infers the type based on the value.

        //Syntax: var age = 25;

        // Explicit
        //string message = "Hello";

        // Implicit
        //var message = "Hello";

        #endregion
        #region Q3
        //  Write the syntax for declaring a constant in C#. Why would you use 
        //    a constant instead of a regular variable?
        // Standard syntax: const [type] [name] = [value];
        //const double Pi = 3.14159;
        //const string Greeting = "Hello, World!";
        //const int MaxPlayers = 10;
        //Use const for values that never change to prevent bugs, improve readability, and boost performance.
        #endregion
        #region Q4
        // Explain the difference between class-level scope and method-level
        //    scope with examples.
        //    Class - level variables are accessible to the entire class, 
        //while method-level variables exist only inside the specific method where they are declared.
        //    public class Calculator
        //{
        //    public void CalculateTotal()
        //    {
        //        int taxAmount = 5;
        //        Console.WriteLine(taxAmount);
        //    }

        //    public void ShowTax()
        //    {
        //    }
        //}
        #endregion
        #region Q5
        // Q: What is block-level scope? Give an example showing a variable that 
        //    is only accessible within a specific block.
        //A block-level variable is restricted to the specific set of braces { } where it was created.
        //public void ProcessData(int value)
        //{
        //    if (value > 10)
        //    {
        //        string message = "Value is high!";
        //        Console.WriteLine(message);
        //    }

        //}
        #endregion
        #region Q6
        // What is variable lifetime ? Explain the lifetime of local variables
        //    vs static variables.
        // Local Variables: Born when the method starts and die when the method ends.
        //void SayHi()
        //{
        //    string msg = "Hello"; 
        //    Console.WriteLine(msg);
        //} 
        //Static Variables: Born when the program starts and stay alive until the program closes.
        //      public class Tracker
        //{
        //    public static int TotalCount = 0; 
        #endregion
        #region Q7
        // Q: What is the Garbage Collector in C#? How does it affect the 
        //    lifetime of objects?
        //The Garbage Collector(GC) is an automatic memory manager in C#.
        //    It identifies and deletes objects that are no longer being used by your program to free up RAM.
        #endregion
        #region Q8
        // Q: What is variable shadowing in C#? Does C# allow shadowing in 
        //    nested blocks within the same method?
        //Shadowing occurs when a variable declared in a local scope(like a method) has the same name as a variable in a higher scope(like a class field).
        //The local variable "hides" or "shadows" the class-level one.
        //No.Unlike some other languages (like C++ or Java),
        //C# strictly forbids declaring a variable in a nested block (like an if or for) if that name is already used in the same method.
        //This is a safety feature to prevent confusion.
        #endregion
        #region Q9
        //  List five rules that must be followed when naming variables in C#.

        //    Must Start with a Letter or Underscore: A variable name cannot start with a number. It must begin with an uppercase/ lowercase letter or an underscore _.

        //   No Spaces Allowed: Variables must be a single continuous string of characters.For multiple words, use PascalCase or camelCase.

        //  No Reserved Keywords: You cannot use words that C# already uses for its own logic, such as int, class, static, or void (unless you prefix them with @, like @class).

        // Case Sensitivity: C# is case-sensitive. myValue and MyValue are treated as two completely different variables in memory.

        //Only Alphanumeric and Underscore: You cannot use special symbols like @, #, $, or % anywhere in the name (except for the underscore).
        #endregion
        #region Q10
        // Q: What naming conventions are recommended for: (a) local variables, 
        //    (b) class names, (c) constants?
        //For local variables, use camelCase(e.g., itemCount) to keep them distinct from class members. 
        //Class names must use PascalCase(e.g., UserManager) for clear structural hierarchy.While some legacy code uses UPPER_CASE, 
        //Microsoft's standard for Constants is also PascalCase (e.g., MaxRetryCount) to ensure 
        //they are easily readable and consistent with public properties.
        #endregion
        #region Q11
        //Syntax errors occur during coding when "grammar" rules are broken(e.g., a missing semicolon), 
        //preventing the program from even starting. Runtime errors happen while the program is executing, causing a sudden 
        //crash due to illegal operations(e.g., dividing by zero). Logical errors are the most deceptive; the program runs 
        //perfectly without crashing, but produces the wrong output because of 
        //    a flaw in the developer's math or reasoning (e.g., using + instead of *).
        #endregion
         #region Q12
         //Exception handling is vital in C# because it allows a program to gracefully 
         //recover from unexpected errors (like a missing file or lost internet) instead of crashing. Without it, any unhandled
         //error triggers a fatal crash, immediately terminating the application and providing a poor user experience—or
         //worse, leaving data in a corrupted, half-saved state.
         #endregion
         #region Q13
          //           The try-catch-finally block is the standard way to handle "dangerous" code that might cause a crash.
          //             try
          // {
          //     int numerator = 10;
          //     int denominator = 0;
          //     int result = numerator / denominator; 
          //     Console.WriteLine("Result: " + result);
          // }
          // catch (DivideByZeroException ex)
          // {
          //     Console.WriteLine("Error: You cannot divide by zero! " + ex.Message);
          // }
          // finally
          // {
          //     Console.WriteLine("Cleanup: Closing connections or finishing the process.");
          // }
                    
         #endregion
          #region Q14
           // In C#, NullReferenceException occurs when accessing a member of a null object,
           // while IndexOutOfRangeException happens when accessing an array index that doesn't exist.
           //  DivideByZeroException is triggered by illegal math operations, FileNotFoundException arises when a specified disk file is missing, 
           //  and InvalidCastException occurs during a failed type conversion. Each of these ensures the program fails predictably rather than continuing with 
           //  corrupted data.
          
          #endregion
           #region Q15
//           The order of catch blocks is critical because C# processes them from top to 
//           bottom and executes the first one that matches the thrown exception. Since exception classes use inheritance, a more general 
//           exception (like the base Exception class) will "catch" everything, potentially preventing more specific handlers from ever running.

// The Rule: Specific to General
// You must always place specific exceptions (the "children") before general exceptions (the "parents"). 
// If you put catch (Exception ex) at the top, the compiler will actually throw an error because the subsequent, more specific blocks become "unreachable."

// try
// {
//     int[] numbers = { 1, 2, 3 };
//     int result = numbers[10] / 0; 
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("Math error: Cannot divide by zero.");
// }

// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine("Array error: Index was out of bounds.");
// }

// catch (Exception ex)
// {
//     Console.WriteLine("An unexpected error occurred: " + ex.Message);
// }
            #endregion
          
       



    }

}
    
