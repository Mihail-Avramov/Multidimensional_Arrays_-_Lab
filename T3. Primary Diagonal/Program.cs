using System;
using System.Linq;

int dimension = int.Parse(Console.ReadLine());

int[,] matrix = new int[dimension, dimension];

int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row,col] = elements[col];
    }
}

for (int i = 0; i < dimension; i++)
{
    sum += matrix[i,i];
}

Console.WriteLine(sum);