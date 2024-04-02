// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 
// a b c
// d e f => “abcdef” 

string CharsArrayToString(char[,] chars)
{
    string strResult = string.Empty;

    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            strResult += chars[i, j];
        }
    }

    return strResult;
}

char[,] chars = { {'a', 'b', 'c'}, {'d', 'e', 'f'} };

string strResult = CharsArrayToString(chars);

Console.WriteLine(strResult);