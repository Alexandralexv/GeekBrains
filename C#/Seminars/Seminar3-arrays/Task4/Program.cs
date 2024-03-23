// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Некорректный ввод");
}
else
{
    int[] result = new int[3];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = number % 10;
        number /= 10;
    }

    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + " ");
    }
}
