Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
double y = Convert.ToDouble(Console.ReadLine());
if (x > y)
{
    Console.WriteLine("ВАШЕ ПЕРВОЕ ЧИСЛО БОЛЬШЕ ВТОРОГО");
}
else if (x == y)
{
    Console.WriteLine("ВАШИ ЧИСЛА РАВНЫ");
}
else if (x < y)
{
    Console.WriteLine("ВАШЕ ВТОРОЕ ЧИСЛО БОЛЬШЕ ПЕРВОГО");
}

