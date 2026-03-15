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
    }
}