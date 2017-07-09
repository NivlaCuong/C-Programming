using System;
namespace NameTag
{
	public class nameTagTester
	{
		public static void Main(string[] args)
		{
			NameTag a = new NameTag("Cuong Nguyen", "Berkeley City COllege");
			Console.WriteLine(a);
			Console.WriteLine();
			a.printBlankTag();
			a.clear();
			Console.WriteLine();
			Console.WriteLine(a);


		}
	}
}

