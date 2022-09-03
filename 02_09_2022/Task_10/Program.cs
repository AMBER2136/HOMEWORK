// ВАРИАНТ 1.

// Console.WriteLine("ВВЕДИТЕ ТРЕХЗНАЧНОЕ ЧИСЛО");
// string a = Console.ReadLine();
// //Console.WriteLine(a);
// Second(a);
// void Second(string a)
// {
//     char[] num = a.ToCharArray();
//     int b = num.Length;
//     if ((b < 3) || (b > 3))
//     {
//         Console.WriteLine("ВЫ ВВЕЛИ НЕ ТРЕХЗНАЧНОЕ ЧИСЛО");
//     }
//     else
//         Console.WriteLine(num[1]);
// }

// ВАРИАНТ 2.
Console.WriteLine("ВВЕДИТЕ ТРЕХЗНАЧНОЕ ЧИСЛО");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int c = 0;
if ((a < 100) || (a > 999))
{
    Console.WriteLine("ВЫ ВВЕЛИ НЕ ТРЕХЗНАЧНОЕ ЧИСЛО");
    Console.WriteLine("ПОПРОБУЙТЕ ЕЩЕ РАЗ");
}
else
{
    b = a % 100;
    c = b / 10;
    Console.WriteLine(c);
}
