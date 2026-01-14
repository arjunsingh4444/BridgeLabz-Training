using System;

class LinearSearch
{
    static void Main() //O(n)


    {
        int[] data = { 10, 20, 30, 40, 50 };
        int target = 40;

        // Loop through each element
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == target)
            {
                Console.WriteLine("Element found at index: " + i);
                return; // stop early
            }
        }

        Console.WriteLine("Element not found");
    }
}




// using System;

// class BinarySearchDemo //O(log n)
// {
//     static void Main()
//     {
//         int[] data = { 10, 20, 30, 40, 50 };
//         int target = 40;

//         int left = 0;
//         int right = data.Length - 1;

//         while (left <= right)
//         {
//             int mid = (left + right) / 2;

//             if (data[mid] == target)
//             {
//                 Console.WriteLine("Element found at index: " + mid);
//                 return;
//             }
//             else if (data[mid] < target)
//             {
//                 left = mid + 1;
//             }
//             else
//             {
//                 right = mid - 1;
//             }
//         }

//         Console.WriteLine("Element not found");
//     }
// }
