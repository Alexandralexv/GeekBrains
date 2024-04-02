// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

bool PalindromicCheckBool(string input)
{
    for (int i = 0; i < input.Length / 2; i++)
    {
        if (input[i] != input[input.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

void ConclusionYesOrNot(bool palindrom)
{
    if (palindrom == true)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

Console.WriteLine("Введите строку");
string input = Console.ReadLine();

bool palindrom = PalindromicCheckBool(input);
ConclusionYesOrNot(palindrom);


