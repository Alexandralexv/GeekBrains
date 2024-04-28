int LinesLengthLessthree(string[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            k++;
        }
    }
    return k;
}

// string[] CreateNewArray(string[] array)
// {
//     int k = 0;
//     string[] newArray = new string[LinesLengthLessthree(array)];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             newArray[k] = array[i];
//             k++;
//         }
//     }
//     return newArray;
// }

// void PrintArray(string[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1)
//         {
//             Console.Write($"“{array[i]}”, ");
//         }
//         else
//         {
//             Console.Write($"“{array[i]}”");
//         }
//     }
//     Console.WriteLine("]");
// }

// // Console.WriteLine(LinesLengthLessthree(arr));

// string[] arr0 = { "Hello", "2", "world", ":-)" };
// string[] arr1 = { "1234", "1567", "-2", "computer science" };
// string[] arr2 = { "Russia", "Denmark", "Kazan" };

// string[] arrNew0 = CreateNewArray(arr0);
// PrintArray(arrNew0);
// string[] arrNew1 = CreateNewArray(arr1);
// PrintArray(arrNew1);
// string[] arrNew2 = CreateNewArray(arr2);
// PrintArray(arrNew2);