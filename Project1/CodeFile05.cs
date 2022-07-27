//5. Write a C# Sharp program to swap two numbers…..
using System;
class SwapExample
{
    static void Main()
    {
        int a = 5, b = 6;
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a * b; //a=30 (5*6)      
        b = a / b; //b=6 (30/6)      
        a = a / b; //a=6 (30/5)    
        Console.WriteLine("After swap a= " + a + " b= " + b);
    }
}
