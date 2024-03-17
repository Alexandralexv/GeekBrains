// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = 1;

if (number > 99 && number < 1000)
{
    int second_number = (number / 10) % 10;
    Console.WriteLine("second_number: " + second_number);
    int last_number = number % 10;
    Console.WriteLine("last_number: " + last_number);

    while (last_number > 0)
    {
        result *= second_number;
        last_number -= 1;
    }

    Console.WriteLine(result);

}
else
{
    Console.WriteLine("Неверный ввод!");
}