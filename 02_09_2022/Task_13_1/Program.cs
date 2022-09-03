Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
string num = Console.ReadLine();
char[] numm = num.ToCharArray();
int size = numm.Length;

if (size < 3)
{
    Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ - {size}");
    Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА - {size - 1}");
    Console.WriteLine("ВО ВВЕДЕННОМ ЧИСЛЕ НЕТ ТРЕТЬЕЙ ЦИФРЫ");
}
else{
Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ - {size}");
Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА - {size - 1}");
Console.WriteLine($"ТРЕТЬЯ ЦИФРА ВВЕДЕННОГО ЧИСЛА - {numm[2]}");
}
