Console.Clear();

Console.WriteLine("Задайте количество элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray];

for (int i = 0; i < sizeArray; i++)
{
	Console.Write($"Введите {i + 1}-й элемент массива: ");
	string arrElem = Convert.ToString(Console.ReadLine()!);
	array[i] = arrElem;
}
int count = 0;
foreach (string arrElem in array)
{
	if (array.Length <= 3)
	{
		count++;
	}
}