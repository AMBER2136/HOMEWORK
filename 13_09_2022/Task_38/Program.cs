int i;
int size = 6;
int[] minmax = new int[size];
System.Console.Write("{");

//int count = 0;
for (i = 0; i < size; i++)
{
    minmax[i] = new Random().Next(15, 100);
    System.Console.Write($" {minmax[i]}");
}
System.Console.WriteLine("}");

//void Sort(int[] array)
{
    for (int l = 0; l < size; l++)
    {
        for (int j = 0; j < size; j++)
        {
            int buffer;
            if (minmax[l] < minmax[j])
            {
                buffer = minmax[j];
                minmax[j] = minmax[l];
                minmax[l] = buffer;
            }
        }
    }
}
System.Console.Write("{");
for (int k = 0; k < size; k++)
{
    System.Console.Write($" {minmax[k]}");
}
System.Console.WriteLine("}");
int sum = minmax[0] + minmax[size - 1];
System.Console.WriteLine($"СУММА {sum}");