using System;
namespace Person
{
	public class PersonTester
	{
		public static void Main(string[] args)
		{
			Person a = new Person("Cuong", "Nguyen");
			Console.WriteLine("-----Testing ID-----");
			Console.WriteLine(a.getID());
			Person b = new Person();
			Console.WriteLine(b.getID());
			Person c = new Person();
			Console.WriteLine(c.getID());
			Person d = new Person();
			Console.WriteLine(d.getID());
			Console.WriteLine("-----Testing ToString Method Person b-----");
			Console.WriteLine(b);
			Console.WriteLine("-----Testing ToString Method Person a-----");
			Console.WriteLine(a);
			Console.WriteLine("-----Testing Properties-----");
			d.printLastName();
			d.FirstName = "Calvin";
			Console.WriteLine(d.FirstName);
		}
	}
}


