// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17
Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = number % 10 + number / 100;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не трёхзначное!");
}