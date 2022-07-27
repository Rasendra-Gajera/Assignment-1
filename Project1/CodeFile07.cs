//7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
using System;
class Exercise7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
    }
}
