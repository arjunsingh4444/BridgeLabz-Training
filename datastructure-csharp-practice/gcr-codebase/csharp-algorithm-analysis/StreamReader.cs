using System;
using System.IO;

class StreamReader
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("sample.txt"))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine("File read using StreamReader");
        }
    }
}


// using System;
// using System.IO;

// class FileStream
// {
//     static void Main()
//     {
//         using (FileStream fs = new FileStream("sample.txt", FileMode.Open))
//         {
//             byte[] data = new byte[fs.Length];
//             fs.Read(data, 0, data.Length);

//             Console.WriteLine("File read using FileStream");
//         }
//     }
// }
// // 