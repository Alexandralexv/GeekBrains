// Считать с консоли строку, состоящую из цифр и
// латинских букв. Сформировать массив, состоящий
// из цифр этой строки.
// Пример
// abc123def06g => [1, 2, 3, 0, 6]
// Рекомендации
// • Разделить логику алгоритма на функции
// • Память под массив выделять необходимого
// размера (не больше, чем количество элементов)


// string GetNumberFromString(string str)
// {
//     string letters = "";
//     foreach (char num in str)
//     {
//         if (char.IsAsciiDigit(num) == true)
//         {
//             letters += num;
//         }
//     }
//     return letters;
// }

// int GetCountNumberFromString(string str)
// {
//     int k =0;
//     foreach (char num in str)
//     {
//         if (char.IsAsciiDigit(num) == true)
//         {
//             k++;
//         }
//     }
//     return k;
// }

// void TurnToArray(string letters, int count)
// {
//     char[] arr = new char[count];
//     for (int i = 0; i < count; i++)
//     {
//         foreach (var i in letters)
//         {
//             arr[i] += i;
//         }
//     }

//     return arr;
// }

// string str = Console.ReadLine();

// string result = GetNumberFromString(str);
// Console.WriteLine(result);

// int result2 = GetCountNumberFromString(str);
// Console.WriteLine(result2);

// Console.WriteLine(TurnToArray(result, result2));
