int[] array = new int[8];
System.Console.Write("{");
for (int i = 0; i < 5; i++)
{
    array[i] = new Random().Next(1, 246);
    System.Console.Write($" {array[i]}");
}
System.Console.WriteLine("}");
int[] array1 = new int[3];
System.Console.Write("{");
for (int i = 0; i < 3; i++)
{
    array1[i] = new Random().Next(1, 246);
    System.Console.Write($" {array[i]}");
}
System.Console.WriteLine("}");
