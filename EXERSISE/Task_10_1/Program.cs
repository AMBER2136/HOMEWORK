// Программа показывает вторую цифру введенного трехзначного числа,
// но принимает и символы с удовольствием.

Console.WriteLine("ВВЕДИТЕ ТРЕХЗНАЧНОЕ ЧИСЛО");
string a = Console.ReadLine();
Second(a);
void Second(string c)
{
    //char[] num = a.ToCharArray();
    int b = c.Length;
    if (b == 0)
    {
        Console.WriteLine("НИЧЕГО НЕ ВВЕДЕНО");
        Console.WriteLine("ПОПРОБУЙТЕ ЕЩЕ РАЗ");
    }
    else
     if ((b < 3) || (b > 3))
    {
        Console.WriteLine("ВВЕДЕННОЕ ЧИСЛО НЕ ТРЕХЗНАЧНОЕ");
        Console.WriteLine("ПОПРОБУЙТЕ ЕЩЕ РАЗ");
    }
    else
    {
        Console.WriteLine($"ВТОРАЯ ЦИФРА ВВЕДЕННОГО ЧИСЛА - {c[1]}");
    }
}


