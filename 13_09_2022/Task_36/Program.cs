int[] odd = new int[6];
int i;
int sum = 0;
System.Console.Write("{");
for (i = 0; i < 6; i++)
{
    odd[i] = new Random().Next(1, 30);
    System.Console.Write($" {odd[i]}");
}
System.Console.WriteLine("}");
for (i = 0; i < 6; i++)
{
    int x = i % 2;
    if (x > 0)
        sum = sum + odd[i];
}
System.Console.WriteLine(sum);