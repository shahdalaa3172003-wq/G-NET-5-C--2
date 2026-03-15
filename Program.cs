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
    }
}
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
region Q3
  //  Write the syntax for declaring a constant in C#. Why would you use 
  //    a constant instead of a regular variable?
  // Standard syntax: const [type] [name] = [value];
  //const double Pi = 3.14159;
  //const string Greeting = "Hello, World!";
  //const int MaxPlayers = 10;
  //Use const for values that never change to prevent bugs, improve readability, and boost performance.
#endregion