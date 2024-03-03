Console.Clear();
Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow(number2, 2));

if (number == result)
{
    Console.WriteLine($"Число {number} является квадратом числа {number2}");
}

else
{
    Console.WriteLine($"Число {number} не является квадратом числа {number2}"); 
}