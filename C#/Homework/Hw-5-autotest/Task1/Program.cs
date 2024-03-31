// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// 4 3 1   (1,2)   => 9
// 2 6 9 

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

void CheckingForIndexes(int[,] matrix, int row, int column)
{
    if (matrix.GetLength(0) > row && matrix.GetLength(0) > column)
    {
        Console.WriteLine(matrix[row, column]);   
    }
    else
    {
        Console.WriteLine("Нет!");
    }
}

int[,] arr2d = CreateMatrixRndInt(2, 3, 1, 10);
PrintMatrix(arr2d);
Console.WriteLine();
CheckingForIndexes(arr2d, 2, 2);