namespace Utilities;

public static class Class1
{
	public static void Print()
	{
		Console.WriteLine();

	}

	private static readonly Random Random = new();
	public static void PrintRandomNumber()
	{
		var roll = Random.Next(1, 7);
		Console.WriteLine(roll);
	}
}