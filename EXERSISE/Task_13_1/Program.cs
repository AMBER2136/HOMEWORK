Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
string num = Convert.ToString(Console.ReadLine());
int size = num.Length;
if (size == 0)
{
    Console.WriteLine("НИЧЕГО НЕ ВВЕДЕНО, ПОПРОБУЙТЕ ЕЩЕ РАЗ");
}
else
if (size < 3)
{
    Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ - {size}");
    Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА - {size - 1}");
    Console.WriteLine("ВО ВВЕДЕННОМ ЧИСЛЕ НЕТ ТРЕТЕЙ ЦИФРЫ");
}
else
{
    Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ - {size}");
    Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА - {size - 1}");
    Console.WriteLine($"ТРЕТЬЯ ЦИФРА ВВЕДЕННОГО ЧИСЛА - {num[2]}");
}
