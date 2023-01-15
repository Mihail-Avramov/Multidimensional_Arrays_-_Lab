using System;
using System.Linq;

int rowCount = int.Parse(Console.ReadLine());

int[][] jagged = new int[rowCount][];

for (int row = 0; row < rowCount; row++)
{
    jagged[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
}

string input;

while ((input = Console.ReadLine()) != "END")
{
    string[] commandArguments = input.Split(" ");  

    string command = commandArguments[0];
    int rowIndex = int.Parse(commandArguments[1]);
    int colIndex = int.Parse(commandArguments[2]);
    int value = int.Parse(commandArguments[3]);

    switch (command)
    {
        case "Add":
            if (rowIndex < 0 || colIndex < 0 || rowIndex >= jagged.Length || colIndex >= jagged[rowIndex].Length)
            {
                Console.WriteLine("Invalid coordinates");
            }
            else
            {
                jagged[rowIndex][colIndex] += value;
            }
            break;
        case "Subtract":
            if (rowIndex < 0 || colIndex < 0 || rowIndex >= jagged.Length || colIndex >= jagged[rowIndex].Length)
            {
                Console.WriteLine("Invalid coordinates");
            }
            else
            {
                jagged[rowIndex][colIndex] -= value;
            }
            break;
    }
}


foreach (var row in jagged)
{
    Console.WriteLine(string.Join(" ", row));
}