(double w, int e) = Prompt("ВВЕДИТЕ ЧИСЛО - ОСНОВАНИЕ СТЕПЕНИ",
        "ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО - ПОКАЗАТЕЛЬ СТЕПЕНИ");
Power(w,e);

(double, int) Prompt(string invit, string invit1)
{
    System.Console.WriteLine(invit);
    double a = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine(invit1);
    int b = Convert.ToInt32(Console.ReadLine());
    return (a, b);
}

void Power(double bas, int pow)
{
    double q = bas;
    if (pow == 0) System.Console.WriteLine("РЕЗУЛЬТАТ: 1");
    if (pow > 0)
    {
        for (int i = 1; i < pow; i++)
        {
            bas = q * bas;
        }
        double presult = bas;
        System.Console.WriteLine($"РЕЗУЛЬТАТ: {presult}");
    }
    if (pow < 0)
    {
        for (int i = pow; i < -1; i++)
        {
            bas = q * bas;
        }
        double nresult = 1 / bas;
        System.Console.WriteLine($"РЕЗУЛЬТАТ: {nresult}");
    }
}

