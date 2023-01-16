Console.Clear();

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

for (int i = 2; i <= number; i += 2)
{
	Console.Write(i + " ");
}
