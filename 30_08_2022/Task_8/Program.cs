Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО БОЛЬШЕ НОЛЯ");
int x = Convert.ToInt32(Console.ReadLine());
int y = 2;
if (x<=0)
{
    Console.WriteLine("ЧИСЛО ДОЛЖНО БЫТЬ БОЛЬШЕ НОЛЯ");
}
else
{
    if (x % 2 == 0)
    {
        while (y < x)
        {
            Console.Write(y);
            Console.Write(", ");
            y = y + 2;
        }
        Console.Write(y);
    }
    else
    {
    while (y < (x-1))
        {
            Console.Write(y);
            Console.Write(", ");
            y = y + 2;
        }
        Console.Write(y);
    }
}