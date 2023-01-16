Console.Clear();

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int result = number % 2;

if (result == 0)
{
	Console.WriteLine("Число является четным.");
}
else
{
	Console.WriteLine("Число является нечетным.");
}
