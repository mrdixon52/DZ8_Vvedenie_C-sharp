bool checkElement(int[,,] matrix, int number)
{
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int g = 0; g < matrix.GetLength(2); g++)
            {
                if (matrix[i, j, g] == number)
                return true;  
            }
        }
    }
    return false;
}

void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int g = 0; g < matrix.GetLength(2); g++)
            {
                int a = new Random().Next(10, 100);
                while (checkElement(matrix, a) == true)
                {
                a = new Random().Next(10, 100);
                }
                matrix[i, j, g] = a;
                Console.WriteLine($"{matrix[i, j, g]} ({i}, {j}, {g})");
            }
        }
    }
}



Console.Clear();
Console.Write("Enter matrix size via space: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2])];
Console.WriteLine("Initial matrix");
InputMatrix(matrix);
