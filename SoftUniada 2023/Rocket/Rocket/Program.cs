int n = int.Parse(Console.ReadLine());
int width = n + 5;

DrawTopPart(n, width);
DrawMiddlePart(n, width);
DrawBottomPart(n, width);


static void DrawTopPart(int n, int width)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(new string(' ', width - n - i - 1));
        Console.Write('/');
        Console.Write(new string('.', i));
        Console.Write('\\');
        Console.Write(new string('.', i));
        Console.Write('\\');
        Console.WriteLine(new string(' ', width - n - i - 1));
    }
}

static void DrawMiddlePart(int n, int width)
{
    Console.Write(new string('.', n / 2));
    Console.Write(new string('*', width - n));
    Console.WriteLine(new string('.', n / 2));
    for (int i = 0; i < 2 * n; i++)
    {
        Console.Write(new string('.', n / 2));
        Console.Write('|');
        Console.Write(new string('\\', width - n - 2));
        Console.Write('|');
        Console.WriteLine(new string('.', n / 2));
    }
}

static void DrawBottomPart(int n, int width)
{
    for (int i = n - 1; i >= 0; i--)
    {
        Console.Write(new string(' ', width - n - i - 1));
        Console.Write('\\');
        Console.Write(new string('.', i));
        Console.Write('/');
        Console.Write(new string('.', i));
        Console.Write('/');
        Console.WriteLine(new string(' ', width - n - i - 1));
    }
}