using System;
using System.Linq;

int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int[,] matrix = new int[sizes[0],sizes[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] currentElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = currentElements[col];
    }
}

for (int col = 0; col < matrix.GetLength(1); col++)
{
    int Sum = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        Sum += matrix[row,col];
    }
    Console.WriteLine(Sum);
}