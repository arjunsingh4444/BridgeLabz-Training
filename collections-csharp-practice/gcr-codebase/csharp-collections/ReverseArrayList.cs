using System;
using System.Collections;

class ReverseArrayList
{
    static void Main()
    {
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
        ArrayList reversed = new ArrayList();

        for (int i = list.Count - 1; i >= 0; i--)
        {
            reversed.Add(list[i]);
        }

        Console.WriteLine(string.Join(", ", reversed));
    }
}






class ReverseLinkedList
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        LinkedList<int> reversed = new LinkedList<int>();

        foreach (int item in list)
        {
            reversed.AddFirst(item);
        }

        Console.WriteLine(string.Join(", ", reversed));
    }
}
