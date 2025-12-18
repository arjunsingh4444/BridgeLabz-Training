using System;

public class Solution {
    public static void Main(string[] args) {
        int num1 = 123;
        int num2 = 456;
        int result = Multiply(num1, num2);
        Console.WriteLine(result);
    }

    public static int Multiply(int num1, int num2) {
        int result = 0;
        for (int i = 0; i < num2; i++) {
            result += num1;
        }
        return result;
    }
}