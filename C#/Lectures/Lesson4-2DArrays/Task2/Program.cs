// • Назовём число «интересным» если его сумма
// цифр чётная
// • Создать двумерный массив, состоящий из
// целых чисел. Вывести на экран «интересные»
// элементы массива

int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(10, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (SumOfNum(matrix[i, j]) % 2 == 0)
            {
                Console.Write($"{matrix[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

int SumOfNum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int[,] matrix = CreateMatrix(4,5);
ShowMatrix(matrix);