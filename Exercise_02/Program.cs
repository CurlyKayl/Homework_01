Console.Clear();

Console.WriteLine("Введите первое число: ");
string numberStr1 = Console.ReadLine();
int number1 = Convert.ToInt32(numberStr1);


Console.WriteLine("Введите второе число: ");
string numberStr2 = Console.ReadLine();
int number2 = Convert.ToInt32(numberStr2);

if (number1 > number2)
{
	Console.WriteLine($"Число {number1} больше, чем число {number2}.");
}
else
{
	Console.WriteLine($"Число {number2} больше, чем число {number1}.");
}