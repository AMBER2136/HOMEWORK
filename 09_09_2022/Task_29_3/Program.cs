int[] array = new int[5];
for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.Write("{");
for (int i = 0; i < 5; i++)
{
System.Console.Write($" {array[i]}");
}
System.Console.WriteLine("}");
int[] array1 = new int[3];
for (int i = 0; i < 3; i++)
{
    System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
    array1[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.Write("{");
for (int i = 0; i < 3; i++)
{
System.Console.Write($" {array1[i]}");
}
System.Console.WriteLine("}");