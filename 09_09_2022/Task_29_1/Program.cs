int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.Write("{");
for (int i = 0; i < 8; i++)
{
System.Console.Write($" {array[i]}");
}
System.Console.WriteLine("}");