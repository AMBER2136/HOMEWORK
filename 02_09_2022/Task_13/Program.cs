Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
int num = 0;
int b=0;
if (a == 0)
{
    b = a + 1;
}
if (a > 0)
{
    b = a;
}
while (b > 0)
{
    b = b / 10;
    count++;
}
if (count < 3)
{
    int power = count - 1;
    Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ = {count}");
    Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА = {power}");
    Console.WriteLine("ВО ВВЕДЕННОМ ЧИСЛЕ НЕТ ТРЕТЬЕЙ ЦИФРЫ");
}
else
{
    int powe = count - 1;
    Console.WriteLine($"КОЛИЧЕСТВО ЦИФР ВО ВВЕДЕННОМ ЧИСЛЕ ЧИСЛЕ = {count}");
    Console.WriteLine($"ПОРЯДОК ВВЕДЕННОГО ЧИСЛА = {powe}");
}
if (count > 2)
{
    while (count > 2)
    {
        num = a % 10;
        a = a / 10;
        count--;
    }
    Console.WriteLine($"ТРЕТЬЯ ЦИФРА ВВЕДЕННОГО ЧИСЛА = {num}");
}



