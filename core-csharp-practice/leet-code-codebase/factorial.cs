using System;   
public class factorial{   
    public static void Main(string[] args) {   
        int n = 5;   
        int result = Factorial(n);   
        Console.WriteLine(result);   
    }   
    public static int Factorial(int n) {   
        if (n == 0) {   
            return 1;   
        }   
        return n * Factorial(n - 1);   
    }   
}   
