// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 
void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

static char[] StringToCharArray()
{
    string str = "Hello";

    char[] result = new char[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        result[i] = str[i];
    }

    return result;
}

char[] result = StringToCharArray();

PrintArray(result);

