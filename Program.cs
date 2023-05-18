Console.Clear();

Console.WriteLine("Задайте количество элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray]; // создаём массив

for (int i = 0; i < sizeArray; i++) // помещаем в массив элементы, введённые пользователем
{
	Console.Write($"Введите {i + 1}-й элемент массива: ");
	string arrElem = Convert.ToString(Console.ReadLine()!);
	array[i] = arrElem;
}
int count = 0;
foreach (string arrElem in array) // проверяем на ограничение по символам каждого элемента
{
	if (array.Length <= 3)
	{
		count++;
	}
}
string[] newArray = new string[count]; //создаём новый массив с необходимым количеством ячеек



