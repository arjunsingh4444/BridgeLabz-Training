using System;

class Program
{
    static int[] stack = new int[10]; // simple stack using array
    static int top = -1;

    // Push element into stack
    static void Push(int x)
    {
        stack[++top] = x;
    }

    // Pop element from stack
    static int Pop()
    {
        return stack[top--];
    }

    // Check if stack is empty
    static bool IsEmpty()
    {
        return top == -1;
    }

    // Get top element
    static int Peek()
    {
        return stack[top];
    }

    // Print stack
    static void PrintStack()
    {
        for (int i = top; i >= 0; i--)
            Console.Write(stack[i] + " ");
        Console.WriteLine();
    }

    // 🔹 Sort the stack using recursion
    static void SortStack()
    {
        if (!IsEmpty())
        {
            int temp = Pop();     // remove top element
            SortStack();          // sort remaining stack
            InsertSorted(temp);   // insert element correctly
        }
    }

    // 🔹 Insert element in sorted order
    static void InsertSorted(int x)
    {
        if (IsEmpty() || Peek() <= x)
        {
            Push(x);
            return;
        }

        int temp = Pop();
        InsertSorted(x);
        Push(temp);
    }

    // Main method
    static void Main()
    {
        Push(3);
        Push(1);
        Push(4);
        Push(2);

        Console.WriteLine("Before Sorting:");
        PrintStack();

        SortStack();

        Console.WriteLine("After Sorting:");
        PrintStack();
    }
}
