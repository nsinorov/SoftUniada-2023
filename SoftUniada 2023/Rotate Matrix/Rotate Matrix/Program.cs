int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

// Въвеждане на матрицата
for (int i = 0; i < size; i++)
{
    string[] rowValues = Console.ReadLine().Split();
    for (int j = 0; j < size; j++)
    {
        matrix[i, j] = int.Parse(rowValues[j]);
    }
}

// Завъртане на матрицата на 90 градуса
int[,] rotatedMatrix = new int[size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        rotatedMatrix[j, size - i - 1] = matrix[i, j];
    }
}

// Отпечатване на завъртената матрица
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(rotatedMatrix[i, j] + " ");
    }
    Console.WriteLine();
}