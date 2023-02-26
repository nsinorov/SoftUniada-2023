string[] numbers = Console.ReadLine().Split();

Array.Sort(numbers, (x, y) => (y + x).CompareTo(x + y));

Console.WriteLine(string.Concat(numbers));