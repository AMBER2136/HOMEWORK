System.Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 0)
{
    System.Console.WriteLine($"КОЛИЧЕСТВО ЦИФР В ВВЕДЕННОМ ЧИСЛЕ {1}");
    System.Console.WriteLine($"СУММА ЦИФР ВВЕДЕННОГО ЧИСЛА {0}");
}
else
{
    if (num < 0) num = num * -1;
    int result = 0;
    int digit = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
        digit++;
    }
    System.Console.WriteLine($"КОЛИЧЕСТВО ЦИФР В ВВЕДЕННОМ ЧИСЛЕ {digit}");
    System.Console.WriteLine($"СУММА ЦИФР ВВЕДЕННОГО ЧИСЛА {result}");
}