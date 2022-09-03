Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
int b = a;
int num = 0;
while (b > 1)
{
    b = b / 10;
    count++;
}
if (count < 3)
{
    int power = count - 1;
    Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ - {count}");
    Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА - {power}");
    Console.WriteLine("ВО ВВЕДЕННОМ ЧИСЛЕ НЕТ ТРЕТЬЕЙ ЦИФРЫ");
}
else
{
    int powe = count - 1;
    Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ ЧИСЛЕ - {count}");
    Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА - {powe}");
}
if (count > 2)
{
    while (count > 2)
    {
        num = a % 10;
        a = a / 10;
        count--;
    }
    Console.WriteLine($"ТРЕТЬЯ ЦИФРА ВВЕДЕННОГО ЧИСЛА - {num}");
}

//ВАРИАНТ 2.

// Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
// string num = Console.ReadLine();
// char[] numm = num.ToCharArray();
// int size = numm.Length;

// if (size < 3)
// {
//     Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ - {size}");
//     Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА - {size - 1}");
//     Console.WriteLine("ВО ВВЕДЕННОМ ЧИСЛЕ НЕТ ТРЕТЬЕЙ ЦИФРЫ");
// }
// else{
// Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ - {size}");
// Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА - {size - 1}");
// Console.WriteLine($"ТРЕТЬЯ ЦИФРА ВВЕДЕННОГО ЧИСЛА - {numm[2]}");
// }



