// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца
// 4 3 1
// 2 6 9 
// 4 6 2
// =>
// 2 6
// 4 6

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }

}

int[] OutputSmallestNumber(int[,] array)
{
    int min = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                row = i;
                column = j;
            }
        }   
    }
    int[] arr = {row, column};
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

int[] CreateArray(int[,] matrix, int[] arr)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    int index = 0;
    int k = 0;

    int[] array = new int[x*y - x - y + 1 + 1];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (arr[0] != i && arr[1] != j)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }
        k++;
    }
    array[index] = k - 1;
    return array;
}

int[,] CreateFinalyMatrix(int[] arr)
{
    int count = 0;
    int k = arr[arr.Length-1];

    int[,] matrix = new int[k, (arr.Length-1)/k];

    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < (arr.Length-1)/k; j++)
        {
            matrix[i, j] = arr[count];
            count++;
        }
    }
    return matrix;

}

int[,] arr2d = CreateMatrixRndInt(3, 3, 1, 10);
Console.WriteLine("Двумерный массив:");
PrintMatrix(arr2d);

int[] arr = OutputSmallestNumber(arr2d);
Console.WriteLine("Индекс первого наименьшего числа:");
PrintArray(arr);

Console.WriteLine("\nОставшиеся цифры, после удаления строки и колоник + кол-во строк:");
int[] NewMatrix = CreateArray(arr2d, arr);
PrintArray(NewMatrix);

Console.WriteLine("\nФинальный массив:");
int[,] FinalMatrix = CreateFinalyMatrix(NewMatrix);
PrintMatrix(FinalMatrix);
