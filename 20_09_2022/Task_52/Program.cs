int[,] array = {{1,8,3,12},
                {5,6,77,8},
                {9,11,31,12},
                {21,13,15,19}};
int m = 4, n = 4;

for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + array[i, j];
    }
    //Console.Write($" '{sum}'  ");
    Console.Write($" '{sum / n}'  ");
}



