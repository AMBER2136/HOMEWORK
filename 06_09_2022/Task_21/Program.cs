

int[] Point1 = new int[3];
int[] Point2 = new int[3];
int[] Interval = new int[3];
Point1 = Prompt("ВВЕДИТЕ КООРДИНАТЫ ПЕРВОЙ ТОЧКИ");
Point2 = Prompt("ВВЕДИТЕ КООРДИНАТЫ ВТОРОЙ ТОЧКИ");
double distance = Distance(ArrayDiff());
System.Console.WriteLine(distance);

int[] Prompt(string invitation)
{
    int[] array = new int[3];
    System.Console.WriteLine(invitation);
    System.Console.WriteLine("x");
    int x = Convert.ToInt32(Console.ReadLine());
    array[0] = x;
    System.Console.WriteLine("y");
    int y = Convert.ToInt32(Console.ReadLine());
    array[1] = y;
    System.Console.WriteLine("z");
    int z = Convert.ToInt32(Console.ReadLine());
    array[2] = z;
    return array;
}

int[] ArrayDiff()
{
Interval[0] = Point1[0] - Point2[0];
Interval[1] = Point1[1] - Point2[1];
Interval[2] = Point1[2] - Point2[2];
return Interval;
}
double Distance(int[] array)
{
    double distance = Math.Sqrt(Math.Pow(array[0], 2) + Math.Pow(array[1], 2)
    + Math.Pow(array[2], 2));
    return distance;
}