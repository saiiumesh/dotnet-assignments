using System;
namespace calculator;
public class calculator_app
{
    public static void Main()
    {
        Console.WriteLine("Enter 1st number:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd number:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition: {0}", a + b);
        Console.WriteLine("Subtraction: {0}", a - b);
        Console.WriteLine("Multiplication: {0}", a * b);
        Console.WriteLine("Division: {0}", a / b);
    }
}