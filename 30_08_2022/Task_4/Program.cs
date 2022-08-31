Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ТРЕТЬЕ ЧИСЛО");
double z = Convert.ToDouble(Console.ReadLine());
double max = x;
if (y > max)
{
    max = y;
}
if (z > max)
{
    max=z;
}
Console.Write("НАИБОЛЬШЕЕ ЧИСЛО - ");
Console.WriteLine(max);
