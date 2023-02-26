int n = int.Parse(Console.ReadLine());

int[] currentRow = new int[n + 1];
int[] previousRow = new int[n + 1];

currentRow[0] = 1;
previousRow[0] = 1;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j < i; j++)
    {
        currentRow[j] = previousRow[j - 1] + previousRow[j];
    }

    currentRow[i] = 1;

    Array.Copy(currentRow, previousRow, currentRow.Length);

}

Console.WriteLine(string.Join(" ", currentRow));