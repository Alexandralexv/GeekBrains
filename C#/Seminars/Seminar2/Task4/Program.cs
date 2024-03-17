// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 999)
    {
        number /= 10;
    }

    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

