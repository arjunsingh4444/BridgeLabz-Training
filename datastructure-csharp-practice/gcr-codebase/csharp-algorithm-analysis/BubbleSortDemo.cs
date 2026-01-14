using System;

class BubbleSortDemo //(O(N²))
{
    static void Main() 
    {
        int[] arr = { 5, 3, 1, 4, 2 };

        // Bubble Sort logic
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted Array:");
        foreach (int num in arr)
            Console.Write(num + " ");
    }
}



// using System;

// class MergeSortDemo. //(O(N log N))
// {
//     static void Main()
//     {
//         int[] arr = { 5, 3, 1, 4, 2 };
//         MergeSort(arr, 0, arr.Length - 1);

//         Console.WriteLine("Sorted Array:");
//         foreach (int num in arr)
//             Console.Write(num + " ");
//     }

//     static void MergeSort(int[] arr, int left, int right)
//     {
//         if (left < right)
//         {
//             int mid = (left + right) / 2;

//             MergeSort(arr, left, mid);
//             MergeSort(arr, mid + 1, right);

//             Merge(arr, left, mid, right);
//         }
//     }

//     static void Merge(int[] arr, int left, int mid, int right)
//     {
//         int[] temp = new int[right - left + 1];
//         int i = left, j = mid + 1, k = 0;

//         while (i <= mid && j <= right)
//         {
//             if (arr[i] < arr[j])
//                 temp[k++] = arr[i++];
//             else
//                 temp[k++] = arr[j++];
//         }

//         while (i <= mid)
//             temp[k++] = arr[i++];

//         while (j <= right)
//             temp[k++] = arr[j++];

//         for (i = left, k = 0; i <= right; i++, k++)
//             arr[i] = temp[k];
//     }
// }

