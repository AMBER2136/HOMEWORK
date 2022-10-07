int m, n;
m = 3;
n = 6;

Console.Write(Akkerman(m, n));
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        int A = n + 1; return A;
    }
    else
    if ((n == 0) && (m > 0))
    {
        int A = Akkerman(m - 1, 1); return A;
    }
    else
    if ((m > 0) && (n > 0))
    {
        int A = Akkerman(m - 1, Akkerman(m, n - 1)); return A;
    }
    return 0;
    }

