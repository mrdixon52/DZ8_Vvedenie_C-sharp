// Task 56

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


void SmallestString(int[,] matrix)
{
    int min = 0;
    int k = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        if (sum < min)
        {
            min = sum; 
            k = i + 1;
        }
        else if (min == 0)
        {
            min = sum;
        }
    }
    Console.WriteLine($"Number of string with smallest sum = {min} is {k}");
}

Console.Clear();
Console.Write("Enter matrix size (N, M) via space: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Initial matrix");
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Result");
SmallestString(matrix);
