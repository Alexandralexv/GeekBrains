// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// 4 3 1
// 2 6 9 
// 4 6 2 
// =>
// 4 6 2
// 2 6 9
// 4 3 1

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

int[,] ChangeFirstAndLastRow(int[,] matrix)
{   
    int arr;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        arr = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = arr;
    }
    return matrix;
}


int[,] arr2d = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(arr2d);
Console.WriteLine();

int[,] result = ChangeFirstAndLastRow(arr2d);
PrintMatrix(result);