// Task 54

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] SortingStrings(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i,j] < matrix[i,j + 1])
                {
                    int a = matrix[i,j];
                    matrix[i,j] = matrix[i,j + 1];
                    matrix[i,j + 1] = a;
                }
            }
        }
    }
    return matrix;
}

Console.Clear();
Console.Write("Enter matrix size (N, M) via space: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Initial matrix");
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Result");
SortingStrings(matrix);
PrintMatrix(matrix);
