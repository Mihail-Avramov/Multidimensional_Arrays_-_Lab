using System;

int rowCount = int.Parse(Console.ReadLine());

long[][] pascalTriangle = new long[rowCount][];

for (int row = 0; row < rowCount; row++)
{
    pascalTriangle[row] = new long[row + 1];
    pascalTriangle[row][0] = 1;
    pascalTriangle[row][pascalTriangle[row].Length - 1] = 1;
}

for (int row = 2; row < rowCount; row++)
{
    for (int col = 1; col < pascalTriangle[row].Length - 1; col++)
    {
        pascalTriangle[row][col] = pascalTriangle[row - 1][col -1] + pascalTriangle[row -1][col];
    }
}

foreach (var row in pascalTriangle)
{
    Console.WriteLine(string.Join(" ", row));
}