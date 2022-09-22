
Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО ЧИСЕЛ");
int quantity = Convert.ToInt32(Console.ReadLine());
int num = 0;
for (int count = 0; count < quantity; count++)
{
    Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
    double digit = Convert.ToDouble(Console.ReadLine());
    if (digit > 0) { num++; }
}
Console.WriteLine($"ВВЕДЕНО {num} ЧИСЕЛ БОЛЬШЕ 0");
