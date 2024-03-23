// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int memory_number = number;
    int k = 0;

    while (number > 0) // Находим кол-во символов в числе
    {
        number /= 10;
        k++;
    }

    int[] arr = new int[k];

    for (int i = 0; i < k; i++)
    {
        arr[i] = memory_number % 10;
        memory_number /= 10;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
else
{
    Console.WriteLine("Некорректный ввод");
}




