using System;   
public class PerimeterOfRectangle   
{   
    public static void Main()   
    {       
        Console.Write("length  ");   
        int length = int.Parse(Console.ReadLine());   //input length
        Console.Write(" breadth  ");   
        int breadth = int.Parse(Console.ReadLine());   //input breadth
        int perimeter = 2 * (length + breadth);    //primeter calculation formula       
        Console.WriteLine(perimeter);   
    }   
}