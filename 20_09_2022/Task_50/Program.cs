int m = 4, n = 5;
int[,] array = {{1,8,3,4},
                {5,6,7,8},
                {9,11,11,12},
                {21,14,15,16},
                {23,25,44,15}};
FindeNum();
FindeCoord();

void FindeNum()
{Console.WriteLine($"ВВЕДИТЕ № СТРОКИ ОТ 0 ДО {n-1}");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"ВВЕДИТЕ № СТОЛБЦА ОТ 0 ДО {m-1}");
int j = Convert.ToInt32(Console.ReadLine());
int num = array[i,j];
Console.WriteLine($"ЭТО ПОЗИЦИЯ ЧИСЛА {num}");
}

int FindeCoord()
{
    Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
    int finde = Convert.ToInt32(Console.ReadLine());
    int i, j;
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < m; j++)
        {
            if (array[i, j] == finde)
            {
                Console.WriteLine($"КООРДИНАТЫ ЧИСЛА {i},{j}");
                return 0;
            }

        }
    }
    Console.WriteLine("ИСКОМОГО ЧИСЛА НЕТ В МАССИВЕ 'array'");
    return 0;
}