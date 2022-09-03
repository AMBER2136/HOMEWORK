Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
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
    Console.WriteLine("У ЭТОГО ЧИСЛА НЕТ ТРЕТЬЕЙ ЦИФРЫ");
    int power = count - 1;
    Console.WriteLine($"КОЛИЧЕСТВО ЦИФР В ЧИСЛЕ - {count}");
    Console.WriteLine($"ПОРЯДОК ЧИСЛА - {power}");
}
else
{
    int powe = count - 1;
    Console.WriteLine($"КОЛИЧЕСТВО ЦИФР В ЧИСЛЕ - {count}");
    Console.WriteLine($"ПОРЯДОК ЧИСЛА - {powe}");
}
if(count >2)
{
while (count > 2)
{
    num = a % 10;
    a = a / 10;
    count--;
}
Console.WriteLine($"ТРЕТЬЯ ЦИФРА - {num}");
}

