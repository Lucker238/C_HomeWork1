Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
if(value % 2 == 0)
{
    Console.WriteLine($"Число {value} является чётным.");
}
else
{
    Console.WriteLine($"Число {value} является нечётным.");
}
