int v = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());


var edges = new List<(int startNode, int endNode, int weight)>();

for (int i = 0; i < e; i++)
{
    string[] edgeArgs = Console.ReadLine().Split(' ');
    int startNode = int.Parse(edgeArgs[0]);
    int endNode = int.Parse(edgeArgs[1]);
    int weight = int.Parse(edgeArgs[2]);
    edges.Add((startNode, endNode, weight));
}

edges.Sort((e1, e2) => e1.weight.CompareTo(e2.weight));

int[] parent = new int[v];

for (int i = 0; i < v; i++)
{
    parent[i] = i;
}

int Find(int node)
{
    if (parent[node] == node)
    {
        return node;
    }
    parent[node] = Find(parent[node]);
    return parent[node];
}

bool Union(int node1, int node2)
{
    int root1 = Find(node1);
    int root2 = Find(node2);
    if (root1 != root2)
    {
        parent[root1] = root2;
        return true;
    }
    return false;
}

int d = 0;

foreach (var edge in edges)
{
    int startNode = edge.startNode;
    int endNode = edge.endNode;
    int weight = edge.weight;
    if (Union(startNode, endNode))
    {
        d = weight;
    }
}

Console.WriteLine(d + 1);