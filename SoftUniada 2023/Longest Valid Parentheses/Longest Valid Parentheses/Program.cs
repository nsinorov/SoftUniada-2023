string parantheses = Console.ReadLine();

int maxCount = 0;

Stack<int> stack = new();

stack.Push(-1);

for (int i = 0; i < parantheses.Length; i++)
{
    if (parantheses[i] == '(')
    {
        stack.Push(i);
    }
    else
    {
        stack.Pop();

        if (stack.Count == 0)
        {
            stack.Push(i);
        }
        else
        {
            int start = stack.Peek();
            maxCount = Math.Max(maxCount, i - start);
        }
    }
}

Console.WriteLine(maxCount);