using System;
using System.Linq;

int[] matrixDimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = matrixDimensions[0];
int cols = matrixDimensions[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] currentRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentRow[col];
    }
}

int sum = 0;
foreach (var element in matrix)
{
    sum += element;
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);