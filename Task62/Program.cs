int[,] InputMatrix(int[,] matrix)
{
    int i = 0, j = 0;
    int count = 1;
    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
        else
        i--;
    }
    return matrix;
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

Console.Clear();
int[,] matrix = new int[4, 4];
Console.WriteLine("Result");
PrintMatrix(InputMatrix(matrix));
