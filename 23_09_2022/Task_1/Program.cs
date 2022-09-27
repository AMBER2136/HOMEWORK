int[,] array = new int[,]{{6,3,77,33,},
                          {18,34,6,1},
                          {17,3,2,5},
                          {5,2,4,11},
                          {39,47,33,2}};
int n = 5, m = 4;

FindMinSum(RowSumArray());

int[] RowSumArray()
{
    int[] rowsum = new int[n];
    for (int i = 0; i < n; i++)
    {
        int linesum = 0;
        for (int j = 0; j < m; j++)
        {
            linesum = linesum + array[i, j];
        }
        rowsum[i] = linesum;
        Console.WriteLine($"СУММА СТРОКИ {i} РАВНА {linesum}");
    }

    return rowsum;
}


void FindMinSum(int[] sumarray)
{
    int min = sumarray[0];
    for (int i = 0; i < n; i++)
    {
        if (sumarray[i] < min)
        {
            min = sumarray[i];
        }
    }
    Console.WriteLine($"ЭТО СУММА НАИМЕНЬШЕЙ СТРОКИ: {min}");
    for (int i = 0; i < n; i++)
    {
        if (min == sumarray[i])
            Console.WriteLine($"ИНДЕКС СТРОКИ С НАИМЕНЬШЕЙ СУММОЙ: {i}");
    }
}

