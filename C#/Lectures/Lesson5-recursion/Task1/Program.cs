// Вычислить факториал от натурального
// числа N


int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop reqursion: n = {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}

Console.Write(Fact(5));

//F11 шаг с заходом
//F10 шаг с обходом
//F5 продолжить (До след. точки)