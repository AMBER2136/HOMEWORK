Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
double y = Convert.ToDouble(Console.ReadLine());
if (x > y)
{
    Console.Write($"НАИБОЛЬШЕЕ ЧИСЛО РАВНО {x}");
}
else if (x == y)
{

    Console.WriteLine("ВАШИ ЧИСЛА РАВНЫ");
}
else if (x < y)
{
    Console.Write($"НАИБОЛЬШЕЕ ЧИСЛО РАВНО {y}");
}

