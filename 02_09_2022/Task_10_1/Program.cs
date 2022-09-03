
Console.WriteLine("ВВЕДИТЕ ТРЕХЗНАЧНОЕ ЧИСЛО");
string a = Console.ReadLine();
//Console.WriteLine(a);
Second(a);
void Second(string a)
{
    char[] num = a.ToCharArray();
    int b = num.Length;
    if ((b < 3) || (b > 3))
    {
        Console.WriteLine("ВВЕДЕННОЕ ЧИСЛО НЕ ТРЕХЗНАЧНОЕ");
        Console.WriteLine("ПОПРОБУЙТЕ ЕЩЕ РАЗ");
    }
    else
        Console.WriteLine($"ВТОРАЯ ЦИФРА ВВЕДЕННОГО ЧИСЛА - {num[1]}");
}