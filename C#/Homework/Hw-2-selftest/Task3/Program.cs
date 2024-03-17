// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int first_number = number / 10;
    int last_number = number % 10;

    if (first_number > last_number)
    {
        Console.WriteLine(first_number);
    }
    else
    {
        Console.WriteLine(last_number);
    }
}
else
{
    Console.WriteLine("Неверный ввод!");
}