1. write a c# sharp program to print hello and your name in a separate line.
using system;


class pro1
{
    static void main()
    {
        console.writeline("hello_world..... ");

    }
}

2. write a c# sharp program to print the sum of two numbers.
using system;
class example
{
    static void main()
    {
        int a = 10, b = 20, c;
        c = a + b;
        console.writeline("sum of " + c);
    }
}

3. write a c# sharp program to print the result of dividing two numbers.
using system;
class example
{
    static void main()
    {
        int b = 20;
         float a = 10, c;
        c = a / b;
        console.writeline("result " + c);
    }
}


4. write a c# sharp program to print the result of the specified operations.
test data: 
•	-1 + 4 * 6
•	  ( 35+ 5 ) % 7
•	  14 + -4 * 6 / 11
•	2 + 15 / 6 * 1 - 7 % 2
•	
using system;
class exercise4
{
     static void main()
    {
        console.writeline(-1 + 4 * 6);
        //-1 + 24 = 23
       console.writeline((35 + 5) % 7);
        //40 % 7 = 5 (remainder of 40/7)
        console.writeline(14 + -4 * 6 / 11);
        //14 - (24/11)= 14 - 2 = 12
        console.writeline(2 + 15 / 6 * 1 - 7 % 2);
        //2 + (15/6) - remainder of (7/2) = 2 + 2 - 1 = 4 - 1 = 3
    }
}

5. write a c# sharp program to swap two numbers…..

using system;
 class swapexample
{
     static void main()
    {
        int a = 5, b = 6;
        console.writeline("before swap a= " + a + " b= " + b);
        a = a * b; //a=30 (5*6)      
        b = a / b; //b=6 (30/6)      
        a = a / b; //a=6 (30/5)    
        console.write("after swap a= " + a + " b= " + b);
    }
}

6. write a c# sharp program to print the output of multiplication of three numbers which will be entered by the user.
using system;
 class exercise6
{
     static void main()
    {
        int num1, num2, num3;

        console.write("input the first number to multiply: ");
        num1 = convert.toint32(console.readline());

        console.write("input the second number to multiply: ");
        num2 = convert.toint32(console.readline());

        console.write("input the third number to multiply: ");
        num3 = convert.toint32(console.readline());

        int result = num1 * num2 * num3;
        console.writeline("output: {0} x {1} x {2} = {3}",
                            num1, num2, num3, result);
    }
}



7. write a c# sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.

using system;
 class exercise7
{
     static void main()
    {
        console.write("enter a number: ");
        int num1 = convert.toint32(console.readline());

        console.write("enter another number: ");
        int num2 = convert.toint32(console.readline());

        console.writeline("{0} + {1} = {2}", num1, num2, num1 + num2);
        console.writeline("{0} - {1} = {2}", num1, num2, num1 - num2);
        console.writeline("{0} x {1} = {2}", num1, num2, num1 * num2);
        console.writeline("{0} / {1} = {2}", num1, num2, num1 / num2);
        console.writeline("{0} mod {1} = {2}", num1, num2, num1 % num2);
    }
}


8. write a c# sharp program that takes a number as input and print its multiplication table…
 using system;
public class exercise8
{
 public static void main()
 {
  int x;
  int result;

  console.writeline("enter a number:");
  x = convert.toint32(console.readline() );

  result = x * 1;
  console.writeline("the table is : {0} x {1} = {2}", x, 1, result);
  result = x * 2;
  console.writeline("             : {0} x {1} = {2}", x, 2, result);
  result = x * 3;
  console.writeline("             : {0} x {1} = {2}", x, 3, result);
  result = x * 4;
  console.writeline("             : {0} x {1} = {2}", x, 4, result);
  result = x * 5;
  console.writeline("             : {0} x {1} = {2}", x, 5, result);
  result = x * 6;
  console.writeline("             : {0} x {1} = {2}", x, 6, result);
  result = x * 7;
  console.writeline("             : {0} x {1} = {2}", x, 7, result);
  result = x * 8;
  console.writeline("             : {0} x {1} = {2}", x, 8, result);
  result = x * 9;
  console.writeline("             : {0} x {1} = {2}", x, 9, result);
  result = x * 10;
  console.writeline("             : {0} x {1} = {2}", x, 10, result);
 }
}

9. write a c# sharp program that takes four numbers as input to calculate and print the average….

using system;
using system.io;
 class exercise9
{
     static void main()
    {
        double number1, number2, number3, number4;

        console.write("enter the first number: ");
        number1 = convert.todouble(console.readline());

        console.write("enter the second number: ");
        number2 = convert.todouble(console.readline());

        console.write("enter the third number: ");
        number3 = convert.todouble(console.readline());

        console.write("enter the fourth number: ");
        number4 = convert.todouble(console.readline());

        double result = (number1 + number2 + number3 + number4) / 4;
        console.writeline("the average of {0}, {1}, {2}, {3} is: {4} ",
     number1, number2, number3, number4, result);
    }
}



10. write a c# sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z…….

using system;
public class exercise10
{
    public static void main()
    {
        int number1, number2, number3;

        console.write("enter first number - ");
        number1 = convert.toint32(console.readline());

        console.write("enter second number - ");
        number2 = convert.toint32(console.readline());

        console.write("enter third number - ");
        number3 = convert.toint32(console.readline());

        console.write("result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
            number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
    }
}


11. write a c# sharp program that takes an age (for example 20) as input and prints something as "you look older than 20"

using system;
 class dp
{
    static void main()
    {
        int age;
        console.write("enter your age ");
        age = convert.toint32(console.readline());
        console.write("you look older than {0} ", age);
    }
}


12. write a c# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. you should do it two times: use console. write and then use {0}.

using system;
class pro12
{
     static void main()
    {
        int num;

        console.writeline("enter a number: ");
        num = convert.toint32(console.readline());

        // part a: "num num num num" using write
        console.write(num);
        console.write(" ");
        console.write(num);
        console.write(" ");
        console.write(num);
        console.write(" ");
        console.write(num);
        console.writeline();

        // part b: "numnumnumnum" using write
        console.write(num);
        console.write(num);
        console.write(num);
        console.writeline(num);
        console.writeline();

        // part c: "num num num num" using {0}
        console.writeline("{0} {0} {0} {0}", num);

        // part d: "numnumnumnum" using {0}
        console.writeline("{0}{0}{0}{0}", num);
    }
}


13. write a c# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.

using system;
 class pro13
{
     static void main()
    {
        int x;

        console.write("enter a number: ");
        x = convert.toint32(console.readline());

        console.writeline("{0}{0}{0}", x);
        console.writeline("{0} {0}", x);
        console.writeline("{0} {0}", x);
        console.writeline("{0} {0}", x);
        console.writeline("{0}{0}{0}", x);
    }
}
14. write a c# program to convert from celsius degrees to kelvin and fahrenheit.

using system;
public class pro14
{
    public static void main()
    {
        console.write("enter the amount of celsius: ");
        int celsius = convert.toint32(console.readline());

        console.writeline("kelvin = {0}", celsius + 273);
        console.writeline("fahrenheit = {0}", celsius * 18 / 10 + 32);
    }
}



15. write a c# program remove specified a character from a non-empty string using index of a character

using system;


 class pro15
{
    static void main()
    {
        console.writeline(remove_char("atmiya university", 1));
        console.writeline(remove_char("atmiya university", 9));
        console.writeline(remove_char("atmiya university", 0));
    }
    public static string remove_char(string str, int n)
    {
        return str.remove(n, 1);
    }
}


16. write a c# program to create a new string from a given string (length 1 or more) with the first character added at the front and back

using system;


class pro16
{
    static void main()
    {
        string str;

        console.write("input a string : ");
        str = console.readline();
        if (str.length >= 1)
        {
            var s = str.substring(0, 1);
            console.writeline(s + str + s);
        }
    }
}



17. . write a c# program to check two given integers and return true if one is negative and one is positive.

using system;


 class pro17
{
    static void main()
    {
        console.writeline("\ninput first integer:");
        int x = convert.toint32(console.readline());
        console.writeline("input second integer:");
        int y = convert.toint32(console.readline());
        console.writeline("check if one is negative and one is positive:");
        console.writeline((x < 0 && y > 0) || (x > 0 && y < 0));
    }
}

18. write a c# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
using system;


public class pro18
{
    static void main()
    {
        console.writeline(sumtriple(2, 2));
        console.writeline(sumtriple(12, 10));
        console.writeline(sumtriple(-5, 2));
    }
    public static int sumtriple(int a, int b)
    {
        return a == b ? (a + b) * 3 : a + b;
    }
}

19. write a c# program to get the absolute value of the difference between two given numbers. return double the absolute value of the difference if the first number is greater than second number…
using system;


 class pro19
{
    static void main()
    {
        console.writeline(result(13, 40));
        console.writeline(result(50, 21));
        console.writeline(result(0, 23));
    }

    public static int result(int a, int b)
    {
        if (a > b)
        {
            return (a - b) * 2;
        }
        return b - a;
    }
}

20. . write a c# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.

using system;


 class pro20
{
    static void main()
    {
        int x, y;
        int result;

        console.writeline("\ninput an integer:");
        x = convert.toint32(console.readline());
        console.writeline("input another integer:");
        y = convert.toint32(console.readline());
        console.writeline(x == 20 || y == 20 || (x + y == 20));
    }
}

21. write a c# program to check if an given integer is within 20 of 100 or 200….

using system;

 class pro21
{
    static void main()
    {
        console.writeline("\ninput an integer:");
        int x = convert.toint32(console.readline());
        console.writeline(result(x));
    }

    public static bool result(int n)
    {
        if (math.abs(n - 100) <= 20 || math.abs(n - 200) <= 20)
            return true;
        return false;
    }
}

22. write a c# sharp program to display the following pattern using the alphabet.

using system;
 class pro22
{
     static void main()
    {
        string line = "write a c# sharp program to display the following pattern using the alphabet.";

        console.writeline(line.tolower());

    }
}


23. write a c# program to print the odd numbers from 1 to 99. prints one number per line.

using system;

 class pro23
{
     static void main()
    {
        console.writeline("odd numbers from 1 to 99. prints one number per line.");
        for (int n = 1; n < (99 + 1); n++)
        {
            if (n % 2 != 0)
            {
                console.writeline(n.tostring());
            }
        }
    }
}
24.. write a c# program to compute the sum of the first 500 prime numbers.

using system;
 class pro244
{
     static void main()
    {
        console.writeline("\nsum of the first 500 prime numbers: ");
        long sum = 0;
        int ctr = 0;
        int n = 2;
        while (ctr < 500)
        {
            if (isprime(n))
            {
                sum += n;
                ctr++;
            }
            n++;
        }

        console.writeline(sum.tostring());

    }
    public static bool isprime(int n)
    {
        int x = (int)math.floor(math.sqrt(n));

        if (n == 1) return false;
        if (n == 2) return true;

        for (int i = 2; i <= x; ++i)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}

25. write a c# program and compute the sum of the digits of an integer.

using system;
 class pro25
{
     static void main()
    {
        console.write("input  a number(integer): ");
        int n = convert.toint32(console.readline());
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        console.writeline("sum of the digits of the said integer: " + sum);
    }
}


26.  write a c# program to reverse the words of a sentence.

using system;
using system.linq;

class pro26
{
    static void main()
    {
        string text = "my girlfriend name is natasha patel";

        console.writeline(string.join(" ", text.split(' ').reverse()));
    }
}


27. write a c# program to find the size of a specified file in bytes.



28. write a c# program to convert a hexadecimal number to decimal number….

using system;

 class pro28
{
     static void main()
    {

        string hexval = "4b0";
        console.writeline("hexadecimal number: " + hexval);
        int decvalue = int.parse(hexval, system.globalization.numberstyles.hexnumber);
        console.writeline("convert to-");
        console.writeline("decimal number: " + decvalue);
    }
}

29.write a c# program to multiply corresponding elements of two arrays of integers.

using system;

 class pro29
{
     static void main()
    {
        int[] first_array = { 1, 3, -5, 4 };
        int[] second_array = { 1, 4, -5, -2 };

        console.writeline("\narray1: [{0}]", string.join(", ", first_array));
        console.writeline("array2: [{0}]", string.join(", ", second_array));

        console.writeline("\nmultiply corresponding elements of two arrays: ");

        for (int i = 0; i < first_array.length; i++)
        {

            console.write(first_array[i] * second_array[i] + " ");
        }
        console.writeline("\n");
    }
}


30. write a c# program to create a new string of four copies, taking last four characters from a given string. if the length of the given string is less than 4 return the original one…

using system;
using system.linq;

 class pro30
 {
  static void main()
        {
           string str; 
           int l= 0;
           console.write("input a string : ");
           str = console.readline();
           if (str.length>4)
           {
              console.writeline(str.length < 4 ? str + str + str : str.substring(str.length - 4)+ str.substring(str.length - 4) + str.substring(str.length - 4) + str.substring(str.length - 4));
           }
        }
}

31. write a c# program to check if a given positive number is a multiple of 3 or a multiple of 7.

using system;
using system.linq;

class pro31
{
    static void main()
    {
        console.writeline("\ninput first integer:");
        int x = convert.toint32(console.readline());
        if (x > 0)
        {
            console.writeline(x % 3 == 0 || x % 7 == 0);
        }
    }
}


32. write a c# program to check if a string starts with a specified word.

using system;
using system.linq;


 class pro32
    static void main()
    {
        string str;
        console.write("input a string : ");
        str = console.readline();
        console.writeline((str.length < 6 && str.equals("hello")) || (str.startswith("hello") && str[5] == ' '));
    }
}


33. write a c# program to check two given numbers where one is less than 100 and other is greater than 200.

using system;
using system.linq;

public class pro33
{
    static void main()
    {
        console.write("input a first number(<100): ");
        int m = convert.toint32(console.readline());
        console.write("input a second number(>200): ");
        int n = convert.toint32(console.readline());
        console.writeline((m < 100 && n > 200));
    }
}


34. write a c# program to check if an integer (from the two given integers) is in the range -10 to 10.

using system;
using system.linq;
;

 class pro34
{
    static void main()
    {
        console.write("input a first number: ");
        int m = convert.toint32(console.readline());
        console.write("input a second number: ");
        int n = convert.toint32(console.readline());
        console.writeline(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
    }

}

35. write a c# program to check if "hp" appears at second position in a string and returns the string without "hp".

using system;

using system.linq;

class pro35
{
    static void main()
    {
        string str = "php tutorial";
        console.writeline((str.substring(1, 2).equals("hp") ? str.remove(1, 2) : str));
    }
}


36. write a c# program to find the largest and lowest values from three integer values.

using system;
using system.linq;

 class pro36
{
    static void main()
    {
        console.writeline("\ninput first integer:");
        int x = convert.toint32(console.readline());
        console.writeline("input second integer:");
        int y = convert.toint32(console.readline());
        console.writeline("input third integer:");
        int z = convert.toint32(console.readline());

        console.writeline("largest of three: " + math.max(x, math.max(y, z)));
        console.writeline("lowest of three: " + math.min(x, math.min(y, z)));
    }
}


37. write a c# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same.

using system;
using system.linq;

class pro37
{
static void main()
    {
        console.writeline("\ninput first integer:");
        int x = convert.toint32(console.readline());
        console.writeline("input second integer:");
        int y = convert.toint32(console.readline());
        int n = 20;
        var val1 = math.abs(x - n);
        var val2 = math.abs(y - n);
        console.writeline(val1 == val2 ? 0 : (val1 < val2 ? x : y));
    }
}

38. write a c# program to count a specified number in a given array of integers.

using system;
using system.linq;

 class pro38
{
    static void main()
    {
        console.writeline("\ninput an integer:");
        int x = convert.toint32(console.readline());
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
        console.writeline("number of " + x + " present in the said array:");
        console.writeline(nums.count(n => n == x));
    }
}

39. write a c# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.

using system;
using system.linq;


 class pro39
{
    static void main()
    {
        console.writeline("\ninput an integer:");
        int x = convert.toint32(console.readline());
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
        console.writeline((nums[0] == x) || (nums[nums.length - 1] == x));
    }
}


40. write a c# program to compute the sum of all the elements of an array of integers.

using system;
using system.linq;

class pro40
{
     static void main()
    {
        int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        console.writeline("\narray1: [{0}]", string.join(", ", nums));
        var sum = 0;
        for (var i = 0; i < nums.length; i++)
        {
            sum += nums[i];
        }
        console.writeline("sum: " + sum);
    }
}

41. write a c# program to check if the first element or the last element of the two arrays ( length 1 or more) are equal.

using system;

using system.linq;

 class pro41
{
     static void main()
    {
        int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
        console.writeline("\narray1: [{0}]", string.join(", ", nums1));
        int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
        console.writeline("\narray2: [{0}]", string.join(", ", nums2));

        console.writeline("\ncheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
        console.writeline((nums1[0].equals(nums2[0])) || (nums1[nums1.length - 1].equals(nums2[nums2.length - 1])));
    }
}


42. write a c# program to rotate an array (length 3) of integers in left direction.

using system;
using system.linq;


 class pro42
{
     static void main()
    {
        int[] nums = { 1, 2, 8 };
        console.writeline("\narray1: [{0}]", string.join(", ", nums));
        var temp = nums[0];
        for (var i = 0; i < nums.length - 1; i++)
        {
            nums[i] = nums[i + 1];
        }
        nums[nums.length - 1] = temp;
        console.writeline("\nafter rotating array becomes: [{0}]", string.join(", ", nums));

    }
}


43. write a c# program to get the larger value between first and last element of an array (length 3) of integers.

using system;
using system.linq;

 class pro43
{
     static void main()
    {
        int[] nums = { 1, 2, 5, 7, 8 };
        console.writeline("\narray1: [{0}]", string.join(", ", nums));
        var h_val = nums[0];
        for (var i = 0; i < nums.length; i++)
        {
            if (nums[i] > nums[0])
                h_val = nums[i];
        }
        console.writeline("\nhighest value between first and last values of the said array: {0}", h_val);

    }
}

44. write a c# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.

using system;

using system.linq;


class pro44
{
     static void main()
    {
        int[] array1 = { 1, 2, 5 };
        console.writeline("\narray1: [{0}]", string.join(", ", array1));
        int[] array2 = { 0, 3, 8 };
        console.writeline("\narray2: [{0}]", string.join(", ", array2));
        int[] array3 = { -1, 0, 2 };
        console.writeline("\narray3: [{0}]", string.join(", ", array3));
        int[] new_array = { array1[1], array2[1], array3[1] };
        console.writeline("\nnew array: [{0}]", string.join(", ", new_array));

    }
}


45. write a c# program to check if an array contains an odd number.


using system;
using system.linq;
 class pro45
{
     static void main()
    {
        int[] nums = { 2, 4, 7, 8, 6 };
        console.writeline("\noriginal array: [{0}]", string.join(", ", nums));
        console.writeline("check if an array contains an odd number? " + even_odd(nums));
    }

    public static bool even_odd(int[] nums)
    {
        foreach (var n in nums)
        {
            if (n % 2 != 0)
                return true;
        }
        return false;
    }
}
