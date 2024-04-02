// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


char[] chars = {'a', 'b', 'e', 'd'};

string strResult = string.Empty;

for (int i = 0; i < chars.Length; i++)
{
    strResult += chars[i];
}

Console.WriteLine(strResult);