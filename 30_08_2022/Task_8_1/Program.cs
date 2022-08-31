Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ ЧИСЛО БОЛЬШЕ НОЛЯ");
int x = Convert.ToInt32(Console.ReadLine());
if (x<=0)
{
    Console.WriteLine("ЧИСЛО ДОЛЖНО БЫТЬ БОЛЬШЕ НОЛЯ");
}
else
{
    if (x % 2 == 0)
    {
        while (x > 2)
        {
            Console.Write(x);
            Console.Write(", ");
            x = x-2;
        }
       Console.Write(x); 
    }
    else
    {
        x = x - 1;
        while (x > 2)
        {
            Console.Write(x);
            Console.Write(", ");
            x = x-2;
        }
        Console.Write(x);
    }
}