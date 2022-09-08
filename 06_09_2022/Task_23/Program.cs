Cube("ВВЕДИТЕ ЦЕЛОЕ ПОЛОЖИТЕЛЬНОЕ ЧИСЛО");

void Cube(string prompt)
{
    System.Console.WriteLine(prompt);
    double input = Convert.ToInt32(Console.ReadLine());
    if (input < 1) System.Console.WriteLine("ВВЕДЕННОЕ ЧИСЛО ВНЕ ДОПУСТИМОГО ДИАПАЗОНА");
    else
    {
        for (double i = 1; i <= input; i++)
        {
            double cube = Math.Pow(i, 3);
            System.Console.Write($" {cube}");
        }
    }
}

