internal class Program
{
	private static void Main(string[] args)
	{
		int firstExtremum = 0;
		int secondExtremum = 0;
		Console.WriteLine("Введите первое натуральное число последовательности, не более 1000");
		bool isParsed = int.TryParse(Console.ReadLine(), out int sequenceElement);
		if (isParsed == false)
		{
			Console.WriteLine("Введено некорректное значение, задача завершена...");
		}
		else
		{
			if (sequenceElement < 0 || sequenceElement > 1000)
			{
				Console.WriteLine("Число не входит в заданный диапазон");
			}
			else
			{
				Program.BodyTask(firstExtremum, secondExtremum, sequenceElement);
			}
		}
	}
	private static void BodyTask(int firstExtremum, int secondExtremum, int sequenceElement)
	{
		while (sequenceElement != 0)
		{
			if (sequenceElement > firstExtremum)
			{
				secondExtremum = firstExtremum;
				firstExtremum = sequenceElement;
			}
			else
			{
				if (sequenceElement > secondExtremum && sequenceElement != firstExtremum)
				{
					secondExtremum = sequenceElement;
				}
			}
			Console.WriteLine("Введите следующее натуральное число, не более 1000");
			bool isParsed = int.TryParse(Console.ReadLine(), out sequenceElement);
			if (isParsed == false)
			{
				Console.WriteLine("Введено некорректное значение, задача завершена...");
				break;
			}
			else
			{
				if (sequenceElement < 0 || sequenceElement > 1000)
				{
					Console.WriteLine("Число не входит в заданный диапазон");
					break;
				}
			}
		}
	}
}