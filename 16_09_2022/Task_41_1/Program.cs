int random = new Random().Next(1,9);
int num = 0; 
for (int count = 0; count < random; count++)
{
Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
double digit = Convert.ToDouble(Console.ReadLine());
if (digit>0) {num++;}  
}
Console.WriteLine($"ВВЕДЕНО {num} ЧИСЕЛ БОЛЬШЕ 0");