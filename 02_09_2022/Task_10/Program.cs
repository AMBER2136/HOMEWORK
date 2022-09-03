Console.WriteLine("ВВЕДИТЕ ТРЕХЗНАЧНОЕ ЧИСЛО");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int c = 0;
if ((a < 100) || (a > 999))
{
    Console.WriteLine("ВВЕДЕННОЕ ЧИСЛО НЕ ТРЕХЗНАЧНОЕ");
    Console.WriteLine("ПОПРОБУЙТЕ ЕЩЕ РАЗ");
}
else
{
    b = a % 100;
    c = b / 10;
    Console.WriteLine($"ВТОРАЯ ЦИФРА ВВЕДЕННОГО ЧИСЛА - {c}");
}
