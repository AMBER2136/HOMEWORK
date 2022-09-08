
string number = Prompt("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО В ДИАПАЗОНЕ ОТ 9 ДО 2 147 483 647");
int digit = Convert.ToInt32(number);
int size = number.Length;
System.Console.WriteLine($"ВВЕДЕНО ЧИСЛО {number}");
bool test = Validate(size);
System.Console.WriteLine($"ПРОВЕРКА - ЧИСЛО БОЛЬШЕ 9 {test}");
if (Validate(size) == true)
{
    bool q = Test(number, size);
    System.Console.WriteLine($"ВОЗВРАТ ИЗ ФУНКЦИИ @Test@ - {q}");
    if (q == true) System.Console.WriteLine("ЭТО ЧИСЛО - ПАЛИНДРОМ");
    else System.Console.WriteLine("ЭТО ЧИСЛО - НЕ ПАЛИНДРОМ");
}
else
{
    Message();
}

// ФУНКЦИИ
//ПРОВЕРКА: ПАЛИНДРОМ ИЛИ НЕТ?

bool Test(string number, int size)
{
    int test1 = 0;
    bool z;
    for (int c = 0, d = 0; c < (size / 2); d++, c++)
    {
        if (number[0 + d] == number[size - (d + 1)]) test1++;
        else test1--;
    }
    if (test1 == (size / 2)) z = true;
    else z = false;
    return z;
}
// ПРЕДУПРЕЖДЕНИЕ
void Message()
{
    System.Console.WriteLine("ВВЕДЕННОЕ ЧИСЛЕ ВНЕ УКАЗАННОГО ДИАПАЗОНА");
}
// ПРИГЛАШЕНИЕ
string Prompt(string prompt)
{
    System.Console.WriteLine(prompt);
    string num = Console.ReadLine();
    return num;
}
// ПРОВЕРКА
bool Validate(int a)
{
    if (digit > 9) return true;
    else return false;
}
