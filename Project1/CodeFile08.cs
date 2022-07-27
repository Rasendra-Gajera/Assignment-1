//8. Write a C# Sharp program that takes a number as input and print its multiplication table…
using System;
class Exercise8
{
     static void Main()
    {
        int j, n;
        Console.Write("Input the number : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n");
        for (j = 1; j <= 10; j++)
        {
            Console.Write("{0} X {1} = {2} \n", n, j, n * j);
        }
    }
}
