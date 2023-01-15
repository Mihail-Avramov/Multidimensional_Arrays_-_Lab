using System;

int dimension = int.Parse(Console.ReadLine());

char[,] matrix = new char[dimension, dimension];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] elements = Console.ReadLine().ToCharArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = elements[col];
    }
}

char findChar = Convert.ToChar(Console.ReadLine());

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == findChar)
        {
            Console.WriteLine($"({row}, {col})");
            return ;
        }
    }
}

Console.WriteLine($"{findChar} does not occur in the matrix");