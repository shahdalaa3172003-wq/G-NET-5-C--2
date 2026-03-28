//Q1: Explain with code example how class and struct behave differently .
//    class is a reference type 
//    struct is a value type
//using System;
//using System.Security.AccessControl;

//class Car
//{
//    public string Model;
//}

//struct Point
//{
//    public int X;
//}

//class Program
//{
//    static void Main()
//    {
//        // Class Example
//        Car c1 = new Car();
//        c1.Model = "BMW";

//        Car c2 = c1;
//        c2.Model = "Audi";

//        Console.WriteLine("Class Example:");
//        Console.WriteLine(c1.Model);
//        Console.WriteLine(c2.Model); 

//        // Struct Example
//        Point p1;
//        p1.X = 10;

//        Point p2 = p1;
//        p2.X = 20;

//        Console.WriteLine("\nStruct Example:");
//        Console.WriteLine(p1.X); 
//        Console.WriteLine(p2.X); 
//    }
//}


// Q2 : Explain the difference between public and private access modifiers with an example. 
//public : accessible from anywhere
//private: accessible only inside the same class
//using System;

//class BankAccount
//{
//    public string Owner;
//    private double Balance;

//    public BankAccount(string owner, double balance)
//    {
//        Owner = owner;
//        Balance = balance;
//    }

//    public void ShowBalance()
//    {
//        Console.WriteLine($"Balance: {Balance}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount("Ahmed", 5000);

//        account.Owner = "Ali"; // Allowed
//        Console.WriteLine(account.Owner);

//        // account.Balance = 10000; // Error: Balance is private

//        account.ShowBalance();
//    }
//}
//Q3 : Describe the steps to create and use a class library in Visual Studio.

//Open Visual Studio
//Create a new Class Library project
//Add classes and methods inside it
//Build the project to generate a DLL
//Create another project (like a Console App)
//Add a reference to the class library
//Use its classes and methods in the new project

//Q4: What is a class library? Why do we use class libraries?
//class library is a collection of reusable classes and methods in C#.
//It does not run by itself because it has no Main() method.
//    To reuse code
//To keep projects organized
//To make code easier to maintain

//part2

using System;

enum TicketType
{
    Standard,
    VIP,
    IMAX
}

struct Seat
{
    public char Row;
    public int Number;

    public Seat(char row, int number)
    {
        Row = row;
        Number = number;
    }

    public override string ToString()
    {
        return $"{Row}{Number}";
    }
}

class Ticket
{
    public string MovieName;
    public TicketType Type;
    public Seat Seat;

    private double Price;

    public Ticket(string movieName, TicketType type, Seat seat, double price)
    {
        MovieName = movieName;
        Type = type;
        Seat = seat;
        Price = price;
    }

    public Ticket(string movieName)
        : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
    {
    }

    public double CalcTotal(double taxPercent)
    {
        return Price + (Price * taxPercent / 100);
    }

    public void ApplyDiscount(ref double discountAmount)
    {
        if (discountAmount > 0 && discountAmount <= Price)
        {
            Price -= discountAmount;
            discountAmount = 0;
        }
    }

    public void PrintTicket()
    {
        Console.WriteLine("===== Ticket Info =====");
        Console.WriteLine($"Movie : {MovieName}");
        Console.WriteLine($"Type  : {Type}");
        Console.WriteLine($"Seat  : {Seat}");
        Console.WriteLine($"Price : {Price:F2}");
        Console.WriteLine($"Total (14% tax) : {CalcTotal(14):F2}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Movie Name: ");
        string movie = Console.ReadLine();

        Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX): ");
        int typeInput = int.Parse(Console.ReadLine());

        Console.Write("Enter Seat Row (A, B, C...): ");
        char row = char.Parse(Console.ReadLine());

        Console.Write("Enter Seat Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter Discount Amount: ");
        double discount = double.Parse(Console.ReadLine());

        Ticket t = new Ticket(
            movie,
            (TicketType)typeInput,
            new Seat(row, number),
            price
        );

        t.PrintTicket();

        Console.WriteLine("\n===== After Discount =====");
        double before = discount;

        t.ApplyDiscount(ref discount);

        Console.WriteLine($"Discount Before : {before:F2}");
        Console.WriteLine($"Discount After  : {discount:F2}");

        t.PrintTicket();
    }
}