
int m = 3, n = 4, i = 0, j = 0;
double[,] numbers = new double[m, n];

for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        numbers[i, j] = new Random().NextDouble() * 10 - 5;
    }
}
for (i = 0; i < m; i++)
{
    for (j = 0; j < n; j++)
    {
        Console.WriteLine($"  {numbers[i, j]}");
    }
}
