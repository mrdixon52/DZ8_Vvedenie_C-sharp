// Task 58

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

int[,] ProductOfTwoMatrices(int[,] matrix1, int[,]matrix2)
{
 int [,] result = new int [matrix1.GetLength(0), matrix1.GetLength(1)];
 int i1 = 0, j1 = 0, i2 = 0, j2 = 0, ir = 0, jr = 0;
 int res = 0;
    while (ir < result.GetLength(0))
    {
        jr = 0;
        j2 = 0;
        while(jr < result.GetLength(1))
        {
            j1 = 0;
            i2 = 0;
            res = 0;
            while (j1 < matrix1.GetLength(1))
            {
                res = res + matrix1[i1,j1] * matrix2[i2,j2];
                result[ir, jr] = res;
                j1++;
                i2++;
            }
            jr++;
            j2++;
        }
        ir++;
        i1++;
    }
    return result;
}

Console.Clear();
Console.Write("Enter matrix size via space: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix1 = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Initial 1-st matrix");
InputMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Initial 2-nd matrix");
InputMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Result");
PrintMatrix(ProductOfTwoMatrices(matrix1, matrix2));
