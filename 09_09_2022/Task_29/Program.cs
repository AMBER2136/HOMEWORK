int[] array = new int[8];
System.Console.Write("{");
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(1, 246);
    System.Console.Write($" {array[i]}");
}
System.Console.WriteLine("}");


