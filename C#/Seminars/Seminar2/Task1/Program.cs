// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
{
    int first_number = number / 100;
    int last_number = number % 10;

    int result = first_number * 10 + last_number;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Неверный ввод!");
}
