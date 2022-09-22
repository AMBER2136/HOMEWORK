(double k1, double k2, double b1, double b2) = Prompt("ВВЕДИТЕ k1",
"ВВЕДИТЕ k2", "ВВЕДИТЕ b1", "ВВЕДИТЕ b2");
Cross(k1, k2, b1, b2);


(double, double, double, double) Prompt(string invit, string invit1,
string invit2, string invit3)
{
    System.Console.WriteLine(invit);
    double k1 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine(invit1);
    double k2 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine(invit2);
    double b1 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine(invit3);
    double b2 = Convert.ToDouble(Console.ReadLine());
    return (k1, k2, b1, b2);
}

int Cross(double k1, double k2, double b1, double b2)
{
    if ((k1 == k2) && (b1 == b2)) { Console.WriteLine("ЭТИ ПРЯМЫЕ СОВПАДАЮТ"); return 0; }
    if ((k1 == k2) && (b1 != b2)) { Console.WriteLine("ЭТИ ПРЯМЫЕ ПАРАЛЛЕЛЬНЫ"); return 0; }

    double x, y;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"X={x}; Y={y}");
    return 0;
}
