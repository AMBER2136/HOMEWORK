int m = 4, n = 4;
int size = m * n;


FillArray(GetRundLine());

int[] GetRundLine()
{
    Random rzhd = new Random();
    int[] rndline = new int[size];
    for (int i = 0; i < size; i++)
    {
        rndline[i] = rzhd.Next(10, 13);
        Console.Write($" {rndline[i]} ");
    }
    Console.WriteLine(";");
    int count = 1;
    while (count != 0)
    {
        count = 0;
        for (int t = 0; t < size; t++)
        {
            int test = rndline[t];
            for (int u = 1; u < (size - t); u++)
                if (test == rndline[t + u])
                {
                    rndline[t + u] = rzhd.Next(10, 99);
                    count++;
                }
        }

    }
    for (int i = 0; i < size; i++)
    {
        Console.Write($" {rndline[i]} ");
    }
    Console.WriteLine(";");
    Console.WriteLine(count);
    return rndline;
}
void FillArray(int[] rndline)
{
    int[,] array = new int[n, m];
    int v = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = rndline[v++];
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($" '{array[i, j]}' ");
        }
        Console.WriteLine(";");
    }
}
