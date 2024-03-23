// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 

int[] arr = {1, 3, 8, 19, 3, 5};

int num = 8;
bool res = false;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == num)
    {
        res = true;
        break;
    }
}

// if (res == true)
// {
//     Console.WriteLine($"{num} => Да");
// }
// else
// {
//     Console.WriteLine($"{num} => Нет");
// }

Console.WriteLine(res ? $"{num} => Да" : $"{num} => Нет");

