// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World2!");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Hello, World"+i+"!");
}

static int calculateAverage(int[] ar)
{
    int total = 0;
    foreach (int n in ar)
    {
        total += n;
    }

    return total / ar.Length;
}