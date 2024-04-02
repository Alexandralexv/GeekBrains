// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1


int CountNumberVolwels(string str)
{
    string volwes = "aouyei";
    int k = 0;
    str = str.ToLower();
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < volwes.Length; j++)
        {
            if (str[i] == volwes[j])
            {
                k++;
            }
        }
    }
    return k;
}

Console.WriteLine("Введите строку");
string input = Console.ReadLine();

int result = CountNumberVolwels(input);
Console.WriteLine(result);