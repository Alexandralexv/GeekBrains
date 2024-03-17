// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    int i = -N;

    while (i < N)
    {
        Console.Write(i + ", ");
        i++;
    }
    Console.Write(i);
}
else
{
    Console.WriteLine("Некорректный ввод!");
}