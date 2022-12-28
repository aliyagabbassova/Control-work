// See https://aka.ms/new-console-template for more information

string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
int maxlength = 3;
string[] ShortArray(string[] array)
	{
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
		for (int i = 0; i < length; i++)
		{
			if(array[i].Length <= maxlength)
			{
				result[count] = array[i];
				count++;
			}
		}
			Array.Resize(ref result, count);
			
			return result;
	}
    void PrintArray(string[] array)
	{
		if(array.Length == 0)
		{
			Console.WriteLine("Соответсвующего элемента массива не существует");
		}
		else
		{
			Array.ForEach(array, (str) => Console.Write($"{str} "));
			Console.WriteLine();
		}
	}
    void PrintTask(string[] array)
{
	Console.WriteLine("Дан массив:");
	PrintArray(array);
	string[] newArray = ShortArray(array);
	Console.WriteLine($"Длина строки элемента должна быть меньше или равна {maxlength}");
	PrintArray(newArray);
	Console.WriteLine();
}
	
PrintTask(array1);
PrintTask(array2);
PrintTask(array3);