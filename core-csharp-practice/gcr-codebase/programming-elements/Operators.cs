using System;

public class Operators
{
    public static void Main()
    {

        //Arithmetic Operators
        int x = 10;
        int y = 5;
        Console.WriteLine("Addition: " + (a + b)); // 15
        Console.WriteLine("Subtraction: " + (a - b)); // 5
        Console.WriteLine("Multiplication: " + (a * b)); // 50
        Console.WriteLine("Division: " + (a / b)); // 2
        Console.WriteLine("Modulus: " + (a % b)); // 0

        //Relational Operators

        //equal to
        Console.WriteLine("a == b: " + (a == b)); // false
        //not equal to
        Console.WriteLine("a != b: " + (a != b)); // true
        //greater than
        Console.WriteLine("a > b: " + (a > b)); // true
        //less than
        Console.WriteLine("a < b: " + (a < b)); // false
        //greater than or equal to
       Console.WriteLine("a >= b: " + (a >= b)); // true
        //less than or equal to
       Console.WriteLine("a <= b: " + (a <= b)); // false


       //Logical Operators
       bool x = true;
       bool y = false;

       //OR
       Console.WriteLine("x || y: " + (x || y)); // true
       //AND
       Console.WriteLine("x && y: " + (x && y)); // false
       //NOT
       Console.WriteLine("!y: " + (!y)); // true


       //Assignment Operators

       a += b; // a = a + b
       Console.WriteLine("a += b: " + a); // 15

       a -= b; // a = a - b
       Console.WriteLine("a -= b: " + a); // 10

      a *= b; // a = a * b
      Console.WriteLine("a *= b: " + a); // 50

      a /= b; // a = a / b
     Console.WriteLine("a /= b: " + a); // 10
 
     a %= b; // a = a % b
     Console.WriteLine("a %= b: " + a); // 0
              
    //Unary Operators

    Console.WriteLine("a: " + a); // 5
      Console.WriteLine("++a: " + ++a); // 6 (pre-increment)
     Console.WriteLine("a++: " + a++); // 6 (post-increment)
     Console.WriteLine("a: " + a); // 7
     Console.WriteLine("--a: " + --a); // 6 (pre-decrement)
     Console.WriteLine("a--: " + a--); // 6 (post-decrement)
     Console.WriteLine("a: " + a); // 5



     //Ternary Operator

     int a = 10;
     int b = 5;
     int c = (a > b) ? a : b; // if a is greater than b, c is assigned a, otherwise b


    //is operator
    //In C#, the is operator checks if an object is compatible with a specific type.

    object obj = "Hello";
    bool isString = obj is string; // true



    }

}

