Console.WriteLine("ВВЕДИТЕ ЦИФРУ ОТ 1 ДО 7");
int dig = Convert.ToInt32(Console.ReadLine());
if (((dig > 7) && (dig<10))|| (dig == 0))
{
    Console.WriteLine("ВВЕДЕНА ЦИФРА ЗА ПРЕДЕЛАМИ ДИАПАЗОНА");
    Console.WriteLine("ПОПРОБУЙТЕ ЕЩЕ РАЗ");
}
else
if (dig > 9)
{
    Console.WriteLine("ВВЕДЕНО ЧИСЛО, А НЕ ЦИФРА");
    Console.WriteLine("ПОПРОБУЙТЕ ЕЩЕ РАЗ");
}
else
if (dig < 0)
{
    Console.WriteLine("ВВЕДЕНО ОТРИЦАТЕЛЬНОЕ ЧИСЛО");
    Console.WriteLine("ПОПРОБУЙТЕ ЕЩЕ РАЗ");
}
else
if (dig < 6)
{
    Console.WriteLine("НЕТ, ЭТО РАБОЧИЙ ДЕНЬ");
}
else
if (dig > 5)
{
    Console.WriteLine("ДА, ЭТО ВЫХОДНОЙ ДЕНЬ");
}