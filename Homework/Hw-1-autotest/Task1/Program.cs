// Задача 1: Напишите программу, которая на вход принимает два
// числа и выдаёт, какое число большее, а какое меньшее.
// a=5;b=7 => max=7, min=5
// a=2;b=10 => max=10, min=2
// a=-9;b=-3 => max=-3, min=-9

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("max=" + number1 + ", min=" + number2);
}
else
{
    Console.WriteLine("max=" + number2 + ", min=" + number1);    
}