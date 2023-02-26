string[] input = Console.ReadLine().Split(' ');
int[] sequence = Array.ConvertAll(input, int.Parse);

int maxSum = int.MinValue;
int start = 0;
int end = 0;

int currentSum = 0;
int currentStart = 0;

for (int i = 0; i < sequence.Length; i++)
{
    currentSum += sequence[i];

    if (currentSum > maxSum || (currentSum == maxSum && i - currentStart > end - start))
    {
        maxSum = currentSum;
        start = currentStart;
        end = i;
    }

    if (currentSum < 0)
    {
        currentSum = 0;
        currentStart = i + 1;
    }
}

Console.WriteLine($"{maxSum} {start} {end}");