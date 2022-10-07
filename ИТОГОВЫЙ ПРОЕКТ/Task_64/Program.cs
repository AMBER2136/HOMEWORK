int N;
N = 19;
Reals(N);
int Reals(int a)
{
    if (N < 1) return 0;
    Console.Write($"'{N}'");
    N = N - 1;
    Reals(N);
    return 0;
}

