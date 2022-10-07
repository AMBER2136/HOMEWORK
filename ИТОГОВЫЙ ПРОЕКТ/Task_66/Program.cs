int M, N, sum;
M = 2; N = 8; sum = 0;
SumReals(M, N, sum);
int SumReals(int a, int b, int c)
{
    sum = sum + M;
    M = M + 1;
    if (M > N)
    {
        Console.WriteLine(sum);
        return 0;
    }
    SumReals(M, N, sum);
    return 0;
}