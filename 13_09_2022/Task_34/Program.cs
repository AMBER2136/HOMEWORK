
int[] even = new int[10];
System.Console.Write("{");
int i;
int count = 0;
for (i = 0; i < 10; i++)
{
    even[i] = new Random().Next(100, 246);
    System.Console.Write($" {even[i]}");
}
System.Console.WriteLine("}");
for (i = 0; i < 10; i++)
{    
    int x = even[i] % 2;
    if (x == 0)
    count++;
}
System.Console.WriteLine(count);