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
    foreach (int value in ar)
    {
        total += value;
    }

    return total / ar.Length;
}

static int calculateMax(int[] ar)
{
    int curMax = Int32.MinValue;
    foreach (int n in ar)
    {
        if (n > curMax)
        {
            curMax = n;
        }
    }

    return curMax;
}