using System;

namespace BaseConverter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			BaseConverter a = new BaseConverter();
			a.Number = 100;
			a.FromBase = "Hexadecimal";
			a.ToBase = "Decimal";
			a.printResult();
			Console.WriteLine();
			Console.WriteLine(a);
			Console.WriteLine();
			a.clear();
			a.printResult();
			Console.WriteLine();

		}
	}
}
